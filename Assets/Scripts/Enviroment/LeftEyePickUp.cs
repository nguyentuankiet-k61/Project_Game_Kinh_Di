using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LeftEyePickUp : MonoBehaviour
{
    public float theDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject theLeftEye;

    public GameObject halfFade;
    public GameObject eyeImg;
    public GameObject eyeText;
  
    void Update()
    {
        theDistance = PlayerCasting.DistanceFromTarget;

    }
    void OnMouseOver()
    {
        if (theDistance < 3)
        {
            ActionText.GetComponent<Text>().text = "Pick Up Key";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
            
        }
        if (Input.GetButtonDown("Action"))
        {
            if (theDistance < 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                
                GlobalInventory.leftEye = true;
                StartCoroutine(EyePickedUp());
                
            }

        }
    }
    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
    IEnumerator EyePickedUp()
    {
        halfFade.SetActive(true);
        eyeImg.SetActive(true);
        eyeText.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        halfFade.SetActive(false);
        eyeImg.SetActive(false);
        eyeText.SetActive(false);
        theLeftEye.SetActive(false);
    }
    
}
