using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    public void Recolor()
    {
        Renderer renderer = this.GetComponent<Renderer>();
        renderer.material.color = Random.ColorHSV();
    }
}
