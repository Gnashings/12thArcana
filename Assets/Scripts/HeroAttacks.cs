using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAttacks : MonoBehaviour
{
    public GameObject ProjectileSpawn;
    public GameObject ProjectilePrefab;
    public float projectileSpeed;
    public float damage;
    public float damagePerLevel;
    void Start()
    {
        damage += damagePerLevel * LevelProgress.levelCount;
        Debug.Log("damage" + damage);
    }

    void Update()
    {

    }

    public void FireProjectile()
    {
        GameObject attack;
        attack = Instantiate(ProjectilePrefab, ProjectileSpawn.transform.position, transform.rotation) as GameObject;
        attack.GetComponent<Rigidbody>().AddForce(transform.right * projectileSpeed);
        attack.GetComponent<Projectile>().damage = damage;
    }
}
