using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroIdleState : HeroBaseState
{
    public override void EnterState(HeroStateManager heroState)
    {

    }

    public override void UpdateState(HeroStateManager heroState)
    {
        if(heroState.aura.jumpDecision)
        {

            heroState.SwitchState(heroState.jumpState);
            
        }
    }

    public override void ExitState(HeroStateManager heroState)
    {
        Debug.Log("IDLE STATE: LEAVING");
    }

}
