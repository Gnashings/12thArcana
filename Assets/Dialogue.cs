using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public Button continueBtn;
    private string[] lines;
    public float textSpeed;

    public int index;
    bool doneSpeaking;
    //new shit
    [System.Serializable]
    public class LevelDialogues
    {
        public List<Speech> totalConvos;
    }

    [System.Serializable]
    public class Speech
    {
        public bool isHero;
        public string dialogue;
    }

    public List<LevelDialogues> levelDialogues;

    private int totalSpeeches;
    void Start()
    {
        LevelProgress.isPaused = true;
        LevelProgress.disableControls = true;
        textBox.text = string.Empty;
        
        if (levelDialogues.Count <= LevelProgress.levelCount)
        {
            print("DIALOG SHOULD NOT APPEAR");

            WrapDialog();
        }
        else
            CycleSpeeches();



    }

    void CycleSpeeches()
    {
        continueBtn.gameObject.SetActive(false);
        int i = 0;
        foreach(LevelDialogues level in levelDialogues)
        {
            if(i == LevelProgress.levelCount)
            {
                if (totalSpeeches >= level.totalConvos.Count)
                {
                    doneSpeaking = true;
                    break;
                }    
                //print(level.totalConvos[totalSpeeches].dialogue);

                StartCoroutine(TypeLine(level.totalConvos[totalSpeeches].dialogue));
                /*
                foreach (Speech speech in level.totalConvos)
                {
                    print(speech.dialogue);
                    StartCoroutine(TypeLine(speech.dialogue));
                    break;
                }*/
            }
            i++;
        }
    }


    void Update()
    {

    }

    public void ContDialogue()
    {
        totalSpeeches++;
        textBox.text = string.Empty;
        CycleSpeeches();
        //print("done? " + doneSpeaking);
        CheckDoneSpeaking();
    }
    void WrapDialog()
    {
        continueBtn.gameObject.SetActive(false);
        LevelProgress.isPaused = false;
        LevelProgress.disableControls = false;
    }
    void CheckDoneSpeaking()
    {
        if (doneSpeaking)
        {
            LevelProgress.isPaused = false;
            LevelProgress.disableControls = false;
            //print("done");
        }
    }
    void StartDialog()
    {
        index = 0;
    }

    /*
    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textBox.text = string.Empty;
            StartCoroutine(TypeLine(line));
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    */

    IEnumerator TypeLine(string line)
    {
        foreach (char letter in line.ToCharArray())
        {
            textBox.text += letter;

            yield return new WaitForSeconds(textSpeed);
        }
        yield return new WaitForSeconds(textSpeed);
        continueBtn.gameObject.SetActive(true);

    }
}
