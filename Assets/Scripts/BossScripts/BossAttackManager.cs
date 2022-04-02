using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttackManager : MonoBehaviour
{
    [Header("Fireball")]
    public GameObject projectileSpawn;
    public GameObject projectilePrefab;
    [Header("Plume")]
    public GameObject plumePrefab;
    public float projectileSpeed;
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
        plumePrefab.transform.position = hero.transform.position;
        GameObject plume;
        plume = Instantiate(plumePrefab, hero.transform.position, transform.rotation) as GameObject;
    }

}
