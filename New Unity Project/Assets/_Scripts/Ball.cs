using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballInitialVelocity = 600f;
    private Rigidbody rb;
    private bool ballInPlay;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    // Update is called once per frame

    

    public void Update()
    {
        if (Input.GetButtonDown("Fire1") && ballInPlay == false)
        {
            transform.parent = null;
            transform.LookAt(target);
            ballInPlay = true;
            rb.isKinematic = false;
            //rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
            rb.AddForce(transform.forward * ballInitialVelocity);
        }

        


    }
}
