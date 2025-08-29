using System;
using UnityEditor;
using UnityEngine;




[CustomEditor(typeof(TileGenerator))]
public class TileGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Generate"))
        {
            ((TileGenerator)target).Generate();
        }

        if (GUILayout.Button("Clear"))
        {
            ((TileGenerator)target).Clear();
        }
    }
}