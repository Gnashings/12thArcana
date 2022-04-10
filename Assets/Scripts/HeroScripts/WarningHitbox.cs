using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Checks the players aura to provide a warning to dodge.
/// </summary>
public class WarningHitbox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("HeroAura"))
        {
            other.GetComponent<AuraDetection>().CheckDodgeDecision();
        }

    }
}
