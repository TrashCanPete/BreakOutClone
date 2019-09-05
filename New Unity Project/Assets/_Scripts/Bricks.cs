using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public GameObject brickParticle;

    private Shake shake;


    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        shake.CamShake();
        Instantiate(brickParticle, transform.position, Quaternion.identity);
        GM.instance.DestroyBrick();
        Destroy(gameObject);
    }

}   