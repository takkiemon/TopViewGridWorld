using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MapgridBehavior))]
public class MapGridBehaviorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        MapgridBehavior gridScript = (MapgridBehavior)target;
        if (GUILayout.Button("Build Map"))
        {
            gridScript.BuildMapGrid();
        }

        if (GUILayout.Button("Draw Map")) {
            gridScript.DrawGridMap();
        }

        if (GUILayout.Button("Delete Map"))
        {
            gridScript.DeleteGridMap();
        }
    }
}
