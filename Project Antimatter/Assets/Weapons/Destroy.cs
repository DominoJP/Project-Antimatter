using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] GameObject GameObject;
    public float objectlife = .3f;

    private void Start()
    {
        Destroy(GameObject, objectlife);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(GameObject);
    }
}
