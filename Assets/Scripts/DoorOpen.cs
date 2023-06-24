using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    public float theDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheDoor;
    public AudioSource sound;
    //public GameObject ExtraCross;
    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerCasting.DistanceFromTarget;

    }
     void OnMouseOver()
    {
        if(theDistance<3)
        {
            //ExtraCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if(theDistance<3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                TheDoor.GetComponent<Animation>().Play("DoorOpen01");
                sound.Play();
            }
            
        }
    }
     void OnMouseExit()
    {
        //ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
