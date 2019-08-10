using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour {

	pulic void SetText(string text)
	{
		Text txt = transform.Find("Text").GetComponent<Text>();	
		txt.text = text;
	}
}
