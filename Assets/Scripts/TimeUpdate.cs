using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUpdate : MonoBehaviour
{
    private int totalTime;
    public int maxTime = 10;
    public bool isTimeUp = false;
    public EnglishQuestionGentator englishQuestionGenrator;
    void Start()
    {
        totalTime = maxTime;
        GetComponent<Text>().text = "0:" + totalTime.ToString();
        InvokeRepeating("UpdateTime", 1.0f, 1.0f);

    }

    void UpdateTime()
    {
        if (!isTimeUp)
        {
            totalTime--;
            if (totalTime < 4)
            {
                GetComponent<Text>().color = Color.red;
            }
            if (totalTime < 10)
            {
                GetComponent<Text>().text = "0:0" + totalTime.ToString();
            }
            else
            {
                GetComponent<Text>().text = "0:" + totalTime.ToString();
            }
            if (totalTime == 0)
            {
                TimeUp();
            }
        }
    }

    public void RestartTimer()
    {
        totalTime = maxTime;
        isTimeUp = false;
        GetComponent<Text>().color = Color.black;
        GetComponent<Text>().text = "0:" + totalTime;
        //englishQuestionGenrator.GenrateQuestion();
    }

    public void StopTimer()
    {
        isTimeUp = true;
    }

    public void TimeUp()
    {
        isTimeUp = true;
        totalTime = maxTime;
        GetComponent<Text>().color = Color.black;
        GetComponent<Text>().text = "0:00";
        englishQuestionGenrator.DataUpdater(0);
        englishQuestionGenrator.GenrateQuestion();
        //Debug.Log("7");
    }

    public void ResetTimer()
    {
        GetComponent<Text>().color = Color.black;
        GetComponent<Text>().text = "0:00";
    }
}
