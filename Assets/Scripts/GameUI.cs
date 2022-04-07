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
    public Image panel;
    HeroAttributes heroStats;
    BossAttributes bossAttributes;
    void Start()
    {
        heroStats = hero.GetComponent<HeroAttributes>();
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

        heroState.text = LevelProgress.heroState;
        bossState.text = LevelProgress.bossState;
        
    }

    void FixedUpdate()
    {

        
    }

    float check = 1;
    public IEnumerator FadeInScene()
    {
        if (panel.color.a > 0)
        {
            print("FADE IN " + panel.color.a);
            panel.color = new Color(0, 0, 0, check);
            check -= 0.05f;
        }
        else
            //StopCoroutine(FadeInScene());
        yield return new WaitForSeconds(0.05f);
        //StartCoroutine(FadeInScene());
    }

    public IEnumerator FadeOutScene()
    {
        if (panel.color.a < 1)
        {
            print("FADE OUT " + panel.color.a);
            panel.color = new Color(0, 0, 0, check);
            check += 0.05f;
        }
        yield return new WaitForSeconds(0.05f);
        //StartCoroutine(FadeOutScene());
    }
}
