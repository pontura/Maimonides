using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereWorld : MonoBehaviour {

	public GameObject street;
	public int separation;
	public PrincipitoSignal signal;

	void Start () {
		for (int i = 0; i < 360; i = i + separation) {
			GameObject newGameObject = Instantiate (street);
			newGameObject.transform.SetParent (transform);
			newGameObject.transform.localScale = Vector3.one;
			newGameObject.transform.localEulerAngles = new Vector3 (i, 0, 0);
		}
		for (int i = 0; i < 360; i = i + 60) {
			PrincipitoSignal newGameObject = Instantiate (signal);
			newGameObject.transform.SetParent (transform);
			newGameObject.transform.localScale = Vector3.one;
			newGameObject.transform.localEulerAngles = new Vector3 (i, 0, 0);
			newGameObject.DrawNumber (i/6);

		}
	}
	void Update()
	{
		transform.Rotate (-Vector3.right, Time.deltaTime*10);
	}
}
