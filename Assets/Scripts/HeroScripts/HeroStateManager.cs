using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStateManager : MonoBehaviour
{
    public AuraDetection aura;
    public HeroStats stats;
    public Rigidbody rBody;

    [HideInInspector]
    public HeroBaseState currentState;

    public HeroIdleState idleState = new HeroIdleState();
    public HeroJumpState jumpState = new HeroJumpState();

    void Start()
    {
        currentState = idleState;

        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(HeroBaseState state)
    {
        //call the exit before swapping states.
        currentState.ExitState(this);

        //set the new state
        currentState = state;
        state.EnterState(this);
    }
}
