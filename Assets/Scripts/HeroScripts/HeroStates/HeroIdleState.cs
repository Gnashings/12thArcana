using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroIdleState : HeroBaseState
{
    public override void EnterState(HeroStateManager heroState)
    {
        //testing states
       // Debug.Log("swapping to wondering state");
        heroState.SwitchState(heroState.wanderState);   
    }

    public override void UpdateState(HeroStateManager heroState)
    {
        if(heroState.aura.jumpDecision)
        {

            heroState.SwitchState(heroState.jumpState);
        }

        if (heroState.aura.blockDecision)
        {
            heroState.SwitchState(heroState.blockState);
        }

    }

    public override void ExitState(HeroStateManager heroState)
    {
    }

}
