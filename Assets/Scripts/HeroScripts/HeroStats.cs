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

    void Start()
    {
        Debug.Log(LevelProgress.levelCount);
        Debug.Log(LevelProgress.timePlayed);
        jumpChance += jumpChanceMod * LevelProgress.levelCount;
        health = totalHealth;
    }

    void FixedUpdate()
    {
        timer += Time.deltaTime;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Debug.Log(timer + " TIMER");
            LevelProgress.timePlayed += timer;
            LevelProgress.levelCount++;
            SceneManager.LoadScene("Testing Scene");
        }
    }
}
