using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStateManager : MonoBehaviour
{
    public BossAttackManager bossAttacks;

    [HideInInspector]
    public BossBaseState currentState;
    public BossIdleState idleState = new BossIdleState();
    public BossAttackingState attackingState = new BossAttackingState();

    void Start()
    {
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
}
