using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 5f;
    public Transform child;
    public Transform parent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ReturnPlatform"))
        {
            speed = -speed;
        }
    }

    private void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            child.transform.SetParent(parent);
        }
    }

    private void OnCollisionExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            child.transform.SetParent(null);
        }
    }

    void Update()
    {
       transform.Translate(0, speed * Time.deltaTime, 0); 
    }
}

