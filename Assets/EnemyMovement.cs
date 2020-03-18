using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] List<Waypoint> path;

    // Use this for initialization
    void Start()
    {
		StartCoroutine(StartPatrol());

    }

    IEnumerator StartPatrol()
    {
		print("Starting Patrol");
        foreach (var item in path)
        {
			print("Visiting block: " + item.name);
            transform.position = item.transform.position;
			yield return new WaitForSeconds(1f);
        }
		print("Ending Patrol!");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
