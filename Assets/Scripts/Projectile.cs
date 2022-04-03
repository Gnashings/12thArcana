using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public bool isHeroProjectile;
    public bool isHoming;
    private bool startHoming;
    public Rigidbody rb;
    private GameObject hero;
    void Start()
    {
        if(isHoming)
        {
            Debug.Log("im homing");
            rb = GetComponent<Rigidbody>();
            startHoming = false;
            hero = GameObject.FindGameObjectWithTag("HeroHurtbox");
            StartCoroutine(HomingStartOff());
        }
    }

    void FixedUpdate()
    {
        if(startHoming)
        {
            rb.position = Vector3.MoveTowards(gameObject.transform.position, hero.transform.position, Time.deltaTime * 5f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(isHeroProjectile == false)
        {

            if (other.CompareTag("HeroAura"))
            {

                if (isHoming)
                {
                    other.GetComponent<AuraDetection>().CheckBlockDecision();
                }
                else
                    other.GetComponent<AuraDetection>().CheckJumpDecision();
            }
            if (other.CompareTag("HeroHurtbox"))
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

    IEnumerator HomingStartOff()
    {
        rb.AddForce(gameObject.transform.up * 200);
        gameObject.tag = "Homing";
        yield return new WaitForSeconds(1); 
        rb.useGravity = true;
        yield return new WaitForSeconds(0.75f);
        rb.useGravity = false;
        rb.isKinematic = true;
        startHoming = true;
    }
}
