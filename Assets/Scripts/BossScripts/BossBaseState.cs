using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public abstract class BossBaseState
{
    //affects states upon loading
    public abstract void EnterState(BossStateManager bossState);

    //updated once per frame
    public abstract void UpdateState(BossStateManager bossState);

    //called when a state is unloaded
    public abstract void ExitState(BossStateManager bossState);
}
