using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Camera;
    public Transform Player;
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player.position.x + offset.x, Player.position.y + offset.y, offset.z);
    }
}
