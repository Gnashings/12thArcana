using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlumeDamage : MonoBehaviour
{
    public Plume plume;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("HeroHurtbox"))
        {
            other.GetComponentInParent<HeroAttributes>().TakeDamage(plume.damage);
        }

    }
}
