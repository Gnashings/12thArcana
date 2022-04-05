using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroIdleState : HeroBaseState
{
    public override void EnterState(HeroStateManager heroState)
    {
        //testing states
        // Debug.Log("swapping to wondering state");
    }

    public override void UpdateState(HeroStateManager heroState)
    {
        
        
        if (heroState.aura.jumpDecision)
        {

            heroState.SwitchState(heroState.jumpState);
        }
        else if (heroState.aura.blockDecision)
        {
            heroState.SwitchState(heroState.blockState);
        }
        else
        {
            heroState.SwitchState(heroState.wanderState);
        }

    }

    public override void ExitState(HeroStateManager heroState)
    {

    }

}
