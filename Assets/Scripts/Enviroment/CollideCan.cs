using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideCan : MonoBehaviour
{
    public AudioSource impactFX;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 1)
        {
            impactFX.Play();
        }
    }
}
