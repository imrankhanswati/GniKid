using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuizController : MonoBehaviour {
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
        float a = CA / TA;
        Debug.Log(CA + "    " + TA + "       " + a);
        percentageTxt.text = "Percentage: " + Mathf.RoundToInt(((CA / TA) * 100));
        finalResultsPanel.SetActive(true);
    }
}
