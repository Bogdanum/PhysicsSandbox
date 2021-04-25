using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollControl : MonoBehaviour
{
    public Animator animator;
    public Rigidbody[] AllRigidbodies;
    public static RagdollControl instance;

    private void Awake()
    {
        instance = this;
        for (int i = 0; i < AllRigidbodies.Length; i++)
        {
            AllRigidbodies[i].isKinematic = true;
        }
    }

   /* void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MakePhisical();
        }
    } */

    public void MakePhisical()
    {
     //   animator.enabled = false;
        for(int i = 0; i < AllRigidbodies.Length; i++)
        {
            AllRigidbodies[i].isKinematic = false;
        }
    }
}
