using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float movementSpeed; // How much the player moves in a given direction

    private Rigidbody rigidBody;
    private Vector3 input, movement;

	// Use this for initialization
	void Awake () {
        rigidBody = GetComponent<Rigidbody>();
        movement = Vector3.zero;
	}
	
	// FixedUpdate is called once per fixed framerate frame
	void FixedUpdate () {
        input = Vector3.zero;

        // Structured so players cannot move simultaneously in opposing directions
        if (Input.GetAxis("Horizontal") < 0f)  // moving left 
            input += Vector3.left;
        else if (Input.GetAxis("Horizontal") > 0f)  // moving right
            input += Vector3.right;
        if (Input.GetAxis("Vertical") > 0f) // moving up 
            input += Vector3.up;
        else if (Input.GetAxis("Vertical") < 0f)  // moving down
            input += Vector3.down;
        

        input.Normalize();

        movement = input * movementSpeed * Time.fixedDeltaTime;
        rigidBody.MovePosition(rigidBody.position + movement);
	}
}
