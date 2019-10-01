using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(CharacterController))]
public class Bullets : MonoBehaviour
{
    
    public Vector3 velocity;
    public CharacterController controller;
    public UnityEvent penitrate;

    private void Start()
    {
        print("BANG");
    }

    private void Update()
    {
        controller.Move(velocity*Time.deltaTime);
        //sets consistant speed
    }


    private void OnCollisionEnter(Collision other)
    {
        penitrate.Invoke();
        //bullet dissapears when it hits obj.
    }
    
}