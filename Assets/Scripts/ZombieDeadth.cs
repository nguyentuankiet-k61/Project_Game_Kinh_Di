using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeadth : MonoBehaviour
{
    public int ZombieHelth = 25;//thanh mau cua zombie
    public GameObject zombie;//doi tuogn zombie

    public void DamageZombie(int damage)//phuong thuc tut mau
    {
        ZombieHelth -= damage;
    }

    // Update is called once per frame
    void Update()
    {
        if(ZombieHelth <=0)
        {
            zombie.GetComponent<Animation>().Stop("Z_Attack 1");
            zombie.GetComponent<Animation>().Play("Z_FallingBack");
            StartCoroutine(HideTime());
        }
    }
    IEnumerator HideTime()
    {
        yield return new WaitForSeconds(2f);
        zombie.SetActive(false);
    }
}
