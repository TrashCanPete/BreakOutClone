using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleBehaviour : MonoBehaviour
{

    public float reticleSpeed = 1f;

    private Vector3 reticlePos = new Vector3(0, -1.0f, 0);




    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Reticle") * reticleSpeed);
        reticlePos = new Vector3(Mathf.Clamp(xPos, -13, 13), -1.0f, 0f);
        transform.position = reticlePos;
    }
}