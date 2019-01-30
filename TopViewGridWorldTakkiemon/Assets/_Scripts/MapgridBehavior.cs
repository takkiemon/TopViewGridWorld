using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapgridBehavior : MonoBehaviour
{
    public float gridBoxSize; //the distance between centre of the grid and the corner
    public int mapSize; //for now, it's the number of gridboxes spreading outwards from the center GridBox
    //public GridBox[,,] gridField;
    public GridBox[,] gridField;
    private Vector3 meanVector; //this vector is used to align the hexagon grid 

    public void Start()
    {
        //gridField = new GridBox[2 * mapSize, 2 * mapSize, 2 * mapSize];
        //gridField = new GridBox[2 * mapSize, 2 * mapSize];
    }

    public void BuildMapGrid()
    {
        if (gridField != null)
        {
            foreach (GridBox element in gridField)
            {
                element.Delete();
            }
        }

        gridField = new GridBox[2 * mapSize, 2 * mapSize];

        for (int y = -mapSize; y < mapSize; y++)
        {
            for (int x = -mapSize; x < mapSize; x++)
            {
                //for (int z = -mapSize; z < mapSize; z++)
                //{
                //gridField[x + mapSize, y + mapSize, z + mapSize] = new GridBox(x, y, z, gridBoxSize);
                //gridField[x + mapSize, y + mapSize, z + mapSize].SetPosition();
                gridField[x + mapSize, y + mapSize] = new GridBox(x, y, gridBoxSize);
                //gridField[x + mapSize, y + mapSize].SetPosition((x * 1.5f) + (y * gridBoxSize), y);
                gridField[x + mapSize, y + mapSize].SetPosition(x * gridBoxSize, (y * gridBoxSize) - (Mathf.Abs(x % 2) * .5f * gridBoxSize));
                //}
            }
        }
    }

    public void DrawGridMap()
    {
        for (int y = -mapSize; y < mapSize; y++)
        {
            for (int x = -mapSize; x < mapSize; x++)
            {
                //for (int z = -mapSize; z < mapSize; z++)
                //{
                    //Debug.Log("x: " + x + " (+ " + mapSize + "), y: " + y + " (+ " + mapSize + "), z: " + z + " (+ " + mapSize + ")");
                    //gridField[x + mapSize, y + mapSize, z + mapSize].DrawGridBox();
                    //Debug.Log("x: " + x + " (+ " + mapSize + "), y: " + y + " (+ " + mapSize + ")");
                    gridField[x + mapSize, y + mapSize].DrawGridBox();
                //}
            }
        }
    }

    public void DeleteGridMap()
    {
        for (int x = -mapSize; x < mapSize; x++)
        {
            for (int y = -mapSize; y < mapSize; y++)
            {
            //Debug.Log("x: " + x + " (+ " + mapSize + "), y: " + y + " (+ " + mapSize + ")");
            gridField[x + mapSize, y + mapSize].Delete();
            }
        }
    }
}
