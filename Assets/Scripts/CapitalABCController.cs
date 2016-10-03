using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CapitalABCController : MonoBehaviour
{
    [SerializeField]
    private LoadAphabiticObjects loadAlphabaticObjects;
    [SerializeField]
    private Canvas detailCanvas;
    [SerializeField]
    private Canvas digitDetailCanvas;
    [SerializeField]
    private Canvas capitalAlphaSelectCanvas;
    [SerializeField]
    private Canvas SmallerAlphaSelectCanvas;
    [SerializeField]
    private Canvas DigitSelectCanvas;

    public Text alphbitTxt;
    public Image itemImg;
    public Text itemTextTxt;

    public Text nextButtText;
    public Text PreviousButtText;
    public Text digitNextButtText;
    public Text digitPreviousButtText;
    public GameController gameController;
    private SceneObjectType sceneObjects;

    public GameObject nextButton;
    public GameObject perivousButton;

    public bool isDetailesEnabled = true;

    [Header("DIGITS CANVAS DATA")]
    public Text digit;
    public Text digitText;
    public GameObject[] digitImageArray=new GameObject[20];



    public void ClickA()
    {
        if (GameController.isDigits)
        {
            Debug.Log("1");
            SetDetailCanvas(1);
        }
        else if(GameController.isCapital==false)
        {
            SetDetailCanvas('a');
        }
        else
        {
            SetDetailCanvas('A');
            
        }

    }

    public void ClickB()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(2);
        }
        else if(GameController.isCapital==false)
        {
            SetDetailCanvas('b');
        }
        else
        {

            SetDetailCanvas('B');
        }
    }

    public void ClickC()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(3);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('c');
        }
        else
        {
            SetDetailCanvas('C');
            
        }
    }

    public void ClickD()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(4);
        }
        else if(GameController.isCapital==false)
        {
            SetDetailCanvas('d');
        }
        else
        {

            SetDetailCanvas('D');
        }
    }

    public void ClickE()
    {
        if (GameController.isDigits)
        {

            SetDetailCanvas(5);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('e');
        }
        else
        {
            SetDetailCanvas('E');
        }
    }

    public void ClickF()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(6);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('f');
        }
        else
        {

            SetDetailCanvas('F');
        }
    }

    public void ClickG()
    {
        if (GameController.isDigits)
        {

            SetDetailCanvas(7);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('g');
        }
        else
        {
            SetDetailCanvas('G');
        }
    }

    public void ClickH()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(8);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('h');
        }
        else
        {
            SetDetailCanvas('H');
        }
    }

    public void ClickI()
    {
        if (GameController.isDigits)
        {

            SetDetailCanvas(9);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('i');
        }
        else
        {
            SetDetailCanvas('I');
        }
    }

    public void ClickJ()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(10);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('j');
        }
        else
        {
            SetDetailCanvas('J');
        }
    }

    public void ClickK()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(11);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('k');
        }
        else
        {
            SetDetailCanvas('K');
        }
    }

    public void ClickL()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(12);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('l');
        }
        else
        {
            SetDetailCanvas('L');
        }
    }

    public void ClickM()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(13);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('m');
        }
        else
        {
            SetDetailCanvas('M');
        }
    }

    public void ClickN()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(14);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('n');
        }
        else
        {
            SetDetailCanvas('N');
        }
    }

    public void ClickO()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(15);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('o');
        }
        else
        {
            SetDetailCanvas('O');
        }
    }

    public void ClickP()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(16);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('p');
        }
        else
        {
            SetDetailCanvas('P');
        }
    }

    public void ClickQ()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(17);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('q');
        }
        else
        {
            SetDetailCanvas('Q');
        }
    }

    public void ClickR()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(18);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('r');
        }
        else
        {
            SetDetailCanvas('R');
        }
    }

    public void ClickS()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(19);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('s');
        }
        else
        {
            SetDetailCanvas('S');
        }
    }

    public void ClickT()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(20);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('t');
        }
        else
        {
            SetDetailCanvas('T');
        }
    }

    public void ClickU()
    {
        if (GameController.isDigits)
        {
            SetDetailCanvas(0);
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('u');
        }
        else
        {
            SetDetailCanvas('U');
        }
    }

    public void ClickV()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('V');
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('v');
        }
    }

    public void ClickW()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('W');
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('w');
        }
    }

    public void ClickX()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('X');
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('x');
        }
    }

    public void ClickY()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('Y');
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('y');
        }
    }

    public void ClickZ()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('Z');
        }
        else if (GameController.isCapital == false)
        {
            SetDetailCanvas('z');
        }
    }

    public void CheckBoxValueChange(bool isChecked)
    {
        GameController.SetIsDetailEnable(isChecked);
    }

    void SetDetailCanvas(char myAlpha)
    {
        if (GameController.GetIsDetailEnable())
        {
            if (GameController.isCapital)
            {
                //nextButton.SetActive(false);
                //perivousButton.SetActive(false);

                if (myAlpha == 'A')
                {
                    sceneObjects = loadAlphabaticObjects.LoadCurrentCanvasObject(myAlpha.ToString());
                    nextButtText.text = ((char)((int)myAlpha + 1)).ToString();
                    PreviousButtText.text = "Z";
                    alphbitTxt.text = sceneObjects.alphabetText;
                    itemImg.sprite = sceneObjects.itemImge;
                    itemTextTxt.text = sceneObjects.itemText;
                    detailCanvas.gameObject.SetActive(true);
                    capitalAlphaSelectCanvas.gameObject.SetActive(false);
                }
                else if (myAlpha == 'Z')
                {
                    sceneObjects = loadAlphabaticObjects.LoadCurrentCanvasObject(myAlpha.ToString());
                    nextButtText.text = "A";
                    PreviousButtText.text = ((char)((int)myAlpha - 1)).ToString();
                    alphbitTxt.text = sceneObjects.alphabetText;
                    itemImg.sprite = sceneObjects.itemImge;
                    itemTextTxt.text = sceneObjects.itemText;
                    detailCanvas.gameObject.SetActive(true);
                    capitalAlphaSelectCanvas.gameObject.SetActive(false);
                }
                else
                {
                    sceneObjects = loadAlphabaticObjects.LoadCurrentCanvasObject(myAlpha.ToString());
                    nextButtText.text = ((char)((int)myAlpha + 1)).ToString();
                    PreviousButtText.text = ((char)((int)myAlpha - 1)).ToString();
                    alphbitTxt.text = sceneObjects.alphabetText;
                    itemImg.sprite = sceneObjects.itemImge;
                    itemTextTxt.text = sceneObjects.itemText;
                    detailCanvas.gameObject.SetActive(true);
                    capitalAlphaSelectCanvas.gameObject.SetActive(false);
                }
                gameController.PlayerAudio(myAlpha);
            }
            else
            {
                //nextButton.SetActive(false);
                //perivousButton.SetActive(false);

                if (myAlpha == 'a')
                {
                    sceneObjects = loadAlphabaticObjects.LoadCurrentCanvasObject(myAlpha.ToString());
                    nextButtText.text = ((char)((int)myAlpha + 1)).ToString();
                    PreviousButtText.text = "z";
                    alphbitTxt.text = sceneObjects.SmallAlphabetText;
                    itemImg.sprite = sceneObjects.itemImge;
                    itemTextTxt.text = sceneObjects.SmallItemText;
                    detailCanvas.gameObject.SetActive(true);
                    SmallerAlphaSelectCanvas.gameObject.SetActive(false);
                }
                else if (myAlpha == 'z')
                {
                    sceneObjects = loadAlphabaticObjects.LoadCurrentCanvasObject(myAlpha.ToString());
                    nextButtText.text = "a";
                    PreviousButtText.text = ((char)((int)myAlpha - 1)).ToString();
                    alphbitTxt.text = sceneObjects.SmallAlphabetText;
                    itemImg.sprite = sceneObjects.itemImge;
                    itemTextTxt.text = sceneObjects.SmallItemText;
                    detailCanvas.gameObject.SetActive(true);
                    SmallerAlphaSelectCanvas.gameObject.SetActive(false);
                }
                else
                {
                    sceneObjects = loadAlphabaticObjects.LoadCurrentCanvasObject(myAlpha.ToString());
                    nextButtText.text = ((char)((int)myAlpha + 1)).ToString();
                    PreviousButtText.text = ((char)((int)myAlpha - 1)).ToString();
                    alphbitTxt.text = sceneObjects.SmallAlphabetText;
                    itemImg.sprite = sceneObjects.itemImge;
                    itemTextTxt.text = sceneObjects.SmallItemText;
                    detailCanvas.gameObject.SetActive(true);
                    SmallerAlphaSelectCanvas.gameObject.SetActive(false);
                }
                gameController.PlayerAudio(myAlpha);
            }

        }
        else
        {
            gameController.PlayerAudio(myAlpha);
        }
        //Debug.Log(GameController.GetIsDetailEnable());
    }

    public void SetDetailCanvas(int digit)
    {
        if (GameController.GetIsDetailEnable())
        {
            GameController.currentDigit = digit;
            DigitSelectCanvas.gameObject.SetActive(false);
            DigitScene tempDigitScene = new DigitScene();
            if (digit == 0)
            {
                tempDigitScene = loadAlphabaticObjects.digitScenArray[0];
                this.digit.text = digit.ToString();
                this.digitText.text = tempDigitScene.numberText;
                EnableAndDisableDigitScene(digit);
                digitNextButtText.text = (digit + 1).ToString();
                digitPreviousButtText.text = (20).ToString();
                digitDetailCanvas.gameObject.SetActive(true);
                gameController.PlayAudio(digit);
                Debug.Log("found object");
            }
            else if (digit == 20)
            {
                tempDigitScene = loadAlphabaticObjects.digitScenArray[20];
                this.digit.text = digit.ToString();
                this.digitText.text = tempDigitScene.numberText;
                EnableAndDisableDigitScene(digit);
                digitNextButtText.text = (0).ToString();
                digitPreviousButtText.text = (digit - 1).ToString();
                digitDetailCanvas.gameObject.SetActive(true);
                gameController.PlayAudio(digit);
                Debug.Log("found object");
            }
            else
            {
                for (int i = 0; i < loadAlphabaticObjects.digitScenArray.Length; i++)
                {
                    if (digit == loadAlphabaticObjects.digitScenArray[i].number)
                    {
                        tempDigitScene = loadAlphabaticObjects.digitScenArray[i];
                        this.digit.text = digit.ToString();
                        this.digitText.text = tempDigitScene.numberText;
                        EnableAndDisableDigitScene(digit);
                        digitNextButtText.text = (digit + 1).ToString();
                        digitPreviousButtText.text = (digit - 1).ToString();
                        digitDetailCanvas.gameObject.SetActive(true);
                        gameController.PlayAudio(digit);
                    }
                }
            }
        }
        else
        {
            gameController.PlayAudio(digit);
        }
    }

    void EnableAndDisableDigitScene(int digit)
    {
        for (int i = 0; i < loadAlphabaticObjects.digitScenArray.Length; i++)
        {
            if (digit == loadAlphabaticObjects.digitScenArray[i].number)
            {
                loadAlphabaticObjects.digitScenArray[digit].ObjectsCanvas.SetActive(true);
                continue;
            }
            else
            {
                loadAlphabaticObjects.digitScenArray[i].ObjectsCanvas.SetActive(false);
            }

        }

    }
}
