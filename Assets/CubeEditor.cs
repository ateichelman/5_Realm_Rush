using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour {
	
	[SerializeField] [Range(1f, 20f)] float gridSize = 10f;

	TextMesh textMesh;

	// Use this for initialization
	void Start () {
		// Debug.Log("Editor causes this Awake");

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("Editor causes this Update");
		Vector3 snapPos;
		snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;

		snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;

		transform.position = new Vector3(snapPos.x, 0f, snapPos.z);

		textMesh = GetComponentInChildren<TextMesh>(); // Breaks if we have more than 1 text mesh in children
		textMesh.text = snapPos.x / gridSize + ", " + snapPos.z / gridSize;
		
	}
}
