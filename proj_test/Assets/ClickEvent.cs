using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickEvent : MonoBehaviour
{
    public UnityEvent mouse;
    public void OnMouseDown()
    {
        mouse.Invoke();
    }
}
