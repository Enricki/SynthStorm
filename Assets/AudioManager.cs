using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    List<AudioClip> audioClips = new List<AudioClip>();
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private IEnumerator Delay(float time, AudioClip clip)
    {
        yield return new WaitForSeconds(time);
        audioSource.clip = clip;
        audioSource.Play();
    }
}
