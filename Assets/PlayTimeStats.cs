using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTimeStats : MonoBehaviour
{
    public Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        timeText.text = LevelProgress.timePlayed.ToString() + " Seconds!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
