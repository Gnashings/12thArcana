using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraDetection : MonoBehaviour
{
    public bool jumpDecision;
    public bool dodgeDecision;
    public bool blockDecision;

    private float jumpChance;

    void Start()
    {
        jumpChance = GetComponentInParent<HeroAttributes>().jumpChance;
    }


    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {    
    }

    private void OnTriggerExit(Collider other)
    {
    }

    public void CheckJumpDecision()
    {
        if (Random.value <= jumpChance)
        {
            jumpDecision = true;
        }
        else
            jumpDecision = false;
    }

    public void CheckDodgeDecision()
    {
        if (Random.value <= jumpChance)
        {
            dodgeDecision = true;
        }
        else
            dodgeDecision = false;
    }

    public void CheckBlockDecision()
    {
        if (Random.value <= jumpChance)
        {
            blockDecision = true;
        }
        else
            blockDecision = false;
    }
}
