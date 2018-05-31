using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour {

	public TilesManager tilesManager;
	public Cat cat;
	Tile tile;

	public void InitCatInTile(Tile tile)
	{
		this.tile = tile;
		cat.transform.position = tile.transform.position;
	}
	public void StepForward()
	{
		Tile newTile = tilesManager.GetTileInCoords ((int)tile.coords.x, (int)tile.coords.y + 1);
		if (newTile == null)
			return;
		tile = newTile;
		cat.transform.position = tile.transform.position;
	}
}
