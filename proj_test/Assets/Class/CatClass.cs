using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatClass : MonoBehaviour
{

    public UnityEvent catLight;

    private void OnMouseDown()
    {
        catLight.Invoke();
    }
}
