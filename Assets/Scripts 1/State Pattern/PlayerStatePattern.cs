using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatePattern : MonoBehaviour
{
    public Animator Animator;
    public StateMachine StateMachine;

    public IdleState IdleState;
    public RunState RunState;

    private void Awake()
    {
        StateMachine = new StateMachine();

        IdleState = new IdleState(this);
        RunState = new RunState(this);
    }

    private void Start()
    {
        StateMachine.ChangeState(IdleState);
    }

    private void Update()
    {
        StateMachine.Update();
    }

    public bool HasMoveInput()
    {
        return Input.GetAxisRaw("Horizontal") != 0;
    }

    public void Move()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 5f);
    }
}
