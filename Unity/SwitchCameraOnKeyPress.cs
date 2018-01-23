using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    private Camera povCamera;

    private bool cameraFlag;


    // Use this for initialization
    void Awake() {
        povCamera.gameObject.SetActive(false);
        cameraFlag = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            //Debug.Log("Space Pressed");
            if (!cameraFlag) {
                mainCamera.gameObject.SetActive(false);
                povCamera.gameObject.SetActive(true);
                cameraFlag = true;
            }
            else {
                mainCamera.gameObject.SetActive(true);
                povCamera.gameObject.SetActive(false);
                cameraFlag = false;
            } 
        } 
    }
}

