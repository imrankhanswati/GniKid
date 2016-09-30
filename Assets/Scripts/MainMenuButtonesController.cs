using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class MainMenuButtonesController : MonoBehaviour 
{
    
    public void LoadCapital()
    {
        GameController.isCapital = true;
        Application.LoadLevel(1);
    }
    public void LoadSmall()
    {
        GameController.isCapital = false;
        Application.LoadLevel(1);
    }
}
