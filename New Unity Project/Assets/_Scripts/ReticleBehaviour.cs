using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleBehaviour : MonoBehaviour
{

    //public float mouseSensitivityX = 100;
    //public float mouseSensitivityY = 100;
    //public float reticleSpeed = 1f;
    public Camera cam2use; 


    private void Start()
    {
        Cursor.visible = false;
        //private Vector3 reticlePos = new Vector3(0, -1.0f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //float moveLR = Input.GetAxis("Mouse X") * mouseSensitivityX * Time.deltaTime;
        //float moveUD = Input.GetAxis("Mouse Y") * mouseSensitivityY * Time.deltaTime;

        Vector3 mouse = cam2use.ViewportToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mouse.x, mouse.y, 0);

        /* float xPos = transform.position.x + (Input.GetAxis("MouseX + MouseY") * reticleSpeed);
         reticlePos = new Vector3(Mathf.Clamp(xPos, -13, 13), -1.0f, 0f);
         transform.position = Input.mousePosition;*/
    }
       
}