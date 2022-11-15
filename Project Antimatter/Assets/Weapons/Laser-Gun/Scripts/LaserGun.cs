using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour
{
    [SerializeField] GameObject weaponContainer;
    [SerializeField] Transform laserGun;
    [SerializeField] GameObject weaponLaserGun;
    [SerializeField] float laserSpeed;
    [SerializeField] GameObject BeamAnimObj;
    [SerializeField] Animator beamAnim;
    [SerializeField] float beamEnterExitTime = 1.5f;
    [SerializeField] LaserGun lasergunScript;
    bool isExtending, isRetracting;
    Animator BeamAnimator;
    Transform BeamTransform;

    void Start()
    {
        BeamAnimator = (Animator)BeamAnimObj.GetComponent<Animator>();
        beamAnim.Play("BeamExtend");
        beamAnim.SetFloat("Speed", 0);
    }
    void Update()
    {

        if (weaponLaserGun.activeSelf && Input.GetMouseButtonDown(0))
        {
            LaserExtend();
            Invoke(nameof(LaserExtended), .6f);
        }
        if (Input.GetMouseButtonUp(0))
        {

            LaserRetract();
            Invoke(nameof(LaserRetracted), .6f);
        }

    }
    void LaserExtended()
    {
        beamAnim.SetFloat("Speed", 0);
    }
    void LaserExtend()
    {
        beamAnim.SetFloat("Speed", 1f);
    }
    void LaserRetracted()
    {
        isRetracting = false;
        beamAnim.SetFloat("Speed", 0);
    }
    void LaserRetract()
    {
        beamAnim.SetFloat("Speed", -1f);
    }
}
