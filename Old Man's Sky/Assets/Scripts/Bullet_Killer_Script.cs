﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Killer_Script : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet Stop")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Balloon")
        {
            Destroy(collision.gameObject);
            Score_Script.scoreValue += 1;
        }
    }

}
