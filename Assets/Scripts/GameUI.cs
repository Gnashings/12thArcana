using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Slider healthBar;
    public Slider bossHealthBar;
    public GameObject hero;
    public GameObject boss;
    public Text bossState;
    public Text heroState;
    public Text heroJumpChance;
    HeroStats heroStats;
    BossAttributes bossAttributes;
    void Start()
    {
        heroStats = hero.GetComponent<HeroStats>();
        healthBar.maxValue = heroStats.totalHealth;
        healthBar.minValue = 0;
        float cleanPercent = heroStats.jumpChance * 100;
        if(cleanPercent >= 100f)
        {
            cleanPercent = 100;
        }
        heroJumpChance.text = cleanPercent.ToString() + "%";

        bossAttributes = boss.GetComponent<BossAttributes>();
        bossHealthBar.maxValue = bossAttributes.totalHealth;
        bossHealthBar.minValue = 0;
    }

    void Update()
    {
        healthBar.value = heroStats.health;
        bossHealthBar.value = bossAttributes.health;
        bossState.text = boss.GetComponent<BossStateManager>().currentState.ToString();
        heroState.text = hero.GetComponent<HeroStateManager>().currentState.ToString();


    }
}
