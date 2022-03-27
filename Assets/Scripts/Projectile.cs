using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HeroAura"))
        {
            other.GetComponent<AuraDetection>().CheckJumpDecision();
        }
        if (other.CompareTag("Hero"))
        {
            other.GetComponentInParent<HeroStats>().TakeDamage(20);
            Destroy(gameObject);
        }
    }
}
