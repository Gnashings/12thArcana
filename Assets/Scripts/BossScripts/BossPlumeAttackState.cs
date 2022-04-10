using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPlumeAttackState : BossBaseState
{
    bool finishedAttacking;
    public override void EnterState(BossStateManager bossState)
    {
        bossState.bossAttacks.PlumeAttack();
        bossState.StartCoroutine(AttackCD());
        bossState.anims.Play("lich_plume_anim");
    }

    public override void UpdateState(BossStateManager bossState)
    {
        if (finishedAttacking == true)
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
        yield return new WaitForSeconds(3);
        finishedAttacking = true;
    }


}
