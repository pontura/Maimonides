using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeTemperatureTester : MonoBehaviour {

	public types type;
	public enum types
	{
		MOVEDOR,
		ESCALADOR
	}

	public Transform marcador;

	public Cafe cafe;

	void Update () {
		if (type == types.MOVEDOR) {
			CorrerElMarcador ();
		} else if (type == types.ESCALADOR) {
			Escala ();
		}
	}
	void Escala()
	{
		marcador.localScale = new Vector3 (cafe.temperature, 4, 4);
	}
	void CorrerElMarcador()
	{
		marcador.position = new Vector3 (cafe.temperature, 0, 0);
	}
}
