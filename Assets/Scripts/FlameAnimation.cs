using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimation : MonoBehaviour
{

    public int LightMode;//nut cong tac 
    public GameObject Flamelight; //doi tuong anh sang

    // Update is called once per frame
    void Update()
    {
        if (LightMode == 0)
            StartCoroutine(Animatelight());

    }
    IEnumerator Animatelight()
    {
        LightMode = Random.Range(1, 4);
        if (LightMode == 1)
        {
            Flamelight.GetComponent<Animation>().Play("TorchAnim01");
        }
        if (LightMode == 2)
        {
            Flamelight.GetComponent<Animation>().Play("TorchAnim02");
        }
        if (LightMode == 3)
        {
            Flamelight.GetComponent<Animation>().Play("TorchAnim03");
        }
        yield return new WaitForSeconds(0.99f);
        LightMode = 0;
    }
}
