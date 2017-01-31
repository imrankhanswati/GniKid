using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuizController : MonoBehaviour {
    public EnglishQuestionGentator englishQuestionGenrator;
    public TimeUpdate timeContlroller;

    public GameObject finalResultsPanel;
    public Text correctAnswarsTxt;
    public Text wrongAnswarsTxt;
    public Text totalAnswatsTxt;
    public Text percentageTxt;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //CA: correct Answars
    //WA: wrong Answars
    //TA: Total Answars
    public void ShowFinalResults(int CA, int WA, int TA)
    {
        correctAnswarsTxt.text = "Correct Answars: " + CA;
        wrongAnswarsTxt.text = "Wrong Answars: " + WA;
        totalAnswatsTxt.text = "Total Answars: " + TA;
        timeContlroller.StopTimer();
        //float a = ((float)CA / (float)TA);
        percentageTxt.text = "Percentage: " + Mathf.RoundToInt((((float)CA / (float)TA) * 100))+" %";
        finalResultsPanel.SetActive(true);
    }

    public void ExitFinalResults()
    {
        finalResultsPanel.SetActive(false);
    }

    public void RestartQuiz()
    {
        //timeContlroller.gameObject.SetActive(true);
        englishQuestionGenrator.RestartQuiz();
        timeContlroller.RestartTimer();
    }
}
