using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBox : MonoBehaviour
{
    public GridPoint gridPoint; //this holds the location of the gridbox in the form of three coordinates (x, y and z)
    public float size; //this is mostly the distance between the centre of the hex and a corner/side(tbd)
    public bool isSelected;
    public GameObject shape;
    public Vector3 position;

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

    public GridBox(int x, int y, int z, float gridBoxSize)
    {
        gridPoint = new GridPoint(x, y, z);
        size = gridBoxSize;
    }

    public GridBox(int[] coordinates, float gridBoxSize)
    {
        size = gridBoxSize;

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

    public void SetPosition()
    {
        Debug.Log("setposition: x: " + gridPoint.x() * 1.5f + ", y: " + gridPoint.y() + ", z: " + gridPoint.z());
        position = new Vector3(gridPoint.x() * 1.5f, gridPoint.y(), gridPoint.z());
    }

    public void DrawGridBox()
    {
        shape = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        shape.transform.localScale = new Vector3(size, size, size);
        shape.transform.position = position;
    }

    public int DistanceToGridBox(GridBox comparingGridBox)
    {
        return gridPoint.Distance(comparingGridBox.gridPoint);
    }

    public void OnMouseEnter()
    {
        //change color
    }

    public void OnMouseExit()
    {
        //unchange color
    }
}
