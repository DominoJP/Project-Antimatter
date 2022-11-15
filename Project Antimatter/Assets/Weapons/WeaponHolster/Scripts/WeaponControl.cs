using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    [SerializeField] Transform weaponHolster;
    Vector2 direction;

    void Start()
    {
        
    }
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)(weaponHolster.position);
        MouseFacing();
    }
    void MouseFacing()
    {
        weaponHolster.transform.right = direction;
    }
}
