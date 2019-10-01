using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Gun : MonoBehaviour
{
    public UnityEvent generate;
    private void Start()
    {
        print("Click the box to shoot");
    }
    private void OnMouseDown()
    {
       generate.Invoke();
        //on click generates bullet
    }



}