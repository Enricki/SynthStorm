using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawn: MonoBehaviour
{
    public abstract Vector3 position();
    float speed = 1f;
    Grid2D grid;

    public void SpawnObject(string name, Vector3 spawnPosition, Quaternion spawnRotation, Transform parent)
    {
        Spawn clone = Instantiate(this, spawnPosition, spawnRotation, parent);
        clone.name = name;
    }
}
