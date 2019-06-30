using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon_Spawner_Script : MonoBehaviour
{
    public GameObject balloonPrefab;
    GameObject gj;

    public float respawnTime = 5;
    private Vector2 screenBounds;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(Balloon_Wave());
    }
    private void Spawn_App()
    {
            gj = Instantiate(balloonPrefab) as GameObject;
        gj.transform.position = new Vector2(Random.Range(-screenBounds.x+3, screenBounds.x-1), -screenBounds.y);
    }
    
    IEnumerator Balloon_Wave()
    {   while (true)
        {
                Spawn_App();
                yield return new WaitForSeconds(respawnTime);
        }
    }
}
