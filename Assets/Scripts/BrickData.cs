using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Brick", menuName = "Data Objects/Create Brick")]
public class BrickData : ScriptableObject
{
    [SerializeField]
    private string brickName;
    [SerializeField]
    private List<Sprite> layers;
    [SerializeField]
    private List<Color> colors;
    [SerializeField]
    private string text;

    public string BrickName { get => brickName; }
    public List<Color> Colors { get => colors; }
    public List<Sprite> Layers { get => layers; }
    public string Text { get => text; }

}
