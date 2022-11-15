using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VortexCannon : MonoBehaviour
{
    [SerializeField] Transform vortexCannon;
    [SerializeField] GameObject weaponVortexCannon;
    [SerializeField] GameObject vortexcannonmissileLocationObject;
    [SerializeField] float missileSpeed;
    [SerializeField] float timetoShoot;
    float fireRate = 1;
    Object missileRef;
    void Start()
    {
        missileRef = Resources.Load("VortexCannonMissile");
    }
    void Update()
    {
        if (weaponVortexCannon.activeSelf && Input.GetMouseButton(0))
        {
            if (Time.time > timetoShoot)
            {
                timetoShoot = Time.time + 1/ fireRate;
                //Center Bullet
                GameObject missile = (GameObject)Instantiate(missileRef, vortexcannonmissileLocationObject.transform.position, vortexcannonmissileLocationObject.transform.rotation);
                missile.GetComponent<Rigidbody2D>().AddForce(missile.transform.right * missileSpeed);
            }
        }
    }
}
