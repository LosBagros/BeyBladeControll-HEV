using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    
    public void LoadScene()
    {
        SceneManager.LoadScene("Dev2"); //the index of the seconf scene
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
