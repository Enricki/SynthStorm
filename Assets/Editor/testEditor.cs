using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(StackData))]
public class testEditor : Editor
{
    public Color sd;
    public GUISkin skin;
    StackData test;
    private void OnEnable()
    {
        test = (StackData)target;
        int i = 0;
   //     test.coords.Clear();
    }
    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();


        if (test == null) return;
        Undo.RecordObject(test, "Change test");

        skin = (GUISkin)EditorGUIUtility.Load("BrickGUI.guiskin");
        GUI.skin = skin;
        GUILayout.Space(10);

        for (int y = test.StackSize.y - 1, i = 24; y >= 0; y--)
        {
            GUILayout.BeginHorizontal();
            for (int x = 0; x < test.StackSize.x; x++)
            {
                test.bBools[i] = test.Bools[x, y] = GUILayout.Toggle(test.bBools[i], "", GUILayout.Width(50), GUILayout.Height(50));
                i--;
            }
            GUILayout.EndHorizontal();
        }
    }


}
