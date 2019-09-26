using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCar : MonoBehaviour
{
    Quaternion initialrot;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialrot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            
            transform.rotation = initialrot;
            rb.AddForce(0, 5, 0, ForceMode.VelocityChange);
        }

    }
}
