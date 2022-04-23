using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    // VARS *****************
    public static int score; // Static Belongs to the CLASS not the instance
    Text text;

    // Awake ****************
    void Awake()
    {
        text = GetComponent <Text> ();
        score = 0;
    }

    // Update *********************
    void Update()
    {
        text.text = "Score: " + score;
    }
}
