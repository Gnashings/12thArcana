using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossAttributes : MonoBehaviour
{
    public float totalHealth;
    [HideInInspector]
    public float health;

    void Start()
    {
        health = totalHealth;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            LevelProgress.levelCount++;
            SceneManager.LoadScene("Lose Scene");
        }
    }
}
