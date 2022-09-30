using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectRB03 : MonoBehaviour
{
    // To solve it, the BlueCube had a mass of 1000, so I just lowered it so the redCube could push
    Rigidbody rigidbody;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector3(-5, 0, 0); // Don't change this!
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(moveDirection, ForceMode.Force); // Don't change this!
    }
}
