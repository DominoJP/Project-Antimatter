using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TankAI : MonoBehaviour
{
    public float Speed;
    public float StoppingDistance;
    private Transform Target;
    public GameObject EnemyExplosion;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Target.position) > StoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D()
    {

            animator.Play("EnemyExplosion");
            Destroy(gameObject);
      
    }

}
