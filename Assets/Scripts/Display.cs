using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour
{
    [SerializeField]
    private BrickData brickData;
    [SerializeField]
    private  List<SpriteRenderer> spriteRenderers;
    

    private void Start()
    {
        UpdateDisplay();
    }

    public void setActive(bool isActive)
    {
        for (int i = 0; i < spriteRenderers.Count; i++)
        {
            spriteRenderers[i].enabled = isActive;
        }
    }

    public void UpdateDisplay()
    {
        for (int i = 0; i < brickData.Layers.Count; i++)
        {
            if (brickData.Layers[i] != null)
            {
                SpriteRenderer renderer = spriteRenderers[i];
                renderer.sprite = brickData.Layers[i];
                renderer.color = brickData.Colors[i];
            }
        }
    }

    public void UpdateDisplay(BrickData Data)
    {
        brickData = Data;
        for (int i = 0; i < brickData.Layers.Count; i++)
        {
            if (brickData.Layers[i] != null)
            {
                SpriteRenderer renderer = spriteRenderers[i];
                renderer.sprite = brickData.Layers[i];
                renderer.color = brickData.Colors[i];
            }
        }
    }
}
