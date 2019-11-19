using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UiImmageCont : MonoBehaviour
{
	private Image img;
	void Awake ()
	{
		img = GetComponent<Image>();
	}

	public void UpdateImage(FloatData data)
	{
		img.fillAmount = data.value;
	}
}
