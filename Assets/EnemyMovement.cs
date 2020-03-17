using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	[SerializeField] List<Block> path;

	// Use this for initialization
	void Start () {
		foreach (var item in path)
		{
			Debug.Log(item);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
