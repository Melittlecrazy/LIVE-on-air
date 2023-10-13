using bob;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ExtraInputs : MonoBehaviour
{
    public ThirdPersonInput inputActions;
    private int _animIDBash;
    private Animator _animator;



    void Awake()
    {
        AssignAnimationIDs();
        inputActions = new ThirdPersonInput();
        //OnBash();

        inputActions.Player.Swing.performed += cntxt => { _animator.SetBool(_animIDBash, true); };
        inputActions.Player.Swing.canceled += cntxt => { _animator.SetBool(_animIDBash, false); };
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBash(InputAction.CallbackContext cont)
    {
    
    }
    private void AssignAnimationIDs()
    {
        _animIDBash = Animator.StringToHash("Swong");
    }
    private void OnEnable()
    {
        inputActions.Player.Enable();
    }
    private void OnDisable()
    {
        inputActions.Player.Disable();
    }
}
