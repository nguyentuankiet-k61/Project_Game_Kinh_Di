using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BZJumpTrigger : MonoBehaviour
{
    public AudioSource doorBang;// am thanh cua
    public AudioSource zombieScream;//am thanh zombie
    public GameObject theZombie;//doi tuong zombie
    public GameObject theDoor;//doi tuong cua
    //public GameObject tourch;//den

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<BoxCollider>().enabled = false;
        theDoor.GetComponent<Animation>().Play("jumpDoorAnim");
        doorBang.Play();
        zombieScream.Play();
        theZombie.SetActive(true);
        //StartCoroutine(Tstart());
    }
    
   
}
