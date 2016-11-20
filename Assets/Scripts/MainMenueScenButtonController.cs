using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenueScenButtonController : MonoBehaviour 
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Setting()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }

    public void MoreGames()
    {

    }
}
