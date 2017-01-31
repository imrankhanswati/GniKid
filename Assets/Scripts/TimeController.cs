using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class TimeController : MonoBehaviour 
{
    public int totalTime;
    public int spendedTime;
    public EnglishQuestionGentator englishQuestionGenrator;
    private bool isTimeUp = false;
    public bool isFinalResultShown = false;

    public static TimeController Instance;


    void Start()
    {
        Instance = this;
        StartCoroutine(TimeDecrement());
    }

    IEnumerator TimeDecrement()
    {
        if (!isFinalResultShown)
        {
            while (isTimeUp == false)
            {
                yield return new WaitForSeconds(1);
                Debug.Log("hell from corklsjdfkljlksjfdklsjdkkfjlksdf");
            }

        }
        if (isTimeUp)
        {
            //englishQuestionGenrator.GenrateEnglishQuestion();
            englishQuestionGenrator.DataUpdater(0);
            if (gameObject.activeSelf)
            {
                this.StartCoroutine(TimeDecrement());
            }
        }
    }

    private void TimeFunction()
    {
        //yield return new WaitForSeconds(1f);
        spendedTime += 1;
        int remtime = totalTime - spendedTime;
        if (remtime <= 5)
        {
            //this.GetComponent<Text>().text = "0:0" + remtime.ToString();
            this.GetComponent<Text>().color = Color.red;
        }
        else
        {
            //this.GetComponent<Text>().text = "0:" + remtime.ToString();
            this.GetComponent<Text>().color = Color.black;
        }

        if (totalTime == spendedTime)
        {
            isTimeUp = true;

        }
        Debug.Log("called from corroutine");
    }


    public void RestartTimer()
    {
        this.GetComponent<Text>().color = Color.black;
        //this.GetComponent<Text>().text = "0:" + totalTime.ToString();
        isTimeUp = false;
        spendedTime = 0;
        try
        {
            if (gameObject.activeSelf)
            {
                this.StopCoroutine(TimeDecrement());
                this.StartCoroutine(TimeDecrement());
            }
            else
            {
                gameObject.SetActive(true);
                this.StopCoroutine(TimeDecrement());
                this.StartCoroutine(TimeDecrement());
            }
            //this.GetComponent<Text>().text = "0:" + totalTime.ToString();
            isTimeUp = false;
            spendedTime = 0;
        }
        catch (Exception)
        {

        }
    }

    public bool IsTimeUp()
    {
        return isTimeUp;
    }

    public void StopTimeDecrement()
    {
        this.StopCoroutine(TimeDecrement());
        //isTimeUp = true;
    }

    
}
