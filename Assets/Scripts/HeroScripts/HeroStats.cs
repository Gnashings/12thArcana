using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroStats : MonoBehaviour
{
    public float totalHealth;
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
        health = totalHealth;
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
            Debug.Log(timer + " TIMER");
            
            LevelProgress.levelCount++;
            SceneManager.LoadScene("Testing Scene");
        }
    }

    private void OnDisable()
    {
        LevelProgress.timePlayed += timer;
    }
}
