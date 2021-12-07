using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour
{

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level01");
        
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("FinalMenu");

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
