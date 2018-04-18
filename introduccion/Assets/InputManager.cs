using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	public float up;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		up = Input.GetAxis ("Vertical");
	}
}
