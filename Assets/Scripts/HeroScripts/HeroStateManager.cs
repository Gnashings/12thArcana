using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStateManager : MonoBehaviour
{
    public bool paused;
    public AuraDetection aura;
    public HeroStats stats;
    public Rigidbody rBody;
    public HeroAttacks heroAttacks;
    public GameObject leftWaypoint;
    public GameObject rightWaypoint;
    public GameObject dodgeLeftWaypoint;
    public GameObject dodgeRightWaypoint;
    [HideInInspector]
    public HeroBaseState currentState;

    public HeroIdleState idleState = new HeroIdleState();
    public HeroWanderState wanderState = new HeroWanderState();
    public HeroDodgeState dodgeState = new HeroDodgeState();
    public HeroBlockState blockState = new HeroBlockState();
    public HeroJumpState jumpState = new HeroJumpState();
    public HeroGroundAttackState attackState = new HeroGroundAttackState();

    void Start()
    {
        currentState = idleState;

        currentState.EnterState(this);
    }

    void Update()
    {
        if(!LevelProgress.isPaused)
        {
            currentState.UpdateState(this);
        }    
        
    }
    void FixedUpdate()
    {
        
    }

    public void SwitchState(HeroBaseState state)
    {
        //call the exit before swapping states.
        currentState.ExitState(this);

        //set the new state
        currentState = state;
        state.EnterState(this);
    }

    public void DumpAuraMemory()
    {
        aura.enabled = false;
        aura.jumpDecision = false;
        aura.dodgeDecision = false;
    }

    public void EnableAura()
    {
        aura.enabled = true;
    }

    IEnumerator BlockTimer()
    {
        yield return new WaitForSeconds(1);
    }
}
