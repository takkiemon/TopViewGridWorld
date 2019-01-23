using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapgridBehavior : MonoBehaviour
{
    public float gridBoxSize; //the distance between centre of the grid and the corner
    public int gridMapSize; //for now, it's the number of gridboxes spreading outwards from the center GridBox
    public GridBox[,,] gridField;
    private Vector3 meanVector; //this vector is used to align the hexagon grid 

    public void BuildMapGrid()
    {
        for (int x = -gridMapSize; x < gridMapSize; x++)
        {
            for (int y = -gridMapSize; y < gridMapSize; y++)
            {
                for (int z = -gridMapSize; z < gridMapSize; z++)
                {
                    gridField[x, y, z] = new GridBox(x, y, z);
                }
            }
        }
    }


}
