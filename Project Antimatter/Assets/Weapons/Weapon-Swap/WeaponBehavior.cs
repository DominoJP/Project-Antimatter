using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehavior : MonoBehaviour
{
    [SerializeField] GameObject weaponContainer;
    [SerializeField] GameObject weaponMiniGun;
    [SerializeField] GameObject weaponLaserGun;
    [SerializeField] GameObject weaponSword;
    [SerializeField] GameObject weaponVortexCannon;
    [SerializeField] GameObject weaponAxe;
    bool minigunUnlocked = false, lasergunUnlocked = false, swordUnlocked = false, vortexcannonUnlocked = false, axeUnlocked = false;
    public int currentWeapon = 1;
    int nextWeapon;
    int previousWeapon;
    void Start()
    {

    }
    private void Update()
    {
        //Weapon Swap
        //Mini-Gun = 1, Laser = 2, Sword = 3, VortexCannon = 4, Axe = 5
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            currentWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && lasergunUnlocked)
        {
            currentWeapon = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && swordUnlocked)
        {
            currentWeapon = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && vortexcannonUnlocked)
        {
            currentWeapon = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && axeUnlocked)
        {
            currentWeapon = 5;
        }
        //Arrow-Key Weapon Swap
        nextWeapon = currentWeapon + 1;
        previousWeapon = currentWeapon - 1;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentWeapon == 5)
            {
                currentWeapon = 1;
            }
            else if (currentWeapon <= 4)
            {
                currentWeapon++;
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentWeapon == 1)
            {
                currentWeapon = 5;
            }
            else if (currentWeapon >= 1)
            {
                currentWeapon--;
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minigunUnlocked = true;
            lasergunUnlocked = true;
            swordUnlocked = true;
            vortexcannonUnlocked = true;
            axeUnlocked = true;
        }
        //Weapon Behavior
        if (minigunUnlocked && currentWeapon == 1)
        {
            weaponMiniGun.SetActive(true);
            weaponLaserGun.SetActive(false);
            weaponSword.SetActive(false);
            weaponVortexCannon.SetActive(false);
            weaponAxe.SetActive(false);
        }
        if (lasergunUnlocked && currentWeapon == 2)
        {
            weaponMiniGun.SetActive(false);
            weaponLaserGun.SetActive(true);
            weaponSword.SetActive(false);
            weaponVortexCannon.SetActive(false);
            weaponAxe.SetActive(false);
        }
        if (swordUnlocked && currentWeapon == 3)
        {
            weaponMiniGun.SetActive(false);
            weaponLaserGun.SetActive(false);
            weaponSword.SetActive(true);
            weaponVortexCannon.SetActive(false);
            weaponAxe.SetActive(false);
        }
        if (vortexcannonUnlocked && currentWeapon == 4)
        {
            weaponMiniGun.SetActive(false);
            weaponLaserGun.SetActive(false);
            weaponSword.SetActive(false);
            weaponVortexCannon.SetActive(true);
            weaponAxe.SetActive(false);
        }
        if (axeUnlocked && currentWeapon == 5)
        {
            weaponMiniGun.SetActive(true);
            weaponLaserGun.SetActive(false);
            weaponSword.SetActive(false);
            weaponVortexCannon.SetActive(false);
            weaponAxe.SetActive(true);
        }

        if (!weaponContainer.activeSelf)
        {
            weaponContainer.SetActive(true);
        }
    }
}
