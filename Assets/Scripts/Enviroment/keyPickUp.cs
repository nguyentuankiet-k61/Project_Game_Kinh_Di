using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class keyPickUp : MonoBehaviour
{
    public float theDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject theKey;
  
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
            theKey.SetActive(false);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (theDistance < 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                GlobalInventory.firstDoorKey = true;
                
            }

        }
    }
    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
    
}
