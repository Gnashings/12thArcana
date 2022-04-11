using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHomingAttackState : BossBaseState
{
    bool finishedAttacking;
    public override void EnterState(BossStateManager bossState)
    {
        bossState.bossAttacks.HomingAttack();
        bossState.StartCoroutine(AttackCD());
        bossState.anims.Play("lich_plume_anim");
    }

    public override void ExitState(BossStateManager bossState)
    {

    }

    public override void UpdateState(BossStateManager bossState)
    {
        if (finishedAttacking == true)
        {
            bossState.SwitchState(bossState.idleState);
        }
    }

    IEnumerator AttackCD()
    {
        finishedAttacking = false;
        yield return new WaitForSeconds(3);
        finishedAttacking = true;
    }
}
