using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BrickDisplay : MonoBehaviour
{
    public BrickData brickData;
    public SpriteRenderer background;
    public SpriteRenderer icon;
    public TMP_Text brickText;

    private void Start()
    {
        background.color = brickData.BackColor;
        icon.sprite = brickData.Icon;
        brickText.text = brickData.Text;
    }

    public void SetDisplay()
    {

    }
}
