using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public Button continueBtn;
    public GameUI gameUI;
    public float textSpeed;

    bool mainTextFinished;
    bool allTextFinished;
    //new
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
    private int thisLevel;
    [HideInInspector]
    public bool allTextsOver;
    void Start()
    {
        LevelProgress.isPaused = true;
        LevelProgress.disableControls = true;
        textBox.text = string.Empty;
        thisLevel = LevelProgress.levelCount;
        if (levelDialogues.Count <= LevelProgress.levelCount)
        {
            thisLevel = 5;
            CycleSpeeches();
        }
        else
            CycleSpeeches();
    }

    public void CycleSpeeches()
    {
        continueBtn.gameObject.SetActive(false);
        //print(levelDialogues[thisLevel].totalConvos[totalSpeeches].dialogue);
        //print("TOTAL TALKS: " + totalSpeeches);
           
        if (totalSpeeches == levelDialogues[thisLevel].totalConvos.Count-1)
        {
            ReturnPlayerControls();
            mainTextFinished = true;
            gameUI.dialogueBox.SetActive(false);
            return;
        }
        if (levelDialogues[thisLevel].totalConvos[totalSpeeches].isHero == true)
        {
            gameUI.HeroTalking();
        }
        else
            gameUI.BossTalking();
        StartCoroutine(TypeLine(levelDialogues[thisLevel].totalConvos[totalSpeeches].dialogue));
        totalSpeeches++;

    }

    void Update()
    {

    }

    //OnButtonClick
    public void ContDialogue()
    {
        textBox.text = string.Empty;
        gameUI.dialogueBox.SetActive(true);
        if (mainTextFinished == false)
        {
            gameUI.dialogueBox.SetActive(true);
            CycleSpeeches();
        }
        else
        {
            if(allTextFinished)
            {
                continueBtn.gameObject.SetActive(false);
                gameUI.dialogueBox.SetActive(false);
                if(LevelProgress.levelFinished)
                {
                    //StartCoroutine(gameUI.FadeOutScene());
                    SceneManager.LoadScene("Testing Scene");
                }
                return;
            }
                ProcFinalDialogue();
        }
    }

    void ProcFinalDialogue()
    {
        if (levelDialogues[thisLevel].totalConvos[totalSpeeches].isHero == true)
        {
            gameUI.HeroTalking();
        }
        else
            gameUI.BossTalking();
        StartCoroutine(TypeLine(levelDialogues[thisLevel].totalConvos[totalSpeeches].dialogue));

        allTextFinished = true;
    }

    void ReturnPlayerControls()
    {
        LevelProgress.isPaused = false;
        LevelProgress.disableControls = false;
        
    }

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
