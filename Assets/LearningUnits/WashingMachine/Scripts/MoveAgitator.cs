using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAgitator : MonoBehaviour{

    Rigidbody rigidbody;
    Vector3 spin;
    // Start is called before the first frame update
    void Start()
    {
        spin = new Vector3(0, 30,0);
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(spin * Time.fixedDeltaTime);
        rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
    }
}