using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeController : MonoBehaviour 
{
    public int totalTime;
    public int spendedTime;
    public EnglishQuestion englishQuestion; 
    private bool isTimeUp=false;


    void Start()
    {
        StartCoroutine(TimeDecrement());
    }

    IEnumerator TimeDecrement()
    {
        
        while (isTimeUp == false)
        {
            yield return new WaitForSeconds(1f);
            spendedTime += 1;
            int remtime = totalTime - spendedTime;
            if (remtime <= 9)
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
                Debug.Log(totalTime + "" + spendedTime + "time up");
            }
        }
        if (isTimeUp)
        {
            englishQuestion.GenrateEnglishQuestion();
        }
    }

    public void RestartTimer()
    {
        isTimeUp = false;
        spendedTime = 0;
        this.GetComponent<Text>().text = "0:"+totalTime.ToString();
    }

    public bool IsTimeUp()
    {
        return isTimeUp;
    }
}
