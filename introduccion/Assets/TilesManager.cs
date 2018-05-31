using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesManager : MonoBehaviour {

	public Tile tile_to_instantiate;
	public int boardSize_x;
	public int boardSize_z;
	public List<Tile> tiles;

	public void DrawTiles()
	{
		for (int a = 0; a < boardSize_x; a++) {
			for (int b = 0; b < boardSize_z; b++) {
				Tile newTile = Instantiate (tile_to_instantiate);
				newTile.transform.SetParent (transform);
				newTile.transform.position = new Vector3 (a, 0, b);
				newTile.Init (a, b);
				tiles.Add (newTile);
			}
		}
	}
	public Tile GetTileInCoords(int _x, int _z)
	{
		foreach (Tile tile in tiles)
			if (tile.coords.x == _x && tile.coords.y == _z)
				return tile;
		return null;
	}
}
