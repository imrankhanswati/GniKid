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
    private Canvas alphaSelectCanvas;

    public Text alphbitTxt;
    public Image itemImg;
    public Text itemTextTxt;

    public Text nextButtText;
    public Text PreviousButtText;

    private SceneObjectType sceneObjects;

    public bool isDetailesEnabled = true;

    public void ClickA()
    {
        SetDetailCanvas('A');
        
    }

    public void ClickB()
    {
        SetDetailCanvas('B');
    }

    public void ClickC()
    {
        SetDetailCanvas('C');
    }

    public void ClickD()
    {
        SetDetailCanvas('D');
    }

    public void ClickE()
    {
        SetDetailCanvas('E');
    }

    public void ClickF()
    {
        SetDetailCanvas('F');
    }

    public void ClickG()
    {
        SetDetailCanvas('G');
    }

    public void ClickH()
    {
        SetDetailCanvas('H');
    }

    public void ClickI()
    {
        SetDetailCanvas('I');
    }

    public void ClickJ()
    {
        SetDetailCanvas('J');
    }

    public void ClickK()
    {
        SetDetailCanvas('K');
    }

    public void ClickL()
    {
        SetDetailCanvas('L');
    }

    public void ClickM()
    {
        SetDetailCanvas('M');
    }

    public void ClickN()
    {
        SetDetailCanvas('N');
    }

    public void ClickO()
    {
        SetDetailCanvas('O');
    }

    public void ClickP()
    {
        SetDetailCanvas('P');
    }

    public void ClickQ()
    {
        SetDetailCanvas('Q');
    }

    public void ClickR()
    {
        SetDetailCanvas('R');
    }

    public void ClickS()
    {
        SetDetailCanvas('S');
    }

    public void ClickT()
    {
        SetDetailCanvas('T');
    }

    public void ClickU()
    {
        SetDetailCanvas('U');
    }

    public void ClickV()
    {
        SetDetailCanvas('V');
    }

    public void ClickW()
    {
        SetDetailCanvas('W');
    }

    public void ClickX()
    {
        SetDetailCanvas('X');
    }

    public void ClickY()
    {
        SetDetailCanvas('Y');
    }

    public void ClickZ()
    {
        SetDetailCanvas('Z');
    }

    void SetDetailCanvas(char myAlpha)
    {
        if (myAlpha == 'A')
        {
            sceneObjects = loadAlphabaticObjects.LoadCurrentCanvasObject(myAlpha.ToString());
            nextButtText.text = ((char)((int)myAlpha + 1)).ToString();
            PreviousButtText.text = "Z";
            alphbitTxt.text = sceneObjects.alphabetText;
            itemImg.sprite = sceneObjects.itemImge;
            itemTextTxt.text = sceneObjects.itemText;
            detailCanvas.gameObject.SetActive(true);
            alphaSelectCanvas.gameObject.SetActive(false);
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
            alphaSelectCanvas.gameObject.SetActive(false);
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
            alphaSelectCanvas.gameObject.SetActive(false);
        }
    }
}
