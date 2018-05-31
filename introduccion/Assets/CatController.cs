using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour {

	public TilesManager tilesManager;
	public Cat cat;
	Tile tile;

	public sides side;
	public enum sides
	{
		FRONT,
		RIGHT,
		BACK,
		LEFT
	}

	public void InitCatInTile(Tile tile)
	{
		this.tile = tile;
		cat.transform.position = tile.transform.position;
	}
	public void StepForward()
	{
		Tile newTile = null;
		switch(side)
		{
		case sides.FRONT:
			newTile = tilesManager.GetTileInCoords ((int)tile.coords.x, (int)tile.coords.y + 1);
			break;
		case sides.RIGHT:
			newTile= tilesManager.GetTileInCoords ((int)tile.coords.x+1, (int)tile.coords.y);
			break;
		}
		if (newTile == null)
			return;
		tile = newTile;
		cat.transform.position = tile.transform.position;
	}
}
