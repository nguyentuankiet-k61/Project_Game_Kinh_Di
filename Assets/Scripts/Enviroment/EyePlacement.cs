using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EyePlacement : MonoBehaviour
{
    public float theDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject eyePieces;

    public GameObject realWall;
  
    void Update()
    {
        theDistance = PlayerCasting.DistanceFromTarget;

    }
    void OnMouseOver()
    {
        if(GlobalInventory.leftEye == true && GlobalInventory.rightEye == true)
        {
            if (theDistance < 3)
            {
                ActionText.GetComponent<Text>().text = "Place Eye Pieces";
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
                    eyePieces.SetActive(true);
                    realWall.GetComponent<Animator>().Play("RealRise");

                }

            }
        }
        
    }
    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
