using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipsController : MonoBehaviour
{
    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private List<AudioClip> Clips;

    public void PlayTrackFromIndex(int index)
    {
        source.Stop();
        source.clip = Clips[index];
        source.Play();
    }
}
