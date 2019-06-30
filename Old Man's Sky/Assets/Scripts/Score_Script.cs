using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score_Script : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }
    void Score_Display()
    {
        score.text = scoreValue.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        Score_Display();
    }
}
