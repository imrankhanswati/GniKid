using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeController : MonoBehaviour 
{
    public int totalTime;
    public int spendedTime;
    public EnglishQuestionGentator englishQuestionGenrator; 
    private bool isTimeUp=false;
    public bool isFinalResultShown = false;


    void Start()
    {
        StartCoroutine(TimeDecrement());
    }

    IEnumerator TimeDecrement()
    {
        if (!isFinalResultShown)
        {
            while (isTimeUp == false)
            {
                yield return new WaitForSeconds(1f);
                spendedTime += 1;
                int remtime = totalTime - spendedTime;
                if (remtime <= 5)
                {
                    this.GetComponent<Text>().text = "0:0" + remtime.ToString();
                    this.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    this.GetComponent<Text>().text = "0:" + remtime.ToString();
                }

                if (totalTime == spendedTime)
                {
                    isTimeUp = true;

                }

            }
            if (isTimeUp)
            {
                englishQuestionGenrator.GenrateEnglishQuestion();
                englishQuestionGenrator.DataUpdater(0);
                this.StartCoroutine(TimeDecrement());
            }
        }
    }

    public void RestartTimer()
    {
        this.GetComponent<Text>().text = "0:" + totalTime.ToString();
        isTimeUp = false;
        spendedTime = 0;
    }

    public bool IsTimeUp()
    {
        return isTimeUp;
    }

    public void StopTimeDecrement()
    {
        this.StopCoroutine(TimeDecrement());
    }
}
