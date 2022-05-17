using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private Transform destinationTransform;

    public void TeleportToSpawn(Transform tpTransform)
    {
        tpTransform.position = destinationTransform.position;
    }
}
