using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float JumpForce;
    private void Start()
    {
        this.rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigidbody.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }
}


