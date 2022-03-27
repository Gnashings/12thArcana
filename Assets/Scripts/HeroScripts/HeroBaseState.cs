using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HeroBaseState
{
    // Start is called before the first frame update
    public abstract void EnterState(HeroStateManager heroState);

    //updated once per frame
    public abstract void UpdateState(HeroStateManager heroState);

    //called when a state is unloaded
    public abstract void ExitState(HeroStateManager heroState);
}
