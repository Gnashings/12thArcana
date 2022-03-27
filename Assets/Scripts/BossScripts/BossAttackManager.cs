using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttackManager : MonoBehaviour
{
    public GameObject ProjectileSpawn;
    public GameObject ProjectilePrefab;
    public float projectileSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void FireProjectile()
    {
        GameObject attack;
        attack = Instantiate(ProjectilePrefab, transform.position, transform.rotation) as GameObject;
        attack.GetComponent<Rigidbody>().AddForce(transform.right * projectileSpeed);
    }
}
