using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public enum ButtonsTypes
{
    BUTTON1,
    BUTTON2,
    BUTTON3,
    BUTTON4
};
public class EnglishQuestionGentator : MonoBehaviour
{
    public bool isEnglishCapitalQuestion;
    public bool isEnglishSmallQuestion;
    public bool isEnglishMixQuestion;
    public bool isMathsQuestion;
    public bool isEnglishAndMathMixQuestion;


    //Data
    public int correctAnswars;
    public int wrongAnswars;
    public int totalAnswars;
    public int progress;
    public int totalQustions;

    //Refrences
    //Text Refrences
    public Text answar1Text;
    public Text answar2Text;
    public Text answar3Text;
    public Text answar4Text;
    public Text questionText;
    public Text totalAnswaresText;
    public Text correctAnswarsText;
    public Text wrongAnswarsText;
    public Text progressText;

    //Buttons Refrences
    public Button AnsButton1;
    public Button AnsButton2;
    public Button AnsButton3;
    public Button AnsButton4;

    //Objects Recfrence
    public QuizController quizController;

    public static int questionTypes;//if its value is 1 then the question genrater genrate english question,if 2 ther genrater genrate maths else genrater genrate mix question;
    public ButtonsTypes buttonsType;
    public TimeUpdate timeController;

    List<EnglishQuestion> previousSelectedQuestion;
    public int questionCount;
    public EnglishQuestion englishQuestion;
    public MathsQuestion mathsQuestion;
    public float nextQuestionGenrationTime;

    private IList<string> genratedAnswars = new List<string>();
    [SerializeField]
    private Text[] btnTextArray;
    void Start()
    {
        previousSelectedQuestion = new List<EnglishQuestion>();
        englishQuestion = new EnglishQuestion();
        mathsQuestion = new MathsQuestion();
        this.ResetData();
        //this.GenrateEnglishQuestion();
        //btnTextArray = new Text[4];
        //genratedAnswars = new List<char>();

    }

    void Update(){
        //this.GenrateMathsQuestion();
    }

