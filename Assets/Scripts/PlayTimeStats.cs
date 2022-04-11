using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayTimeStats : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI levelsPlayed;
    // Start is called before the first frame update
    void Start()
    {

        timeText.text = LevelProgress.timePlayed.ToString() + " Seconds!";
        if (LevelProgress.timePlayed == 0)
        {
            timeText.text = "0 " + "Seconds";
        }
        levelsPlayed.text = LevelProgress.levelCount.ToString() + "Levels";
        if (LevelProgress.levelCount == 0)
        {
            levelsPlayed.text = "0 " + "Levels";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
