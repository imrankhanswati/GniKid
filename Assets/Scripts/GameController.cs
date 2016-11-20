using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    [SerializeField]
    private AudioClip[] LetterAudioList;
    [SerializeField]
    private AudioClip[] DetailAudioList;
    [SerializeField]
    private AudioClip[] DigitsAudio;
    private static AudioSource audioSource;
    private static bool isDetailEnabled=true;
    public static bool isCapital;
    public static bool isDigits;
    public static int currentDigit = 0;
    public Animation alphaAnimation;
    public Animation itemImageAnimation;
    public Animation itemTextAnimation;

    public Animation nextButtonAnimation;
    public Animation perviousButtonAnimation;

    //back button controlles
    public GameObject digitsCanvas;
    public GameObject smallLetterCanvas;
    public GameObject capitalLetterCanvas;
    public GameObject mainManuCanvas;
	// Use this for initialization
	void Start () {
        audioSource = this.GetComponent<AudioSource>();
	}

	void Update () {

	}

    public static void SetIsDetailEnable(bool value)
    {
        isDetailEnabled = value;
    }

    public static bool GetIsDetailEnable()
    {
        return isDetailEnabled;
    }

    public void RestartAnimaters()
    {
        //Animator.Play(state, layer, normalizedTime);
        //alphaAnimator.Play("PlayAlphaAnim", -1, 0f);
        //alphaAnimator.SetTrigger("PlayAlphaAnim");
        //itemImageAnimator.SetTrigger("PlayItmeAnim");
        //itemTextAnimator.SetTrigger("PlayItemNameAnim");
        //Debug.Log(alphaAnimation.isPlaying);
        if (!alphaAnimation.isPlaying)
        {
            alphaAnimation.Play();
        }
        if (!itemTextAnimation.isPlaying)
        {
            itemTextAnimation.Play();
        }
        if (!itemImageAnimation.isPlaying)
        {
            itemImageAnimation.Play();
        }
        //StartCoroutine(this.EnableButtons());

    }

    IEnumerator EnableButtons()
    {
        yield return new WaitForSeconds(2f);
        nextButtonAnimation.gameObject.SetActive(true);
        perviousButtonAnimation.gameObject.SetActive(true);
        nextButtonAnimation.Play();
        perviousButtonAnimation.Play();

    }

    public void DisableAudios()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        else
        {
            return;
        }
    }

    public void PlayerAudio(char letter)
    {
        if (letter == 'A' || letter == 'a')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[0];
                audioSource.Play();
                this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[0];
                audioSource.Play();
            }
        }
        else if (letter == 'B' || letter == 'b')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[1];
                audioSource.Play();
                this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[1];
                audioSource.Play();
            }
        }
        else if (letter == 'C' || letter == 'c')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[2];
                audioSource.Play();
                this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[2];
                audioSource.Play();
            }
        }
        else if (letter == 'D' || letter == 'd')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[3];
                audioSource.Play();
                this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[3];
                audioSource.Play();
            }
        }
        else if (letter == 'E' || letter == 'e')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[4];
                audioSource.Play();
                this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[4];
                audioSource.Play();
            }
        }

        else if (letter == 'F' || letter == 'f')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[5];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[5];
                audioSource.Play();
            }

        }
        else if (letter == 'G' || letter == 'g')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[6];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[6];
                audioSource.Play();
            }

        }
        else if (letter == 'H' || letter == 'h')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[7];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[7];
                audioSource.Play();
            }

        }
        else if (letter == 'I' || letter == 'i')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[8];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[8];
                audioSource.Play();
            }

        }
        else if (letter == 'J' || letter == 'j')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[9];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[9];
                audioSource.Play();
            }

        }
        else if (letter == 'K' || letter == 'k')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[10];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[10];
                audioSource.Play();
            }

        }
        else if (letter == 'L' || letter == 'l')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[11];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[11];
                audioSource.Play();
            }

        }
        else if (letter == 'M' || letter == 'm')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[12];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[12];
                audioSource.Play();
            }

        }
        else if (letter == 'N' || letter == 'n')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[13];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[13];
                audioSource.Play();
            }
        }

        else if (letter == 'O' || letter == 'o')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[14];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[14];
                audioSource.Play();
            }

        }
        else if (letter == 'P' || letter == 'p')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[15];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[15];
                audioSource.Play();
            }

        }
        else if (letter == 'Q' || letter == 'q')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[16];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[16];
                audioSource.Play();
            }

        }
        else if (letter == 'R' || letter == 'r')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[17];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[17];
                audioSource.Play();
            }

        }
        else if (letter == 'S' || letter == 's')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[18];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[18];
                audioSource.Play();
            }
        }

        else if (letter == 'T' || letter == 't')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[19];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[19];
                audioSource.Play();
            }

        }
        else if (letter == 'U' || letter == 'u')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[20];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[20];
                audioSource.Play();
            }

        }
        else if (letter == 'V' || letter == 'v')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[21];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[21];
                audioSource.Play();
            }
        }
        else if (letter == 'W' || letter == 'w')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[22];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[22];
                audioSource.Play();
            }
        }
        else if (letter == 'X' || letter == 'x')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[23];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[23];
                audioSource.Play();
            }
        }
        else if (letter == 'Y' || letter == 'y')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[24];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[24];
                audioSource.Play();
            }
        }
        else if (letter == 'Z' || letter == 'z')
        {
            if (isDetailEnabled)
            {
                audioSource.clip = DetailAudioList[25];
                audioSource.Play(); this.RestartAnimaters();
            }
            else
            {
                audioSource.clip = LetterAudioList[25];
                audioSource.Play();
            }
        }

    }

    public void PlayAudio(int digit)
    {
        audioSource.clip = DigitsAudio[digit];
        audioSource.Play();
    }

    public void BackToMainMenu()
    {
        capitalLetterCanvas.SetActive(false);
        smallLetterCanvas.SetActive(false);
        digitsCanvas.SetActive(false);
        mainManuCanvas.SetActive(true);
    }
}
