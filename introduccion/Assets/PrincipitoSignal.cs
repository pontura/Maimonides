using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincipitoSignal : MonoBehaviour {

	public TextMesh field;

	public void DrawNumber (int second) {
		field.text = second.ToString();
	}

}
