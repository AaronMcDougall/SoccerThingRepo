using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Umpire))]
public class WhistleEditor : Editor
{
    public Umpire ump;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        if (GUILayout.Button("Whistle Function"))
        {
            Debug.Log("Whistle Function going");
            ump.Whistle();
        }
    }
}
