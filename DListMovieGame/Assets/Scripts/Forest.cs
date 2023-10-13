using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest : MonoBehaviour
{
    public GameObject[] treesPrefab;
    //public float spawnRangeX = 20;
    //public float spawnDepth = -20;
    //public float spawnHeight = .5f;
    //public float spawnPosZ = -10;
    //public float spawnRangeZ = 15;
    public float spawnAmount = 420;

    //GameObject atom1;
    public Vector3 spawn, size;


    void Start()
    {

        for (int i = 0; i <= spawnAmount; i++)
        {
            Spawn();
        }
    }
    
    void Spawn()
    {
            int treeIndex = Random.Range(0, treesPrefab.Length);
        //Vector3 spawnPos = new Vector3(Random.Range(spawnDepth, spawnRangeX), spawnHeight, Random.Range(spawnRangeZ, spawnPosZ));

        Vector3 spawnPos = spawn + new Vector3(Random.Range(-size.x / 2, size.x /2), .5f, Random.Range(-size.z / 2, size.z / 2));

            Instantiate(treesPrefab[treeIndex], spawnPos, treesPrefab[treeIndex].transform.rotation);
    }
        
    
}
