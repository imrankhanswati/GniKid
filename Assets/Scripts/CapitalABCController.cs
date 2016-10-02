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
    private Canvas capitalAlphaSelectCanvas;
    [SerializeField]
    private Canvas SmallerAlphaSelectCanvas;

    public Text alphbitTxt;
    public Image itemImg;
    public Text itemTextTxt;

    public Text nextButtText;
    public Text PreviousButtText;
    public GameController gameController;
    private SceneObjectType sceneObjects;

    public GameObject nextButton;
    public GameObject perivousButton;

    public bool isDetailesEnabled = true;

    public void ClickA()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('A');
        }
        else
        {
            SetDetailCanvas('a');
        }

    }

    public void ClickB()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('B');
        }
        else
        {
            SetDetailCanvas('b');
        }
    }

    public void ClickC()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('C');
        }
        else
        {
            SetDetailCanvas('c');
        }
    }

    public void ClickD()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('D');
        }
        else
        {
            SetDetailCanvas('d');
        }
    }

    public void ClickE()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('E');
        }
        else
        {
            SetDetailCanvas('e');
        }
    }

    public void ClickF()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('F');
        }
        else
        {
            SetDetailCanvas('f');
        }
    }

    public void ClickG()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('G');
        }
        else
        {
            SetDetailCanvas('g');
        }
    }

    public void ClickH()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('H');
        }
        else
        {
            SetDetailCanvas('h');
        }
    }

    public void ClickI()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('I');
        }
        else
        {
            SetDetailCanvas('i');
        }
    }

    public void ClickJ()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('J');
        }
        else
        {
            SetDetailCanvas('j');
        }
    }

    public void ClickK()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('K');
        }
        else
        {
            SetDetailCanvas('k');
        }
    }

    public void ClickL()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('L');
        }
        else
        {
            SetDetailCanvas('l');
        }
    }

    public void ClickM()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('M');
        }
        else
        {
            SetDetailCanvas('m');
        }
    }

    public void ClickN()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('N');
        }
        else
        {
            SetDetailCanvas('n');
        }
    }

    public void ClickO()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('O');
        }
        else
        {
            SetDetailCanvas('o');
        }
    }

    public void ClickP()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('P');
        }
        else
        {
            SetDetailCanvas('p');
        }
    }

    public void ClickQ()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('Q');
        }
        else
        {
            SetDetailCanvas('q');
        }
    }

    public void ClickR()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('R');
        }
        else
        {
            SetDetailCanvas('r');
        }
    }

    public void ClickS()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('S');
        }
        else
        {
            SetDetailCanvas('s');
        }
    }

    public void ClickT()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('T');
        }
        else
        {
            SetDetailCanvas('t');
        }
    }

    public void ClickU()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('U');
        }
        else
        {
            SetDetailCanvas('u');
        }
    }

    public void ClickV()
    {
        if (GameController.isCapital)
        {
            SetDetailCanvas('V');
        }
        else
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
        else
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
        else
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
        else
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
        else
        {
            SetDetailCanvas('z');
        }
    }

    void SetDetailCanvas(char myAlpha)
    {
        if (GameController.GetIsDetailEnable())
        {
            if (GameController.isCapital)
            {
                nextButton.SetActive(false);
                perivousButton.SetActive(false);

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
                nextButton.SetActive(false);
                perivousButton.SetActive(false);

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
    }
}
