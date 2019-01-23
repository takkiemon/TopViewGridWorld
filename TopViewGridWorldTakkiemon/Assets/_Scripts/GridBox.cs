using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBox : MonoBehaviour
{
    public GridPoint gridPoint; //this holds the location of the gridbox in the form of three coordinates (x, y and z)
    public float gridBoxSize; //this is mostly the distance between the centre of the hex and a corner/side(tbd)

    public GridBox()
    {
        gridPoint = new GridPoint();
    }

    public GridBox(int x, int y, int z)
    {
        gridPoint = new GridPoint(x, y, z);
    }

    public GridBox(int[] coordinates)
    {
        if (coordinates.Length == 3)
        {
            gridPoint = new GridPoint(coordinates[0], coordinates[1], coordinates[2]);
        }
        else
        {
            gridPoint = new GridPoint();
            Debug.Log("A GridBox is attempted to be made with an array of a size other than 3. The array is supposed to have three elements (x, y and z). The coordinates are set to '(0, 0, 0)'");
        }
    }

    public void DrawGridBox()
    {
        
    }

    public int DistanceToGridBox(GridBox comparingGridBox)
    {
        return gridPoint.DistanceToGridPoint(comparingGridBox.gridPoint);
    }
}
