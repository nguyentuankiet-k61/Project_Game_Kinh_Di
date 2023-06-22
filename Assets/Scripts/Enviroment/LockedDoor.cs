using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LockedDoor : MonoBehaviour
{
    public float theDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public AudioSource lockedDoor;
    public GameObject firstKeyDoor;
  
    void Update()
    {
        theDistance = PlayerCasting.DistanceFromTarget;

    }
    void OnMouseOver()
    {
        if (theDistance < 3)
        {
            ActionText.GetComponent<Text>().text = "Open door";
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
                StartCoroutine(DoorReset());
                
            }

        }
    }
    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
    IEnumerator DoorReset()
    {
        if (GlobalInventory.firstDoorKey == false)
        {
            lockedDoor.Play();
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }else
        {
            firstKeyDoor.GetComponent<Animator>().Play("FirstKeyDoor");
            yield return new WaitForSeconds(1.1f);
            this.GetComponent<BoxCollider>().enabled = false;
        }
        
    }
}
