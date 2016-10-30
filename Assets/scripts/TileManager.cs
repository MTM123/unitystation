﻿using UnityEngine;
using System.Collections;
using SS.GameLogic;

public class TileManager : MonoBehaviour {
	public GameManager gameManager;
	public Sprite tileSprite; 

	public GameManager.TileType myTileType;
	public bool[] passable;

	public int gridX;
	public int gridY;

	private GameObject[] objectStack; //TODO May just remove this, will need to see its usefulness in keeping z-order

	// Initilise first space tile
	void Start () {
		SpriteRenderer spriteRenderer;
		GameObject displaySprite;

		Sprite[] spaceSheet = Resources.LoadAll<Sprite>("turf/space"); //TODO replace this with AssetBundles for proper release

		myTileType = GameManager.TileType.Space;
		passable = new bool[4]{true, true, true, true};
		objectStack = new GameObject[50];

		int randomSpaceTile = (int)Random.Range(0, 101);
		Sprite tileSprite = spaceSheet[randomSpaceTile];

		displaySprite = transform.FindChild("Space").gameObject;
		spriteRenderer = displaySprite.GetComponent<SpriteRenderer>();
		if (tileSprite) {
			spriteRenderer.sprite = tileSprite; 
		}
	}

	void OnMouseDown() {
		Debug.Log("X: " + gridX + " Y: " + gridY);
		Debug.Log(gameManager.CheckPassable(gridX, gridY, GameManager.Direction.Up));
	}

	//TODO Add an object to the z-ordering on the tile. Just make it a stack?
	public void addObject(GameObject objectToAdd) {

	}
}