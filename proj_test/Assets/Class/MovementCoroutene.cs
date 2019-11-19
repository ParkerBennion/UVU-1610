using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCoroutene : MonoBehaviour {
    
    private CharacterController controller;
    public float speed = 100f;
    public Vector3 position;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update () {
        position.x = speed*Input.GetAxis("Mouse X");
        position.y = speed*Input.GetAxis("Mouse Y");

        controller.Move(position*Time.deltaTime);
		
    }
}
