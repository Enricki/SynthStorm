using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class BrickDisplay : MonoBehaviour
{
    public BrickData brickData;
    public SpriteRenderer background;
    public SpriteRenderer icon;
    public TMP_Text brickText;

    private void Start()
    {
        UpdateDisplay(brickData);
    }

    public void UpdateDisplay(BrickData brickData)
    {
        background.color = brickData.BackColor;
        icon.sprite = brickData.Icon;
        brickText.text = brickData.Text;

        GetComponent<TriggerObj>().SetEvents(brickData.Actions);
    }
}
