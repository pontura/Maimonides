using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour {

	public List<GameObject> manos;
	public Transform manoContainer1;
	public Transform manoContainer2;

	public void OnButtonClick(int id)
	{
		VaciarManos ();
		GameObject mano = manos[ id ];
		GameObject mano1 = Instantiate (mano);
		mano1.transform.SetParent (manoContainer1);
		mano1.transform.localPosition = Vector3.zero;
		mano1.transform.localEulerAngles = Vector3.zero;

		GameObject mano2 = Instantiate (mano);
		mano2.transform.SetParent (manoContainer2);
		mano2.transform.localPosition = Vector3.zero;
		mano2.transform.localEulerAngles = Vector3.zero;
	}
	void VaciarManos()
	{
		foreach (Transform t in manoContainer1) {
			GameObject.Destroy (t.gameObject);
		}
		foreach (Transform t in manoContainer2) {
			GameObject.Destroy (t.gameObject);
		}
	}
}
