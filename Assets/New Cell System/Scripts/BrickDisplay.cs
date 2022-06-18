using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class BrickDisplay : MonoBehaviour
{
    public List<SpriteRenderer> spriteRenderers;
    public BrickData brickData;
    public TMP_Text brickText;

    private void Start()
    {
        UpdateDisplay(brickData);
    }

    public void UpdateDisplay(BrickData brickData)
    {
        for (int i = 0; i < spriteRenderers.Count; i++)
        {
            spriteRenderers[i].sprite = brickData.Layers[i];
        }
        spriteRenderers[0].color = brickData.BackColor;
        spriteRenderers[2].color = brickData.BackColor;
   //     background.color = brickData.BackColor;
   //     icon.sprite = brickData.Icon;
   //     brickText.text = brickData.Text;

        GetComponent<TriggerObj>().SetEvents(brickData.Actions);
    }
}
