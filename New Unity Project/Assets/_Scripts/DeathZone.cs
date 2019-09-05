using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{ 

    private Shake shake;

void Start()
{
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
}


    private void OnTriggerEnter(Collider col)
    {
        shake.CamShake();
        GM.instance.LoseLife();
    }
}