    public void GenrateEnglishQuestion()
    {
        //Debug.Log("genrate english question...");
        //Question Genration
        this.EnableButtons();
        if (isEnglishCapitalQuestion)
        {
            englishQuestion.isCapital = 1;
        }
        else if (isEnglishSmallQuestion)
        {
            englishQuestion.isCapital = 0;
        }
        else if (isEnglishMixQuestion)
        {
            englishQuestion.isCapital = Random.Range(0, 2);
        }
        //englishQuestion.isCapital = Random.Range(0, 2);
        int selectedWord;
        if (englishQuestion.isCapital == 1)
        {
            //Debug.Log("called capital");
            selectedWord = Random.Range(66, 89);
            englishQuestion.wordInBlank = (char)selectedWord;
            englishQuestion.nextWord = (char)(++selectedWord);
            englishQuestion.previousWord = (char)(selectedWord -= 2);
        }
        else
        {
            //Debug.Log("called small");
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
        //Debug.Log("English q genrated....");
        //Debug.Log(wordInBlack + "   next   " + nextWord + "   previous   " + firstWord);
    }

    public void GenrateMathsQuestion()
    {
        int selectedWord;
        this.EnableButtons();
        selectedWord = Random.Range(1, 21);
        //Debug.Log(selectedWord + "     " + (selectedWord+=1) + "     " + (selectedWord -= 2));
        mathsQuestion.digitInBlank = selectedWord;
        mathsQuestion.nextDigit = (selectedWord += 1);
        mathsQuestion.previousDigit = (selectedWord-=2);

        this.AnswarsGenration();
        this.StringFormation();
        timeController.RestartTimer();
        AnsButton1.image.color = Color.white;
        AnsButton2.image.color = Color.white;
        AnsButton3.image.color = Color.white;
        AnsButton4.image.color = Color.white;
        //Debug.Log("math q genrated....");
    }

    public void GenrateQuestion()
    {
        //Debug.Log("genrating new qestion...");
        if (isEnglishAndMathMixQuestion)
        {
            //Debug.Log("english and math mix...");
            int isEnglish = Random.Range(0, 2);
            //Debug.Log(isEnglish);
            if (isEnglish == 1)
            {
                isEnglishMixQuestion = true;
                isMathsQuestion = false;
                GenrateEnglishQuestion();
                //Debug.Log("English");
            }
            else
            {
                isMathsQuestion = true;
                isEnglishMixQuestion = false;
                GenrateMathsQuestion();
                //Debug.Log("math");
            }
            return;
        }
        else if(isMathsQuestion)
        {
            Debug.Log("math question...");
            GenrateMathsQuestion();
            return;
        }
        else
        {
            //Debug.Log("english question...");
            GenrateEnglishQuestion();
            return;
        }
    } 
    public void AnswarsGenration()
    {
        int[] selectedAnswars = new int[4];
        if (isMathsQuestion)
        {
            selectedAnswars[0] = mathsQuestion.digitInBlank;
            for (int i = 1; i < selectedAnswars.Length; i++)
            {
                selectedAnswars[i] = this.GenrateOneAnswar(0, 21, selectedAnswars);
            }

            mathsQuestion.ans1 = selectedAnswars[1].ToString();
            mathsQuestion.ans2 = selectedAnswars[2].ToString();
            mathsQuestion.ans3 = selectedAnswars[3].ToString();
        }
        else
        {
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
        if (isMathsQuestion)
        {
            questionText.text = mathsQuestion.previousDigit + " ___ " + mathsQuestion.nextDigit;
            if (genratedAnswars != null)
            {
                genratedAnswars.Add(mathsQuestion.ans1);
                genratedAnswars.Add(mathsQuestion.ans2);
                genratedAnswars.Add(mathsQuestion.ans3);
                genratedAnswars.Add(mathsQuestion.digitInBlank.ToString());
                this.AnswarAssigner(genratedAnswars, btnTextArray);
            }
        }
        else
        {
            questionText.text = englishQuestion.previousWord + " ___ " + englishQuestion.nextWord;

            if (genratedAnswars != null)
            {
                genratedAnswars.Add(englishQuestion.ans1.ToString());
                genratedAnswars.Add(englishQuestion.ans2.ToString());
                genratedAnswars.Add(englishQuestion.ans3.ToString());
                genratedAnswars.Add(englishQuestion.wordInBlank.ToString());
                this.AnswarAssigner(genratedAnswars, btnTextArray);
            }
        }
        //answar1Text.text = englishQuestion.ans1.ToString();
        //answar2Text.text = englishQuestion.wordInBlank.ToString();
        //answar3Text.text = englishQuestion.ans2.ToString();
        //answar4Text.text = englishQuestion.ans3.ToString();
    }

    //Button Input Controlles
    //public void NextQuestion()
    //{
    //    this.GenrateEnglishQuestion();
    //}

    public void AnswarAssigner(IList<string> answars,Text[] AnsBtnText)
    {
        int selectedAnswar = 0;
        for (int i = 0; i < 4; i++)
        {
            if (answars.Count != 0)
            {

            }
            selectedAnswar = Random.Range(0, answars.Count);
            AnsBtnText[i].text = answars[selectedAnswar].ToString();
            //Debug.Log(answars[selectedAnswar]);
            answars.RemoveAt(selectedAnswar);
        }
    }

    public void CheckAnswarButton1()
    {
        timeController.StopTimer();
        if (isMathsQuestion)
        {
            if (answar1Text.text == mathsQuestion.digitInBlank.ToString())
            {
                AnsButton1.image.color = Color.green;
                
                this.DataUpdater(1);
            }
            else
            {
                AnsButton1.image.color = Color.red;
                //Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(0);
            }
            this.DisableButtons();
        }
        else
        {
            if (answar1Text.text == englishQuestion.wordInBlank.ToString())
            {
                AnsButton1.image.color = Color.green;
                //Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(1);
            }
            else
            {
                AnsButton1.image.color = Color.red;
                //Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(0);
            }
            this.DisableButtons();
        }
        Invoke("GenrateQuestion", nextQuestionGenrationTime);
    }
    public void CheckAnswarButton2()
    {
        timeController.StopTimer();
        if (isMathsQuestion)
        {
            if (answar2Text.text == mathsQuestion.digitInBlank.ToString())
            {
                AnsButton2.image.color = Color.green;
               // Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(1);
            }
            else
            {
                AnsButton2.image.color = Color.red;
               // Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(0);
            }
            this.DisableButtons();
        }
        else
        {
            if (answar2Text.text == englishQuestion.wordInBlank.ToString())
            {
                AnsButton2.image.color = Color.green;
               // Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(1);
            }
            else
            {
                AnsButton2.image.color = Color.red;
               // Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(0);
            }
            this.DisableButtons();
        }
        Invoke("GenrateQuestion", nextQuestionGenrationTime);
    }
    public void CheckAnswarButton3()
    {
        timeController.StopTimer();
        if (isMathsQuestion)
        {
            if (answar3Text.text == mathsQuestion.digitInBlank.ToString())
            {
                AnsButton3.image.color = Color.green;
                //Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(1);
            }
            else
            {
                AnsButton3.image.color = Color.red;
                //Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(0);
            }
            this.DisableButtons();
        }
        else
        {
            if (answar3Text.text == englishQuestion.wordInBlank.ToString())
            {
                AnsButton3.image.color = Color.green;
                //Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(1);
            }
            else
            {
                AnsButton3.image.color = Color.red;
               // Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(0);
            }

            this.DisableButtons();
        }
        Invoke("GenrateQuestion", nextQuestionGenrationTime);
    }
    public void CheckAnswarButton4()
    {
        timeController.StopTimer();
        if (isMathsQuestion)
        {
            if (answar4Text.text == mathsQuestion.digitInBlank.ToString())
            {
                AnsButton4.image.color = Color.green;
               // Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(1);
            }
            else
            {
                AnsButton4.image.color = Color.red;
               // Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(0);
            }
            this.DisableButtons();
        }
        else
        {
            if (answar4Text.text == englishQuestion.wordInBlank.ToString())
            {
                AnsButton4.image.color = Color.green;
               // Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(1);
            }
            else
            {
                AnsButton4.image.color = Color.red;
               // Invoke("GenrateQuestion", nextQuestionGenrationTime);
                this.DataUpdater(0);
            }

            this.DisableButtons();
        }
        Invoke("GenrateQuestion", nextQuestionGenrationTime);
    }

    public void DisableButtons()
    {
        AnsButton1.interactable = false;
        AnsButton2.interactable = false;
        AnsButton3.interactable = false;
        AnsButton4.interactable = false;
        //if (buttonsType == ButtonsTypes.BUTTON1)
        //{
        //    AnsButton2.interactable = false;
        //}
        //else if (buttonsType == ButtonsTypes.BUTTON2)
        //{

        //}
        //else if (buttonsType == ButtonsTypes.BUTTON3)
        //{

        //}
        //else
        //{

        //}
    }

    public void EnableButtons()
    {
        AnsButton1.interactable = true;
        AnsButton2.interactable = true;
        AnsButton3.interactable = true;
        AnsButton4.interactable = true;
    }

    public void DataUpdater(int result)
    {
        switch (result)
        {
            case 1:
                correctAnswars++;
                totalAnswars++;
                correctAnswarsText.text = "Correct Answars: " + correctAnswars.ToString();
                totalAnswaresText.text = "Total Answars: " + totalAnswars.ToString();
                break;
            case 0:
                wrongAnswars++;
                totalAnswars++;
                wrongAnswarsText.text ="Wrong Answars: "+ wrongAnswars.ToString();
                totalAnswaresText.text = "Total Answars: " + totalAnswars.ToString();
                break;
        }

        progress++;
        progressText.text = "Progress: " + progress + "/" + totalQustions;
        if (progress == totalQustions)
        {
            quizController.ShowFinalResults(correctAnswars, wrongAnswars, totalAnswars);
            timeController.StopTimer();
            //timeController.ResetTimer();
        }
    }

    public void ResetData()
    {
        totalAnswars = 0;
        correctAnswars = 0;
        wrongAnswars = 0;
        progress = 0;

        totalAnswaresText.text = "Total Answars: " + totalAnswars;
        correctAnswarsText.text = "Correct Answars: " + correctAnswars;
        wrongAnswarsText.text = "Wrong Answars: " + wrongAnswars;
        progressText.text = "Progress: " + progress + "/" + totalQustions;
    }

    public void RestartQuiz()
    {
        totalAnswars = 0;
        correctAnswars = 0;
        wrongAnswars = 0;
        progress = 0;
        timeController.RestartTimer();

        totalAnswaresText.text = "Total Answars: " + totalAnswars;
        correctAnswarsText.text = "Correct Answars: " + correctAnswars;
        wrongAnswarsText.text = "Wrong Answars: " + wrongAnswars;
        progressText.text = "Progress: " + progress + "/" + totalQustions;
        GenrateQuestion();
    }

    public void ExitQuiz()
    {
        quizController.ExitFinalResults();
        totalAnswars = 0;
        correctAnswars = 0;
        wrongAnswars = 0;
        progress = 0;
        timeController.StopTimer();

        totalAnswaresText.text = "Total Answars: " + totalAnswars;
        correctAnswarsText.text = "Correct Answars: " + correctAnswars;
        wrongAnswarsText.text = "Wrong Answars: " + wrongAnswars;
        progressText.text = "Progress: " + progress + "/" + totalQustions;
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

public class MathsQuestion
{
    public int digitInBlank;
    public int nextDigit;
    public int previousDigit;

    public string ans1;
    public string ans2;
    public string ans3;
}
