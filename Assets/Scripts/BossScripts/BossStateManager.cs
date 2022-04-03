using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BossStateManager : MonoBehaviour
{
    public BossControls bossControls;
    public BossAttackManager bossAttacks;

    public InputAction attack;
    public InputAction plume;
    public InputAction homing;

    [HideInInspector]
    public BossBaseState currentState;
    public BossIdleState idleState = new BossIdleState();
    public BossPlumeAttackState plumeAttackState = new BossPlumeAttackState();
    public BossFireBallState fireBallState = new BossFireBallState();
    public BossHomingAttackState homingAttackState = new BossHomingAttackState();
   
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
        plume.Enable();
        homing.Enable();
    }

    private void OnDisable()
    {
        attack.Disable();
        plume.Disable();
        homing.Disable();
    }
}
