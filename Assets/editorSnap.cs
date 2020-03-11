using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class editorSnap : MonoBehaviour {
	
	[SerializeField] [Range(1f, 20f)] float gridSize = 10f;

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
		
	}
}
