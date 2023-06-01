using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    public GameObject TheGun;
    public GameObject BulletFlash;
    public AudioSource GunFire;
    public bool isFiring = false;
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && GlobaAmmo.AmmoCount>=1)
        {
            if (isFiring == false)
            {
                GlobaAmmo.AmmoCount -= 1;
                StartCoroutine(firePistol());
            }
        }
    }
    IEnumerator firePistol()
    {
        isFiring = true;
        TheGun.GetComponent<Animation>().Play("PistolShoot");
        BulletFlash.SetActive(true);
        BulletFlash.GetComponent<Animation>().Play("BulletFlash");
        GunFire.Play();
        yield return new WaitForSeconds(0.5f);
        isFiring = false;
    }
}
