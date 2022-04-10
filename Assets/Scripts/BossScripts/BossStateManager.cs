using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;


public class BossStateManager : MonoBehaviour
{
    public bool paused;
    public BossControls inputs;
    public BossAttackManager bossAttacks;
    [HideInInspector]
    public InputAction attack;
    [HideInInspector]
    public InputAction plume;
    [HideInInspector]
    public InputAction homing;
    [HideInInspector]
    public BossBaseState currentState;
    public BossIdleState idleState = new BossIdleState();
    public BossPlumeAttackState plumeAttackState = new BossPlumeAttackState();
    public BossFireBallState fireBallState = new BossFireBallState();
    public BossHomingAttackState homingAttackState = new BossHomingAttackState();
    public Animator anims;
    void Awake()
    {
        inputs = new BossControls();
        anims.Play("lich_idle_anim");
    }

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
            LevelProgress.bossState = currentState.ToString();
        }
        
    }

    public void SwitchState(BossBaseState state)
    {
        //call the exit before swapping states.
        currentState.ExitState(this);

        //set the new state
        currentState = state;
        state.EnterState(this);
    }

    private void OnEnable()
    {
        attack = inputs.BossInputs.Projectile;
        plume = inputs.BossInputs.Plume;
        homing = inputs.BossInputs.Homing;
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
