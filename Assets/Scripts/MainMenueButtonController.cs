using UnityEngine;
using System.Collections;

public class MainMenueButtonController : MonoBehaviour {

    public GameObject capitalLetterCanvas;
    public GameObject smallelLetterCanvas;
    public GameObject digitsCanvas;
    public GameObject quizCanvas;
    public GameObject thisCanvas;
	// Use this for initialization

    public void ABCButton()
    {
        capitalLetterCanvas.SetActive(true);
        GameController.isCapital = true;
        GameController.isDigits = false;
        thisCanvas.SetActive(false);
    }

    public void abcButton()
    {
        smallelLetterCanvas.SetActive(true);
        GameController.isCapital = false;
        GameController.isDigits = false;
        thisCanvas.SetActive(false);
    }

    public void DigitsButton()
    {
        digitsCanvas.SetActive(true);
        thisCanvas.SetActive(false);
        GameController.isCapital = false;
        GameController.isDigits = true;
    }

    public void QuizButton()
    {
        //quizCanvas.SetActive(true);
        //thisCanvas.SetActive(false);
    }
}
