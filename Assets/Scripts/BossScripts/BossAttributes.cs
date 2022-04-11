using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossAttributes : MonoBehaviour
{
    public float totalHealth;
    [HideInInspector]
    public float health;
    public AudioSource painSound;

    void Start()
    {
        health = totalHealth;
        //painSound.Play();
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        painSound.Play();
        if (health <= 0)
        {
            LevelProgress.levelCount++;
            SceneManager.LoadScene("Lose Scene");

        }
    }
}
