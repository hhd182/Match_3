using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScreen : MonoBehaviour
{
    public GameObject homePanel;
    public GameObject levelPanel;
    void Start()
    {
        homePanel.SetActive(true);
        levelPanel.SetActive(false);
    }

    
    public void Play()
    {
        homePanel.SetActive(false);
        levelPanel.SetActive(true);
    }

    public void Home()
    {
        homePanel.SetActive(true);
        levelPanel.SetActive(false);
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
