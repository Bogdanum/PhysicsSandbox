using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandAtPoint : MonoBehaviour
{
    public Rigidbody targetRigidbody;
    public float forceValue = 100f;

   // public ParticleSystem ParticleSystem;

    void Update()
    {
       if (Input.GetMouseButtonDown(1))
        {
            targetRigidbody.AddForceAtPosition(transform.up * forceValue, transform.position);
          //  ParticleSystem.Play();
        } 
    }
}
