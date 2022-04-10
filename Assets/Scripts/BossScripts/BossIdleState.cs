using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BossIdleState : BossBaseState
{
    public override void EnterState(BossStateManager bossState)
    {
        bossState.anims.Play("lich_idle_anim");
    }

    public override void UpdateState(BossStateManager bossState)
    {
        if (bossState.attack.triggered)
        {
            bossState.SwitchState(bossState.fireBallState);
        }
        if (bossState.plume.triggered)
        {
            bossState.SwitchState(bossState.plumeAttackState);
        }
        if (bossState.homing.triggered)
        {
            bossState.SwitchState(bossState.homingAttackState);
        }

    }
    
    public override void ExitState(BossStateManager bossState)
    {
    }

}
