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
		int value_x;
		if (cafe.temperature > 0 && cafe.temperature < 100) {
			value_x = cafe.temperature;
		} else if (cafe.temperature <0) {
			value_x = 0;
		} else {
			value_x = 100;
		}
		marcador.localScale = new Vector3 (value_x, 4, 4);
	}
	void CorrerElMarcador()
	{
		int value_x;
		if (cafe.temperature > 0 && cafe.temperature < 100) {
			value_x = cafe.temperature;
		} else if (cafe.temperature <0) {
			value_x = 0;
		} else {
			value_x = 100;
		}
		marcador.position = new Vector3 (value_x, 0, 0);
	}
}
