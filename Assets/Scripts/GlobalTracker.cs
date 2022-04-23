using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GlobalTracker : MonoBehaviour
{

    // VARS ***************
    public Slider difficultSlider;
    private float slideValue = 0;
    private string sceneName;

    // Awake *******************
    void Awake() {
        // Load data from PlayerPrefs
        PlayerPrefs.GetInt("Difficulty", 1);

        // Find Name of Current Scene
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    void Update(){

        if (sceneName == "Main")
        {
            // Do nothing
        } else {
            //slideValue = diffSlider.OnPointerUp.
        }


    }

    // OnDestroy *********************
    void OnDestroy() {
        // Use Player Prefs to track global data 
        // that needs to persist between scenes / close
        PlayerPrefs.SetFloat("Difficulty", slideValue); 
    }

    // void AdjustDifficulty()  { }

}