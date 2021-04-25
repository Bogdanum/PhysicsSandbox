using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperRealisticSSControl : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float speed = 5f, rotationSpeed = 1f;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.maxAngularVelocity = Mathf.Infinity;  // максимальная угловая скорость (если уж совсем быстро нужно вращать)
    }

    void FixedUpdate()
    {
        float sideForce = Input.GetAxis("Horizontal") * rotationSpeed;
        float forwardForce = Input.GetAxis("Vertical") * speed;

        _rigidbody.AddRelativeForce(0f, 0f, forwardForce);
        _rigidbody.AddRelativeTorque(0f, sideForce, 0f);
    }
}
