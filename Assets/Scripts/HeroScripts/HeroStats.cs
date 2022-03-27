using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStats : MonoBehaviour
{
    public float totalHealth;
    public float health;
    public float jumpChance;
    public float jumpHeight;

    void Start()
    {
        health = totalHealth;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
