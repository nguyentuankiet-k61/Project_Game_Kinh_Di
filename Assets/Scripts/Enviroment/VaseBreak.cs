using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseBreak : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fakeVase;
    public GameObject brokenVase;
    public GameObject sphereObject;
    public AudioSource potteryBreak;
    public GameObject keyObject;
    public void DamageZombie(int damage)//phuong thuc tut mau
    {
        StartCoroutine(BreakVase());
    }
    IEnumerator BreakVase()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        potteryBreak.Play();
        keyObject.SetActive(true);
        fakeVase.SetActive(false);
        brokenVase.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        sphereObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        sphereObject.SetActive(false) ;

    }
}
