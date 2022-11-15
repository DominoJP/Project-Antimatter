using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    [SerializeField] GameObject GameObject;
    [SerializeField] Animator explosion;
    float objectlife = 1.5f;

    private void Start()
    {
        Destroy(GameObject, objectlife);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        explosion.Play("MissileExplosion");
        Invoke(nameof(DestroyMissile), .5f);
    }

    private void DestroyMissile()
    {
        Destroy(GameObject);
    }
}
