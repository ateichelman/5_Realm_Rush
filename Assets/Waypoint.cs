﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {
	// Temporary, used to give blocks a "Block" tag.

		const int gridSize = 10;

		Vector2Int gridPos;

	public Vector2 GetGridPos(){
		return new Vector2Int(
			Mathf.RoundToInt(transform.position.x / gridSize) * gridSize, 
			Mathf.RoundToInt(transform.position.z / gridSize) * gridSize
		);
	}

	public int GetGridSize(){
		return gridSize;
	}
}
