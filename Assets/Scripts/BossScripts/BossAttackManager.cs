using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttackManager : MonoBehaviour
{
    [Header("Fireball")]
    public GameObject projectileSpawn;
    public GameObject projectilePrefab;
    public float projectileSpeed;
    public float damageFB;
    [Header("Plume")]
    public GameObject plumeSpawn;
    public GameObject plumePrefab;
    public float damagePlume;
    [Header("Homing Attack")]
    public float damageHoming;
    //public GameObject homingPrefab;

    public GameObject hero;
    void Start()
    {
        hero = GameObject.FindGameObjectWithTag("Hero");
        //Debug.Log(hero);
    }

    void Update()
    {

    }

    public void FireProjectile()
    {
        GameObject attack;
        attack = Instantiate(projectilePrefab, projectileSpawn.transform.position, transform.rotation) as GameObject;
        attack.GetComponent<Rigidbody>().AddForce(-transform.right * projectileSpeed);
        attack.GetComponent<Projectile>().damage = damageFB;
    }

    public void PlumeAttack()
    {
        plumeSpawn.transform.position = hero.transform.position;
        GameObject plume;
        plume = Instantiate(plumePrefab, plumeSpawn.transform.position, transform.rotation) as GameObject;
        plume.GetComponent<Plume>().damage = damagePlume;
    }

    public void HomingAttack()
    {
        GameObject attack;
        attack = Instantiate(projectilePrefab, projectileSpawn.transform.position, transform.rotation) as GameObject;
        attack.GetComponent<Projectile>().isHoming = true;
        attack.GetComponent<Projectile>().damage = damageHoming;
    }

}
