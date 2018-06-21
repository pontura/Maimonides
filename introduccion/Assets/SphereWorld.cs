using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereWorld : MonoBehaviour {

	public Clock clock;
	public GameObject street;
	public int separation;
	public PrincipitoSignal signal;
	public Animation anim;

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
	public float secondInAnimation;

	void Update()
	{
		anim ["timer"].time = clock.hours*10/24;
		anim.Play ("timer");
		float sec = clock.sec + clock.tick;
		float _x= ((float)sec * 360) / 60;
		print (_x);
		transform.localEulerAngles = new Vector3 (_x, 0, 0);
		//transform.Rotate (-Vector3.right);
	}
}
