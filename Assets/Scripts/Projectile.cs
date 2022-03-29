using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public bool isHeroProjectile;
    private void OnTriggerEnter(Collider other)
    {
        if(isHeroProjectile == false)
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
        else
        {
            if (other.CompareTag("Boss"))
            {
                other.GetComponentInParent<BossAttributes>().TakeDamage(20);
                Destroy(gameObject);
            }
        }

    }
}
