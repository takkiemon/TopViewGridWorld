using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBox : MonoBehaviour
{
    public GridPoint gridPoint; //this holds the location of the gridbox in the form of three coordinates (x, y and z)
    public float gridBoxSize; //this is mostly the distance between the centre of the hex and a corner/side(tbd)
    public bool isSelected;

    public int DistanceToGridBox(GridBox comparingGridBox)
    {
        return gridPoint.DistanceToGridPoint(comparingGridBox.gridPoint);
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
