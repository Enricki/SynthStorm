using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer spriteRenderer;
    public List<Color> color;
    public void ChangeColor(int i)
    {
        spriteRenderer.color = color[i];
    }
}
