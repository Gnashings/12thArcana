using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBlockState : HeroBaseState
{
    bool doneBlocking;
    public override void EnterState(HeroStateManager heroState)
    {
        heroState.EnableAura();
        heroState.stats.isBlocking = true;
        heroState.aura.blockDecision = false;
        doneBlocking = false;
        heroState.StartCoroutine(BlockCD());
        //Debug.Log("Im blockin");
    }

    public override void ExitState(HeroStateManager heroState)
    {
        heroState.stats.isBlocking = false;
    }

    public override void UpdateState(HeroStateManager heroState)
    {
        if (doneBlocking == true)
        {
            heroState.SwitchState(heroState.idleState);
        }
    }

    IEnumerator BlockCD()
    {
        doneBlocking = false;
        yield return new WaitForSeconds(1);
        doneBlocking = true;
    }
}
