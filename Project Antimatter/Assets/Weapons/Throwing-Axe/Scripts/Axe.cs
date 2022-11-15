using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Rendering;

public class Axe : MonoBehaviour
{
    float axeSpeed = 50f;
    [SerializeField] Transform axePos;
    [SerializeField] GameObject axePosGame;
    [SerializeField] GameObject axeObj;
    void Start()
    {
        
    }
    void Update()
    {
        if (axeObj.activeSelf && Input.GetMouseButton(0) && axeObj.GetComponent<PositionConstraint>().isActiveAndEnabled)
        {
            axePosGame.GetComponent<SpriteRenderer>().enabled = false;
            axeObj.GetComponent<PositionConstraint>().constraintActive = false;
            axeObj.GetComponent<RotationConstraint>().constraintActive = false;
            axeObj.GetComponent<Rigidbody2D>().AddForce(axeObj.transform.right * axeSpeed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player" && Input.GetMouseButtonDown(1))
        {
            axeObj.transform.position = axePos.transform.position;
            axeObj.transform.rotation = axePos.transform.rotation;
            axeObj.GetComponent<PositionConstraint>().constraintActive = true;
            axeObj.GetComponent<RotationConstraint>().constraintActive = true;
            axePosGame.GetComponent<SpriteRenderer>().enabled = true;
            axeObj.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        }
        else
        {
            axeObj.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}
