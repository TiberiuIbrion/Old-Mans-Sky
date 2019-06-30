using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Death_Script : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Balloon")
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(0);
            Score_Script.scoreValue = 0;
        }
    }
}
