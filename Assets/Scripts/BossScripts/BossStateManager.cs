using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BossStateManager : MonoBehaviour
{
    public BossControls bossControls;
    public BossAttackManager bossAttacks;

    public InputAction attack;
   
    [HideInInspector]
    public BossBaseState currentState;
    public BossIdleState idleState = new BossIdleState();
    public BossPlumeAttackState plumeAttackState = new BossPlumeAttackState();
    public BossFireBallState fireBallState = new BossFireBallState();

   
    void Start()
    {
        bossControls = new BossControls();
        currentState = idleState;
 
        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(BossBaseState state)
    {
        //call the exit before swapping states.
        currentState.ExitState(this);

        //set the new state
        currentState = state;
        state.EnterState(this);
    }

    public void StartAttackCD()
    {
        StartCoroutine(AttackCD());
    }

    IEnumerator AttackCD()
    {
        yield return new WaitForSeconds(3);
    }

    private void OnEnable()
    {
        //attack = bossControls.BossInputs.Projectile;
        attack.Enable();
    }

    private void OnDisable()
    {
        attack.Disable();
    }
}
