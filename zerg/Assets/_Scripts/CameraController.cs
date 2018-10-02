using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private float panSpeed = 10f;
    private float panBorderThickness = 10f;
    private float zoom;
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.position;

        //Moving camera upwards.
        if(Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            position.z += panSpeed * Time.deltaTime;
        }
        //Moving camera leftwards.
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            position.x -= panSpeed * Time.deltaTime;
        }
        //Moving camera downwards.
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            position.z -= panSpeed * Time.deltaTime;
        }
        //Moving camera rightwards.
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            position.x += panSpeed * Time.deltaTime;
        }
        //Zooming camera inwards.
        if (Input.mouseScrollDelta.y > 0)
        {
            position.y -= panSpeed * Time.deltaTime;
        }
        //Zooming camera outwards.
        if (Input.mouseScrollDelta.y < 0)
        {
            position.y += panSpeed * Time.deltaTime;
        }

        transform.position = position;
		
	}
}
