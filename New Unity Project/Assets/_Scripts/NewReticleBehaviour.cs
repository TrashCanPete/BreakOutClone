using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewReticleBehaviour : MonoBehaviour
{
    public Camera cam2use;

    private void Start()
    {
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            transform.position = new Vector3(hit.point.x, hit.point.y, 0);

        }
        
    }
}
