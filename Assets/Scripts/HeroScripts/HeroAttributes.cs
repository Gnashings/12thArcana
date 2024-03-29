using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroAttributes : MonoBehaviour
{
    public float totalHealth;
    public float hpPerLevel;
    [HideInInspector]
    public float health;
    public float jumpChance;
    public float jumpChanceMod;
    public float jumpHeight;
    private float timer;
    public bool isBlocking;
    void Start()
    {
        Debug.Log("Level : " + LevelProgress.levelCount);
        jumpChance += jumpChanceMod * LevelProgress.levelCount;
        health = totalHealth + (hpPerLevel * LevelProgress.levelCount);
        Debug.Log("HP : " + health);
    }

    void FixedUpdate()
    {
        timer += Time.deltaTime;
    }

    public void TakeDamage(float damage)
    {
        if(!isBlocking)
        {
            health -= damage;
        }
        if(health <= 0)
        {
            //Debug.Log(timer + " TIMER");

            //LevelProgress.levelCount++;
            //SceneManager.LoadScene("Testing Scene");
            gameObject.GetComponent<HeroStateManager>().enabled = false;
            gameObject.GetComponent<HeroAttributes>().enabled = false;
        }
    }

    private void OnDisable()
    {
        LevelProgress.levelCount++;
        LevelProgress.timePlayed += timer;
    }
}
