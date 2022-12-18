using UnityEditor;
using UnityEngine;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

[CustomPropertyDrawer(typeof(InspectorButtonAttribute))]
public class InspectorButtonPropertyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.PropertyField(position, property, label);
        string buttonName = (attribute as InspectorButtonAttribute).ButtonName;
        
        if (GUI.Button(position, buttonName))
        {
            Debug.Log("Allright!");
        }



            //string methodName = (attribute as InspectorButtonAttribute).MethodName;
            //Object target = property.serializedObject.targetObject;
            //System.Type type = target.GetType();
            //System.Reflection.MethodInfo method = type.GetMethod(methodName);
            //if (method == null)
            //{

            //    GUI.Label(position, "Method could not be found. Is it public?");
            //    return;
            //}
            //if (method.GetParameters().Length > 0)
            //{
            //    GUI.Label(position, "Method cannot have parameters.");
            //    return;
            //}
            //if (GUI.Button(position, method.Name))
            //{
            //    method.Invoke(target, null);
            //}
    }
}
