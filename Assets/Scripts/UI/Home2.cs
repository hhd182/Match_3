using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home2 : MonoBehaviour
{

    public void loadSplash()
    {
        SceneManager.LoadScene("Splash");
    }

    public void loadHome()
    {
        SceneManager.LoadScene("Home");
    }

    public void ExitGame()
    {
        Debug.Log("Quit game!");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

}
