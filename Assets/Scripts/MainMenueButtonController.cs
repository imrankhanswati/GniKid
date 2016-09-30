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
        thisCanvas.SetActive(false);
    }

    public void abcButton()
    {
        smallelLetterCanvas.SetActive(true);
        GameController.isCapital = false;
        thisCanvas.SetActive(false);
    }

    public void DigitsButton()
    {
        //digitsCanvas.SetActive(true);
        //thisCanvas.SetActive(false);
    }

    public void QuizButton()
    {
        //quizCanvas.SetActive(true);
        //thisCanvas.SetActive(false);
    }
}
