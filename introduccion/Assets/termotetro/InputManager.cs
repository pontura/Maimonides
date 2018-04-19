using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	public Cafe cafe;

	void Start () {
		
	}

	void Update () {
		float value = Input.GetAxis ("Vertical");
		cafe.ChangeTemperateValue(value);
	}
}
