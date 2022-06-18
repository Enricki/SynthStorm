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
    private Color backColor;
    [SerializeField]
    private List<Sprite> layers;
    [SerializeField]
    private string text;
    [Space(20)]
    [SerializeField]
    UnityEvent actions;

    public string BrickName { get => brickName; }
    public Color BackColor { get => backColor; }
    public List<Sprite> Layers { get => layers; }
    public string Text { get => text; }
    public UnityEvent Actions { get => actions; }

}
