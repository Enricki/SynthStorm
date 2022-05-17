using UnityEngine;

public class InspectorButtonAttribute : PropertyAttribute
{
    //public string MethodName { get; }
    //public InspectorButtonAttribute(string methodName)
    //{
    //    MethodName = methodName;
    //}

    public string ButtonName { get; }
    public InspectorButtonAttribute(string buttonName)
    {
        ButtonName = buttonName;
    }
}
