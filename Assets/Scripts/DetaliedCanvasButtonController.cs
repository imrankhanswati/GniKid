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
    private Canvas AlphaSelectCanvas;

    public GameController gameController;

    public Text alphbitTxt;
    public Image itemImg;
    public Text itemTextTxt;

    private string nextAlpha;
    private string PreviousAlpha;
    private SceneObjectType nextScene;

    void Start()
    {
        nextScene = new SceneObjectType();
    }

    public void Next()
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
        }
    }

    public void Previous()
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

    public void Back()
    {
        AlphaSelectCanvas.gameObject.SetActive(true);
        DetailedObjectsCanvas.gameObject.SetActive(false);
    }
}
