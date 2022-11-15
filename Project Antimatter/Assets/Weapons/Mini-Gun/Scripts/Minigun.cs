using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigun : MonoBehaviour
{
    [SerializeField] Transform miniGun;
    [SerializeField] GameObject weaponMiniGun;
    [SerializeField] GameObject minigunlaserLocationObject;
    [SerializeField] GameObject minigunlaser2LocationObject;
    [SerializeField] GameObject minigunlaser3LocationObject;
    [SerializeField] float laserSpeed, laserSpeed2, laserSpeed3;
    float fireRate = 5, fireRate2 = 6, fireRate3 = 6;
    [SerializeField] float timetoShoot, timetoShoot2, timetoShoot3;
    Vector2 direction;
    Object laserRef;
    Object laserRef2;
    Object laserRef3;
    void Start()
    {
        laserRef = Resources.Load("MiniGunLaser");
        laserRef2 = Resources.Load("MiniGunLaser2");
        laserRef3 = Resources.Load("MiniGunLaser3");
    }
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)(miniGun.position);
        MouseFacing();

        if (weaponMiniGun.activeSelf && Input.GetMouseButton(0))
        {
            if (Time.time > timetoShoot)
            {
                timetoShoot = Time.time + 1 / fireRate;
                //Center Bullet
                GameObject laser = (GameObject)Instantiate(laserRef, minigunlaserLocationObject.transform.position, minigunlaserLocationObject.transform.rotation);
                laser.GetComponent<Rigidbody2D>().AddForce(laser.transform.right * laserSpeed);
            }
            
            if (Time.time > timetoShoot2)
            {
                timetoShoot2 = Time.time + 1 / fireRate2;
                //Top Bullet #2
                GameObject laser2 = (GameObject)Instantiate(laserRef2, minigunlaser2LocationObject.transform.position, minigunlaser2LocationObject.transform.rotation);
                laser2.GetComponent<Rigidbody2D>().AddForce(laser2.transform.right * laserSpeed2);
            }
            if (Time.time > timetoShoot3)
            {
                timetoShoot3 = Time.time + 1 / fireRate3;
                //Bottom Bullet #3
                GameObject laser3 = (GameObject)Instantiate(laserRef3, minigunlaser3LocationObject.transform.position, minigunlaser3LocationObject.transform.rotation);
                laser3.GetComponent<Rigidbody2D>().AddForce(laser3.transform.right * laserSpeed3);
            }
        }
    }

    void MouseFacing()
    {
        miniGun.transform.right = direction;
    }

}
