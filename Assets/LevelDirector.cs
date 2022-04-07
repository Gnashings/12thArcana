using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDirector : MonoBehaviour
{
    public GameObject hero;
    public GameObject boss;
    public Dialogue dialogue;
    
    private HeroAttributes heroAttributes;
    
    // Start is called before the first frame update
    void Start()
    {
        LevelProgress.levelFinished = false;
        heroAttributes = hero.GetComponent<HeroAttributes>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (heroAttributes.health <= 0 && LevelProgress.levelFinished == false)
        {
            LevelProgress.levelFinished = true;
            LevelProgress.isPaused = true;
            LevelProgress.disableControls = true;
            dialogue.ContDialogue();
        }
    }


}
