using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BossIdleState : BossBaseState
{

    void Start()
    {
        
    }

    public override void EnterState(BossStateManager bossState)
    {
        //Debug.Log("IDLE STATE: ENTERING");
    }

    public override void UpdateState(BossStateManager bossState)
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            bossState.SwitchState(bossState.attackingState);
        }
    }
    
    public override void ExitState(BossStateManager bossState)
    {
        //Debug.Log("IDLE STATE: LEAVING");
    }

    void Update()
    {
        
    }

}
