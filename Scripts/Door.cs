using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public HingeJoint hingeJoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            JointSpring jointSpring = hingeJoint.spring;
            jointSpring.targetPosition = 90f;
            hingeJoint.spring = jointSpring;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            JointSpring jointSpring = hingeJoint.spring;
            jointSpring.targetPosition = 0f;
            hingeJoint.spring = jointSpring;
        } 
    }
}
