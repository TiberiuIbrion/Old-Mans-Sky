using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_And_Shoot_Script : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject head;
    public GameObject player;

    public float bulletSpeed = 60.0f;
    private Vector3 target;
    void Start()
    {

    }
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));

        Vector3 difference = target - head.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        head.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

        if (Input.GetMouseButtonDown(0))
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireBullet(direction, rotationZ);
        }
    }
    void fireBullet(Vector2 direction, float rotationZ)
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = player.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet Stop")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Balloon")
        {
            Destroy(collision.gameObject);
        }
    }
}
