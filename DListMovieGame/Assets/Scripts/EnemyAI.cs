using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent slasher;

    public float health;

    public Transform player;

    public LayerMask whatISGround, whatPlayer;

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkRange;

    public float swing;
    bool swong;
    //GameObject gun;

    public float sightRange, attacks;
    public bool playerInRange, playerInAttack;

    private void Awake()
    {
        player = GameObject.Find("Firstperson").transform;
        slasher = GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        playerInRange = Physics.CheckSphere(transform.position, sightRange, whatPlayer);

        playerInAttack = Physics.CheckSphere(transform.position, attacks, whatPlayer);

        if (!playerInRange && !playerInAttack) Patrolling();
        if (playerInRange && !playerInAttack) Chase();
        if (playerInRange && playerInAttack) Attack();
    }   

    void Patrolling()
    {
        if (!walkPointSet) SearchWalk();

        if (walkPointSet) slasher.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        if (distanceToWalkPoint.sqrMagnitude < 1f) walkPointSet = false;


    }

    private void SearchWalk()
    {
        float randomZ = Random.Range(-walkRange, walkRange);
        float randomX = Random.Range(-walkRange, walkRange);

        walkPoint = new Vector3(transform.position.x + randomX , transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatISGround)) walkPointSet = true;

    }

    private void Chase()
    {
        slasher.SetDestination(player.position);


    }

    private void Attack()
    {
        slasher.SetDestination(transform.position);

        transform.LookAt(player);

        if (!swong)
        {
            //Rigidbody rb = Instantiate(gun, transform.postion, Quaternion.identiry).GetComponent<RigidBody>();
            //rb.AddForce(transform.up * 3f, ForceMode. Impulse);



            swong = true;
            Invoke(nameof(ResetAttack), swing);
        }
    }

    private void ResetAttack()
    {
        swong = false;
    }

    public void Stun(int damage)
    {
        health -= damage;
        if (health < 0) Invoke(nameof(bob), 2f);
    }

    void bob()
    {
        print("ow");
    }
}
