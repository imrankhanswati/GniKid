using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
public class EnglishQuestionGentator : MonoBehaviour
{
    public Text answar1Text;
    public Text answar2Text;
    public Text answar3Text;
    public Text answar4Text;
    public Text questionText;

    public Button AnsButton1;
    public Button AnsButton2;
    public Button AnsButton3;
    public Button AnsButton4;

    public TimeController timeController;

    List<EnglishQuestion> previousSelectedQuestion;
    public int questionCount;
    public EnglishQuestion englishQuestion;
    public float nextQuestionGenrationTime;

    void Start()
    {
        previousSelectedQuestion = new List<EnglishQuestion>();
        englishQuestion = new EnglishQuestion();
        this.GenrateEnglishQuestion();
    }

    public void GenrateEnglishQuestion()
    {
        //Question Genration
        englishQuestion.isCapital = Random.Range(0, 2);
        int selectedWord;
        if (englishQuestion.isCapital == 1)
        {
            selectedWord = Random.Range(66, 89);
            englishQuestion.wordInBlank = (char)selectedWord;
            englishQuestion.nextWord = (char)(++selectedWord);
            englishQuestion.previousWord = (char)(selectedWord -= 2);
        }
        else
        {
            selectedWord = Random.Range(98, 122);
            englishQuestion.wordInBlank = (char)selectedWord;
            englishQuestion.nextWord = (char)(++selectedWord);
            englishQuestion.previousWord = (char)(selectedWord -= 2);
        }

        this.AnswarsGenration();
        this.StringFormation();
        timeController.RestartTimer();
        AnsButton1.image.color = Color.white;
        AnsButton2.image.color = Color.white;
        AnsButton3.image.color = Color.white;
        AnsButton4.image.color = Color.white;
        //Debug.Log(wordInBlack + "   next   " + nextWord + "   previous   " + firstWord);
    }

    public void AnswarsGenration()
    {
        int[] selectedAnswars = new int[4];
        selectedAnswars[0] = englishQuestion.wordInBlank;
        if (englishQuestion.isCapital == 1)
        {
            for (int i = 1; i < selectedAnswars.Length; i++)
            {
                selectedAnswars[i] = this.GenrateOneAnswar(65, 90, selectedAnswars);
            }
        }
        else
        {
            for (int i = 0; i < selectedAnswars.Length; i++)
            {
                selectedAnswars[i] = this.GenrateOneAnswar(97, 123, selectedAnswars);
            }
        }
        englishQuestion.ans1 = (char)selectedAnswars[1];
        englishQuestion.ans2 = (char)selectedAnswars[2];
        englishQuestion.ans3 = (char)selectedAnswars[3];

    }

    int GenrateOneAnswar(int min,int max,int[] avoidedAnswars)
    {
        bool istoContinueLoop=true;
        int selected=0;

        while (istoContinueLoop)
        {
            istoContinueLoop = false;
            selected = Random.Range(min, max);
            for (int i = 0; i < avoidedAnswars.Length; i++)
            {
                if (selected == avoidedAnswars[i])
                {
                    istoContinueLoop = true;
                    break;
                }
            }
        }
        return selected;
    }

    public void StringFormation()
    {
        questionText.text = englishQuestion.previousWord + " ___ " + englishQuestion.nextWord;
        answar1Text.text = englishQuestion.ans1.ToString();
        answar2Text.text = englishQuestion.wordInBlank.ToString();
        answar3Text.text = englishQuestion.ans2.ToString();
        answar4Text.text = englishQuestion.ans3.ToString();

    }

    //Button Input Controlles
    public void NextQuestion()
    {
        this.GenrateEnglishQuestion();
    }

    public void CheckAnswarButton1()
    {
        if (answar1Text.text == englishQuestion.wordInBlank.ToString())
        {
            AnsButton1.image.color = Color.green;
            Invoke("GenrateEnglishQuestion", nextQuestionGenrationTime);
        }
        else
        {
            AnsButton1.image.color = Color.red;
        }
        Debug.Log("button 1");
    }
    public void CheckAnswarButton2()
    {
        if (answar2Text.text == englishQuestion.wordInBlank.ToString())
        {
            AnsButton2.image.color = Color.green;
            Invoke("GenrateEnglishQuestion", nextQuestionGenrationTime);
        }
        else
        {
            AnsButton2.image.color = Color.red;
        } Debug.Log("button 2");
    }
    public void CheckAnswarButton3()
    {
        if (answar3Text.text == englishQuestion.wordInBlank.ToString())
        {
            AnsButton3.image.color = Color.green;
            Invoke("GenrateEnglishQuestion", nextQuestionGenrationTime);
        }
        else
        {
            AnsButton3.image.color = Color.red;
        }
        Debug.Log("button 3");
    }
    public void CheckAnswarButton4()
    {
        if (answar4Text.text == englishQuestion.wordInBlank.ToString())
        {
            AnsButton4.image.color = Color.green;
            Invoke("GenrateEnglishQuestion", nextQuestionGenrationTime);
        }
        else
        {
            AnsButton4.image.color = Color.red;
        }
        Debug.Log("button 4");
    }
}

public class EnglishQuestion
{
    public int isCapital;
    public char wordInBlank;
    public char nextWord;
    public char previousWord;

    public char ans1;
    public char ans2;
    public char ans3;
}
