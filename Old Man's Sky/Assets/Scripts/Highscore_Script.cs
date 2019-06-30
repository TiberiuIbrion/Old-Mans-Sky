using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Highscore_Script : MonoBehaviour
{
    public static int highscoreValue = 0;
    Text highscore;
    // Start is called before the first frame update
    void Start()
    {
        highscoreValue = PlayerPrefs.GetInt("Highscore");
        highscore = GetComponent<Text>();
    }
    void Highscore_Display()
    {
        highscore.text = "Highscore: " + highscoreValue;
    }
    void Highscore_Reached()
    {
        if (Score_Script.scoreValue > highscoreValue)
        {
            highscoreValue = Score_Script.scoreValue;
            PlayerPrefs.SetInt("Highscore", highscoreValue);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        Highscore_Reached();
        Highscore_Display();
        
    }
}
