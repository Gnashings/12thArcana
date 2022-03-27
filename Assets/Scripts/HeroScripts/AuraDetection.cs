using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraDetection : MonoBehaviour
{
    public bool jumpDecision;
    private float jumpChance;
    void Start()
    {
        jumpChance = GetComponentInParent<HeroStats>().jumpChance;
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
}
