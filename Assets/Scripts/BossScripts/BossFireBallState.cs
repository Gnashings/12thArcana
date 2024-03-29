using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class BossFireBallState : BossBaseState
{
    bool finishedAttacking;
    public override void EnterState(BossStateManager bossState)
    {
        bossState.bossAttacks.FireProjectile();
        bossState.StartCoroutine(AttackCD());
        bossState.anims.Play("lich_FB_anim");
    }

    public override void UpdateState(BossStateManager bossState)
    {
        if(finishedAttacking == true)
        {
            bossState.SwitchState(bossState.idleState);
        }
    }

    public override void ExitState(BossStateManager bossState)
    {
        //Debug.Log("ATTACK STATE: EXIT STATE");
    }
    IEnumerator AttackCD()
    {
        finishedAttacking = false;
        yield return new WaitForSeconds(2);
        finishedAttacking = true;
    }


}
