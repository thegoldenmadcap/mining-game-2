using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastShoot : MonoBehaviour
{
    public int GunDamage = 1;
    public float FireRate = .025f;
    public float WeaponRange = 50f;
    public float HitForce = .01f;
    public Transform gunEnd;
    public GameObject laserParticles;
    public float particleRate = .25f;

    


    public Camera FPScam;
    private WaitForSeconds shotDuration = new WaitForSeconds(11111.2f);
    private LineRenderer laserLine;
    private float nextFire;
    private float partCooldown;
    


    void Start()
    {
        laserLine = GetComponent<LineRenderer>();
        FPScam = GetComponentInParent<Camera>();
        nextFire = 1f;
        
        
    }

    void Update()
    {
        //Ray ray = new Ray (FPScam.transform.position, FPScam.transform.forward);
        //Debug.DrawRay(ray.origin, ray.direction * WeaponRange);
        if (Input.GetButtonUp("Fire1"))
        {
            laserLine.enabled = false;
        }


    }
    private void FixedUpdate()
    {
        if (Input.GetButton("Fire1")/*&& Time.time > nextFire*/)
        {
            Debug.Log("SHOT");
            nextFire = Time.time + FireRate;
            StartCoroutine(ShotEffect());
            Vector3 rayOrigin = FPScam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
            RaycastHit hit;
            laserLine.SetPosition(0, gunEnd.position);
            if (Physics.Raycast(rayOrigin, FPScam.transform.forward, out hit, WeaponRange))
            {
                laserLine.SetPosition(1, hit.point);
                Instantiate(laserParticles, hit.point, Quaternion.identity);
                SlimeHP slimeHP = hit.collider.GetComponent<SlimeHP>();
                if (slimeHP != null) 
                {
                    slimeHP.damage(GunDamage/144f);
                }
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * HitForce/16);



                }

            }
            
            
            else
            {
                laserLine.SetPosition(1, rayOrigin + (FPScam.transform.forward * WeaponRange));
            }


        }

        
        
    }
    private IEnumerator ShotEffect()
    {
        laserLine.enabled = true;
        yield return shotDuration;
        laserLine.enabled = false;
    }
}
