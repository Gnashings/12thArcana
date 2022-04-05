using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plume : MonoBehaviour
{
    public GameObject windUpHitbox;
    public GameObject damageHitbox;
    public float windUp;
    public float activeTime;
    public float damage;

    private bool started;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(PlumeLifeTime());
        
        
    }
    IEnumerator PlumeLifeTime()
    {
        while (LevelProgress.isPaused)
        {
            yield return null;
        }
        windUpHitbox.SetActive(true);
        yield return new WaitForSeconds(windUp);
        windUpHitbox.SetActive(false);

        damageHitbox.SetActive(true);
        yield return new WaitForSeconds(activeTime);
        damageHitbox.SetActive(false);

        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HeroHurtbox"))
        {
            other.GetComponentInParent<HeroStats>().TakeDamage(20);
            Destroy(gameObject);
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
