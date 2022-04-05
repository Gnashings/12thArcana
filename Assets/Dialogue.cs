using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    private string[] lines;
    public float textSpeed;

    private int index;

    //new shit
    [System.Serializable]
    public class Speech
    {
        public bool isHero;
        public int level;
        public string dialogue;
    }

    public List<Speech> speeches;
    public Dictionary<bool, string> talk;

    void Start()
    {
        textBox.text = string.Empty;
        StartDialog();

        //new shit

        foreach(Speech speech in speeches)
        {
        }

    }


    void Update()
    {
    }

    void StartDialog()
    {
        index = 0;
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textBox.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    IEnumerator TypeLine()
    {
        foreach (char letter in lines[index].ToCharArray())
        {
            textBox.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }

    }
}
