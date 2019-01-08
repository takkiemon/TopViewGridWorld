﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBox : MonoBehaviour
{
    public GridPoint gridPoint; //this holds the location of the gridbox in the form of three coordinates (x, y and z)
    public float gridBoxSize; //this is mostly the distance between the centre of the hex and a corner/side(tbd)

    public int DistanceToGridBox(GridBox comparingGridBox)
    {
        return gridPoint.DistanceToGridPoint(comparingGridBox.gridPoint);
    }
}