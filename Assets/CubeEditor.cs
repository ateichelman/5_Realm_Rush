using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{
    Waypoint waypoint;

    // Use this for initialization
    private void Awake()
    {
        // Debug.Log("Editor causes this Awake");

        waypoint = GetComponent<Waypoint>();
    }

    // Update is called once per frame
    void Update()
    {
        snapToGrid();
        UpdateLabel();
    }

    private void snapToGrid()
    {
        //Debug.Log("Editor causes this Update");
        transform.position = new Vector3(
            waypoint.GetGridPos().x,
            0f,
            waypoint.GetGridPos().y);
    }

    private void UpdateLabel()
    {
        int gridSize = waypoint.GetGridSize();
        TextMesh textMesh = GetComponentInChildren<TextMesh>(); // Breaks if we have more than 1 text mesh in children
        string labelText = waypoint.GetGridPos().x / gridSize + ", " + waypoint.GetGridPos().y / gridSize;
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}
