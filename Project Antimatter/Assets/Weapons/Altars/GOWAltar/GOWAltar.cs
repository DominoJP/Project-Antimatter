using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOWAltar : MonoBehaviour
{
    public WeaponBehavior WeaponBehavior;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "GOW Axe Altar")
        {
            WeaponBehavior.axeUnlocked = true;
            WeaponBehavior.axeFloat.SetActive(false);
        }
    }
}
