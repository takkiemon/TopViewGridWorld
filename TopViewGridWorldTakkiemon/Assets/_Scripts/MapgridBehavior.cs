using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapgridBehavior : MonoBehaviour
{
    public float gridBoxSize; //the distance between centre of the grid and the corner
    public int mapSize; //for now, it's the number of gridboxes spreading outwards from the center GridBox
    public GridBox[,,] gridField;
    private Vector3 meanVector; //this vector is used to align the hexagon grid 

    public void Start()
    {
        gridField = new GridBox[2 * mapSize, 2 * mapSize, 2 * mapSize];
    }

    public void BuildMapGrid()
    {
        for (int x = -mapSize; x < mapSize; x++)
        {
            for (int y = -mapSize; y < mapSize; y++)
            {
                for (int z = -mapSize; z < mapSize; z++)
                {
                    gridField[x + mapSize, y + mapSize, z + mapSize] = new GridBox(x, y, z, gridBoxSize);
                    gridField[x + mapSize, y + mapSize, z + mapSize].SetPosition();
                }
            }
        }
    }

    [ContextMenu("DrawGridMap")]
    public void DrawGridMap()
    {
        for (int x = -mapSize; x < mapSize; x++)
        {
            for (int y = -mapSize; y < mapSize; y++)
            {
                for (int z = -mapSize; z < mapSize; z++)
                {
                    Debug.Log("x: " + x + " (+ " + mapSize + "), y: " + y + " (+ " + mapSize + "), z: " + z + " (+ " + mapSize + ")");
                    gridField[x + mapSize, y + mapSize, z + mapSize].DrawGridBox();
                }
            }
        }
    }
}
