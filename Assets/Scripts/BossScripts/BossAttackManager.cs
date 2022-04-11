using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttackManager : MonoBehaviour
{
    [Header("Fireball")]
    public GameObject projectileSpawn;
    public GameObject projectilePrefab;
    public float projectileSpeed;

    [Header("Plume")]
    public GameObject plumeSpawn;
    public GameObject plumePrefab;

    //[Header("Homing Attack")]
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
    }

    public void PlumeAttack()
    {
        plumeSpawn.transform.position = hero.transform.position;
        GameObject plume;
        plume = Instantiate(plumePrefab, plumeSpawn.transform.position, transform.rotation) as GameObject;
    }

    public void HomingAttack()
    {
        GameObject attack;
        attack = Instantiate(projectilePrefab, projectileSpawn.transform.position, transform.rotation) as GameObject;
        attack.GetComponent<Projectile>().isHoming = true;
    }

}
