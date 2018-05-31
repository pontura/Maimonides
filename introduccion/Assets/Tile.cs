using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public Vector2 coords;

	public void Init(int coordX, int coordZ) {
		coords.x = coordX;
		coords.y = coordZ;
	}
}
