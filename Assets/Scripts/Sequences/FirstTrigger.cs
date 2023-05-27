using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstTrigger : MonoBehaviour
{
    public GameObject PlayerScripts;
    public GameObject TextBox;
    public GameObject GuideArrow;
    private void OnTriggerEnter(Collider other)
    {
        PlayerScripts.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScencePlayer());
    }
    IEnumerator ScencePlayer()
    {
        
        TextBox.GetComponent<Text>().text = "Hãy nhìn vào dấu mũi tên";
        yield return new WaitForSeconds(2f);
        TextBox.GetComponent<Text>().text = "";
        PlayerScripts.GetComponent<FirstPersonController>().enabled = true;
        GuideArrow.SetActive(true);

    }

}
