using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GridPoint : MonoBehaviour
{
    public int[] coordinates = new int[3]; //this array holds the three coördinates of the hexgridbox: x, y and z

    public int x() => this.coordinates[0];
    public int y() => this.coordinates[1];
    public int z() => this.coordinates[2];

    public GridPoint()
    {
        coordinates = new int[] { 0, 0, 0 };
    }

    public GridPoint(int x, int y, int z)
    {
        coordinates = new int[] { x, y, z };
    }

    public int DistanceToGridPoint(GridPoint comparingGridPoint)
    {
        int[] comparingValues = new int[3];
        for (int i = 0; i < comparingValues.Length; i++)
        {
            comparingValues[i] = Math.Abs(comparingGridPoint.coordinates[i] - this.coordinates[i]);
        }
        return (comparingValues.Sum() / 2);
    }
}
