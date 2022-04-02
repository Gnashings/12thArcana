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
    }

    public override void UpdateState(BossStateManager bossState)
    {
        if (bossState.attack.triggered)
        {
            bossState.SwitchState(bossState.plumeAttackState);
        }
    }
    
    public override void ExitState(BossStateManager bossState)
    {
    }

    void Update()
    {
        
    }

}
