using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class povController : MonoBehaviour {

    [SerializeField]
    private float speedHorizontal;

    [SerializeField]
    private float speedVertical;

    private float yaw;
    private float pitch;
    private Vector3 cameraRotation;

    // Use this for initialization
	void Awake () {
        cameraRotation = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        yaw += speedHorizontal * Input.GetAxis("Mouse X");
        pitch -= speedVertical * Input.GetAxis("Mouse Y");

        cameraRotation.x = pitch;
        cameraRotation.y = yaw;
        cameraRotation.z = 0.0f;

        transform.eulerAngles = cameraRotation;
	}
}
