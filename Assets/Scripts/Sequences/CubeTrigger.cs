using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    public AudioSource doorBang;// am thanh cua
    public AudioSource zombieScream;//am thanh zombie
    public GameObject theZombie;//doi tuong zombie
    public GameObject theDoor;//doi tuong cua
    public GameObject tourch;//den

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<BoxCollider>().enabled = false;
        theDoor.GetComponent<Animation>().Play("DoorOpen02");
        doorBang.Play();
        zombieScream.Play();
        StartCoroutine(Tstart());
    }
    IEnumerator Tstart()
    {
        yield return new WaitForSeconds(4f);
        tourch.SetActive(false);
        theZombie.SetActive(false);
        yield return new WaitForSeconds(10f);
        tourch.SetActive(false) ;

    }
   
}
