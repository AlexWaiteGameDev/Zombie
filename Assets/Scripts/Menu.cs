using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Public 
    public GameObject GlobalTracker;
    public Slider diffSlider;
  

    // Load
    public void LoadGame() 
    {
        SceneManager.LoadScene("Main");
    }


    // Quit
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
    
}