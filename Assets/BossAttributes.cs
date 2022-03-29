using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossAttributes : MonoBehaviour
{
    public float totalHealth;
    [HideInInspector]
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        health = totalHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
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
