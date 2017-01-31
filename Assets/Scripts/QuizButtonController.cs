using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class QuizButtonController : MonoBehaviour 
{
    public GameObject quizCanvas;
    public GameObject quizMenuCanvas;
    public EnglishQuestionGentator englishQestionGenrator;

    public void PlayEnglishCapitalQuiz()
    {
        //Debug.Log("english capital.");
        quizCanvas.SetActive(true);
        quizMenuCanvas.SetActive(false);
        englishQestionGenrator.isEnglishCapitalQuestion = true;
        englishQestionGenrator.isEnglishSmallQuestion = false;
        englishQestionGenrator.isEnglishMixQuestion = false;
        englishQestionGenrator.GenrateQuestion();
        //Debug.Log("2");
    }

    public void PlayEnglishSmallQuiz()
    {
        Debug.Log("english small.");
        quizCanvas.SetActive(true);
        quizMenuCanvas.SetActive(false);
        englishQestionGenrator.isEnglishCapitalQuestion = false;
        englishQestionGenrator.isEnglishSmallQuestion = true;
        englishQestionGenrator.isEnglishMixQuestion = false;
        englishQestionGenrator.GenrateQuestion();
        //Debug.Log("3");
    }

    public void PlayEnglishMixQuiz()
    {
        Debug.Log("english capital and small.");
        quizCanvas.SetActive(true);
        quizMenuCanvas.SetActive(false);
        englishQestionGenrator.isEnglishCapitalQuestion = false;
        englishQestionGenrator.isEnglishSmallQuestion = false;
        englishQestionGenrator.isEnglishMixQuestion = true;
        englishQestionGenrator.GenrateQuestion();
        //Debug.Log("4");
    }

    public void PlayMathsQuiz()
    {
        Debug.Log("math.");
        quizCanvas.SetActive(true);
        quizMenuCanvas.SetActive(false);
        englishQestionGenrator.isMathsQuestion = true;
        englishQestionGenrator.GenrateQuestion();
        //Debug.Log("5");
    }
    public void PlayEnglishMathQuiz()
    {
        //Debug.Log("english math.");
        quizCanvas.SetActive(true);
        quizMenuCanvas.SetActive(false);
        englishQestionGenrator.isEnglishAndMathMixQuestion = true;
        englishQestionGenrator.isEnglishMixQuestion = false;
        englishQestionGenrator.isMathsQuestion = false;
        englishQestionGenrator.GenrateQuestion();
        //Debug.Log("6");
    }

    public void BackToQuizMenue()
    {
        englishQestionGenrator.ExitQuiz();
        quizCanvas.SetActive(false);
        quizMenuCanvas.SetActive(true);
    }

    public void ExitQuizScene()
    {
        SceneManager.LoadScene(1);
    }
}
