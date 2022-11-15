using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour
{
    [SerializeField] GameObject weaponContainer;
    [SerializeField] Transform laserGun;
    [SerializeField] GameObject weaponLaserGun;
    [SerializeField] float laserSpeed; 
    [SerializeField] GameObject Beam;
    [SerializeField] GameObject BeamAnimObj;
    [SerializeField] Animator beamAnim;
    [SerializeField] float beamEnterExitTime = 1.5f;
    [SerializeField] LaserGun lasergunScript;
    bool isExtending, isRetracting;
    Animator BeamAnimator;
    Transform BeamTransform;

    Vector2 direction;
    void Start()
    {
        BeamAnimator = (Animator)BeamAnimObj.GetComponent<Animator>();
        BeamTransform = (Transform)Beam.GetComponent<Transform>();
    }
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)(laserGun.position);
        MouseFacing();

        if (weaponLaserGun.activeSelf && Input.GetMouseButtonDown(0))
        {
            LaserExtend();
            Invoke(nameof(LaserExtend), 1.5f);
        }
        if (Input.GetMouseButtonUp(0))
        {

            LaserRetract();
            Invoke(nameof(LaserRetracted), 1.5f);
            Invoke(nameof(ScriptReset), 1.6f);
        }

        void MouseFacing()
        {
            laserGun.transform.right = direction;
        }

    }

    void ScriptReset()
    {
        weaponContainer.SetActive(false);
    }
    void LaserExtended()
    {
        beamAnim.SetFloat("Speed", 0);
    }
    void LaserExtend()
    {
        beamAnim.SetFloat("Speed", 1f);
        beamAnim.Play("BeamExtend");
    }
    void LaserRetracted()
    {
        isRetracting = false;
        beamAnim.SetFloat("Speed", 0);
    }
    void LaserRetract()
    {
        beamAnim.SetFloat("Speed", -1f);
        beamAnim.Play("BeamExtend");
    }
}
