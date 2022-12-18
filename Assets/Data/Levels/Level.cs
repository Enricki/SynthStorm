using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "Data Objects/Create Level")]
public class Level : ScriptableObject
{
    [SerializeField]
    private AudioClip levelTrack;
    [SerializeField]
    private StackData[] stackData;






    public AudioClip LevelTrack { get => levelTrack; }
    public StackData[] StackData { get => stackData; }
}
