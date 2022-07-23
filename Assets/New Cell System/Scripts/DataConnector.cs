using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataConnector
{
    private ScriptableObject activeData;

    public ScriptableObject ActiveData { get => activeData; }
    public void SetData(ScriptableObject data)
    {
        activeData = data;
    }
}
