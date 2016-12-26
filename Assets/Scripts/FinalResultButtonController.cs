using UnityEngine;
using System.Collections;

public class FinalResultButtonController : MonoBehaviour {

    public QuizController quizController;
    public GameObject finalResultsPanel;
    public void RestartQuiz()
    {
        finalResultsPanel.SetActive(false);
        quizController.RestartQuiz();
    }

    public void BactToQuizMenue()
    {
        finalResultsPanel.SetActive(false);
    }
}
