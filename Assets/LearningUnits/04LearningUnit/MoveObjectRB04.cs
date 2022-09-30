using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectRB04 : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector3(-2400, 0,0); // Don't change this!
        rigidbody = GetComponent<Rigidbody>();


        // Don't move this line or add any new values (such as coefficients)!
        // Changed ForceMode to Impulse so that way I just hit the BlueCube, but RedCube slows down after
        rigidbody.AddForce(moveDirection, ForceMode.Impulse);

        // I just want to give a nudge to the blue cube, but 
	    // stay on the white plane and not fall over the edge myself...
    }

    // Update is called once per frame
    void Update()
    {
    }
}
