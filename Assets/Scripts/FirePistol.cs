using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    public GameObject TheGun;
    public GameObject BulletFlash;
    public AudioSource GunFire;
    public bool isFiring = false;
    public float targetDistance;//khoang cach ban duoc 
    public int damageAmount = 5;//dame moi lan ban
  

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
        RaycastHit hit;
        isFiring = true;
        if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out hit) )
        {
            targetDistance = hit.distance;
            hit.transform.SendMessage("DamageZombie", damageAmount, SendMessageOptions.DontRequireReceiver);
        }
        TheGun.GetComponent<Animation>().Play("PistolShoot");
        BulletFlash.SetActive(true);
        BulletFlash.GetComponent<Animation>().Play("BulletFlash");
        GunFire.Play();
        yield return new WaitForSeconds(0.5f);
        isFiring = false;
    }
}
