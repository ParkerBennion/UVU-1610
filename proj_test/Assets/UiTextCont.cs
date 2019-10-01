using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UiTextCont : MonoBehaviour
{
	private Text textLabel;
	public UnityEvent startDisplay;
	public void UpdateText(IntDataObj data)
	{
		textLabel.text = data.value.ToString();
	}

	// Use this for initialization
	void Start ()
	{
		
		textLabel = GetComponent<Text>();
		startDisplay.Invoke();
	}
}
