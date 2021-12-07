using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public SceneDataSO sceneData;

    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.None;
        

    }


    public void PlayGame()
    {
        sceneData.newLevel = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void LoadGame()
    {
        sceneData.newLevel = false;
        SceneManager.LoadScene(sceneData.sceneToLoad);
    }

    public void LoadLevel01()
    {
        sceneData.newLevel = true;
        SceneManager.LoadScene("Level01");
    }
    public void LoadLevel02()
    {
        sceneData.newLevel = true;
        SceneManager.LoadScene("Level02");
    }
    public void LoadLevel03()
    {
        sceneData.newLevel = true;
        SceneManager.LoadScene("Level03");
    }

    public void Mainmenu()
    {
        sceneData.newLevel = true;
        SceneManager.LoadScene("FinalMenu");
    }

}
