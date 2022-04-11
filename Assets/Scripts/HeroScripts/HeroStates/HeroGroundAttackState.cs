using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroGroundAttackState : HeroBaseState
{
    bool doneAttacking;
    public override void EnterState(HeroStateManager heroState)
    {
        doneAttacking = false;
        heroState.anim.Play("attack_anim");
        heroState.StartCoroutine(AttackCD(heroState));
        
    }

    public override void ExitState(HeroStateManager heroState)
    {
        
    }

    public override void UpdateState(HeroStateManager heroState)
    {
        if(doneAttacking)
        {
            heroState.SwitchState(heroState.idleState);
        }
    }

    IEnumerator AttackCD(HeroStateManager heroState)
    {
        doneAttacking = false;
        yield return new WaitForSeconds(0.5f);
        heroState.heroAttacks.FireProjectile();
        heroState.throwSound.Play();
        yield return new WaitForSeconds(0.5f);
        doneAttacking = true;
    }
}
