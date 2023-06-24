using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeadth : MonoBehaviour
{
    public int ZombieHelth = 20;//thanh mau cua zombie
    public GameObject TheEnemy;//doi tuogn zombie
    public int StatusCheck;


    public void DamageZombie(int damage)//phuong thuc tut mau
    {
        ZombieHelth -= damage;
    }

    // Update is called once per frame
    void Update()
    {

        if (ZombieHelth <= 0 && StatusCheck == 0)
        {
            StatusCheck = 2;
            TheEnemy.GetComponent<Animation>().Stop("Z_Run_InPlace 1");
            TheEnemy.GetComponent<Animation>().Play("Z_FallingForward 1");
        }
    }
   
    
}
