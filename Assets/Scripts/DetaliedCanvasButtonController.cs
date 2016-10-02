using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DetaliedCanvasButtonController : MonoBehaviour 
{
    [SerializeField]
    private LoadAphabiticObjects loadAlphabaticObjects;
    [SerializeField]
    private Text nextButtonText;
    [SerializeField]
    private Text previousButtonText;
    [SerializeField]
    private Canvas DetailedObjectsCanvas;
    [SerializeField]
    private Canvas capitalAlphaSelectCanvas;
    [SerializeField]
    private Canvas smallAlphaSelectCanvas;

    public GameController gameController;

    public Text alphbitTxt;
    public Image itemImg;
    public Text itemTextTxt;

    private string nextAlpha;
    private string PreviousAlpha;
    private SceneObjectType nextScene;

    [SerializeField]
    private GameObject nextButton;
    [SerializeField]
    private GameObject perivousButton;

    void Start()
    {
        nextScene = new SceneObjectType();
    }

    public void Next()
    {
        nextButton.SetActive(false);
        perivousButton.SetActive(false);
        this.NextScene();
    }

    public void Previous()
    {
        this.PerviousScene();
    }

    public void Back()
    {
        if (GameController.isCapital)
        {
            capitalAlphaSelectCanvas.gameObject.SetActive(true);
            DetailedObjectsCanvas.gameObject.SetActive(false);
        }
        else
        {
            smallAlphaSelectCanvas.gameObject.SetActive(true);
            DetailedObjectsCanvas.gameObject.SetActive(false);
        }
    }

    void NextScene()
    {
        if (GameController.isCapital)
        {
            nextAlpha = loadAlphabaticObjects.LoadNextAlphabit(nextButtonText.text);
            PreviousAlpha = loadAlphabaticObjects.LoadNextAlphabit(previousButtonText.text);
            nextScene = loadAlphabaticObjects.LoadCurrentCanvasObject(nextButtonText.text);
            gameController.PlayerAudio((char)(nextButtonText.text[0]));
            nextButtonText.text = nextAlpha;
            previousButtonText.text = PreviousAlpha;
            alphbitTxt.text = nextScene.alphabetText;
            itemImg.sprite = nextScene.itemImge;
            itemTextTxt.text = nextScene.itemText;
            Debug.Log("next: " + nextAlpha + "  pre: " + PreviousAlpha);
        }
        else
        {
            nextAlpha = loadAlphabaticObjects.LoadNextAlphabit(nextButtonText.text);
            PreviousAlpha = loadAlphabaticObjects.LoadNextAlphabit(previousButtonText.text);
            nextScene = loadAlphabaticObjects.LoadCurrentCanvasObject(nextButtonText.text);
            gameController.PlayerAudio((char)(nextButtonText.text[0]));
            nextButtonText.text = nextAlpha;
            previousButtonText.text = PreviousAlpha;
            alphbitTxt.text = nextScene.SmallAlphabetText;
            itemImg.sprite = nextScene.itemImge;
            itemTextTxt.text = nextScene.SmallItemText;
            Debug.Log("next: " + nextAlpha + "  pre: " + PreviousAlpha);
        }
    }
    void PerviousScene()
    {
        if (GameController.isCapital)
        {
            nextAlpha = loadAlphabaticObjects.LoadPreivousAlphabit(nextButtonText.text);
            PreviousAlpha = loadAlphabaticObjects.LoadPreivousAlphabit(previousButtonText.text);
            nextScene = loadAlphabaticObjects.LoadCurrentCanvasObject(previousButtonText.text);
            gameController.PlayerAudio((char)(previousButtonText.text[0]));
            nextButtonText.text = nextAlpha;
            previousButtonText.text = PreviousAlpha;
            alphbitTxt.text = nextScene.alphabetText;
            itemImg.sprite = nextScene.itemImge;
            itemTextTxt.text = nextScene.itemText;

            Debug.Log("next: " + nextAlpha + "  pre: " + PreviousAlpha);
        }
        else
        {
            nextAlpha = loadAlphabaticObjects.LoadPreivousAlphabit(nextButtonText.text);
            PreviousAlpha = loadAlphabaticObjects.LoadPreivousAlphabit(previousButtonText.text);
            nextScene = loadAlphabaticObjects.LoadCurrentCanvasObject(previousButtonText.text);
            gameController.PlayerAudio((char)(previousButtonText.text[0]));
            nextButtonText.text = nextAlpha;
            previousButtonText.text = PreviousAlpha;
            alphbitTxt.text = nextScene.SmallAlphabetText;
            itemImg.sprite = nextScene.itemImge;
            itemTextTxt.text = nextScene.SmallItemText;

            Debug.Log("next: " + nextAlpha + "  pre: " + PreviousAlpha);
        }
    }
}
