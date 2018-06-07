using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGame : MonoBehaviour {

	public TilesManager tilesManager;
	public CatController catController;
	public int originalPositionX;
	public int originalPositionZ;

	void Start () {
		tilesManager.DrawTiles ();
		Tile initTile = tilesManager.GetTileInCoords(originalPositionX,originalPositionZ);
		catController.InitCatInTile(initTile);
	}
}
