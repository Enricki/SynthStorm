using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public void TeleportToSpawn(Teleporter teleporter)
    {
        teleporter.transform.position = teleporter.StartPosition;
    }

    public void TeleportOnPoint(Teleporter teleporter)
    {
        teleporter.transform.position = teleporter.regularTPPosition;
    }
}
