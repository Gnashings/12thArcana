using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Slider healthBar;
    public GameObject hero;
    public GameObject boss;
    public Text bossState;
    public Text heroState;
    public Text heroJumpChance;
    HeroStats heroStats;

    void Start()
    {
        heroStats = hero.GetComponent<HeroStats>();
        healthBar.maxValue = heroStats.totalHealth;
        healthBar.minValue = 0;
        heroJumpChance.text = heroStats.jumpChance.ToString().Substring(2) + "0%";
    }

    void Update()
    {
        healthBar.value = heroStats.health;
        bossState.text = boss.GetComponent<BossStateManager>().currentState.ToString();
        heroState.text = hero.GetComponent<HeroStateManager>().currentState.ToString();
        
    }
}
