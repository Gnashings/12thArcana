using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroJumpState : HeroBaseState
{
    public override void EnterState(HeroStateManager heroState)
    {
        //heroState.DumpAuraMemory();
        heroState.aura.jumpDecision = false;
        heroState.isGrounded = false;
        heroState.rBody.AddForce(heroState.transform.up * heroState.stats.jumpHeight);
        heroState.anim.Play("jump_anim");
        heroState.heroAttacks.FireProjectile();
        
    }
    
    public override void UpdateState(HeroStateManager heroState)
    {
        heroState.aura.jumpDecision = false;
        if (heroState.isGrounded)
        {
            heroState.SwitchState(heroState.idleState);
        }
    }

    public override void ExitState(HeroStateManager heroState)
    {

    }
}
