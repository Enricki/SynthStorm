using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class BrickDisplay : MonoBehaviour
{
    public List<SpriteRenderer> spriteRenderers;
    public TMP_Text brickText;
    [SerializeField]
    EventSender eventSender;


    public void UpdateDisplay(Brick brick)
    {
        BrickData brickData = (BrickData)brick.ActiveData;
        for (int i = 0; i < spriteRenderers.Count; i++)
        {
            spriteRenderers[i].sprite = brickData.Layers[i];
        }
        spriteRenderers[0].color = brickData.BackColor;
        spriteRenderers[2].color = brickData.BackColor;

        eventSender = GetComponent<EventSender>();
     //   eventSender.SetEvent(brickData.Actions);
    }

}
