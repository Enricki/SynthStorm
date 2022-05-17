using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Brick", menuName = "Data Objects/Create Brick")]
public class BrickData : ScriptableObject
{
    [SerializeField]
    private string brickName;
    [SerializeField]
    private Color backColor;
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private string text;

    public string BrickName { get => brickName; }
    public Color BackColor { get => backColor; }
    public Sprite Icon { get => icon; }
    public string Text { get => text; }

}
