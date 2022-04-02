using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroJumpState : HeroBaseState
{
    public override void EnterState(HeroStateManager heroState)
    {
        heroState.DumpAuraMemory();

        heroState.rBody.AddForce(heroState.transform.up * heroState.stats.jumpHeight);
        heroState.heroAttacks.FireProjectile();
    }

    public override void UpdateState(HeroStateManager heroState)
    {
        if(heroState.rBody.IsSleeping())
        {
            heroState.SwitchState(heroState.idleState);
        }
    }

    public override void ExitState(HeroStateManager heroState)
    {

    }
}
