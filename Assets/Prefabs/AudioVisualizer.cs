using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVisualizer : MonoBehaviour
{
    public float minHeight = 15f;
    public float maxHeight = 450f;
    public float updateSenstivity = 0.5f;
    public Color visualizerColor = Color.gray;

    [Space(15)]
    public AudioClip audioClip;
    public bool loop = true;

    [Space(15), Range (64, 8192)]
    public int visualizerSimples = 64;

    private AudioVisualizerObject[] visualizerObjects;
    private AudioSource audioSource;
    private void Start()
    {
        visualizerObjects = GetComponentsInChildren<AudioVisualizerObject>();
        

        for (int i = 0; i < visualizerObjects.Length; i++)
        {
            visualizerObjects[i].GetComponent<Image>().color = visualizerColor;
        }

        if (!audioClip)
        {
            return;
        }

        audioSource = new GameObject("AudioSource").AddComponent<AudioSource>();
        audioSource.loop = loop;
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    private void Update()
    {
        float[] spectrumData = audioSource.GetSpectrumData(visualizerSimples, 0, FFTWindow.Rectangular);

        for (int i = 0; i < visualizerObjects.Length; i++)
        {
            Vector2 newSize = visualizerObjects[i].GetComponent<RectTransform>().rect.size;
            newSize.y = Mathf.Clamp(Mathf.Lerp(newSize.y, minHeight + (spectrumData[i] * (maxHeight - minHeight) * 5f), Time.deltaTime * updateSenstivity), minHeight, maxHeight);
            visualizerObjects[i].GetComponent<RectTransform>().sizeDelta = newSize;

            visualizerObjects[i].GetComponent<Image>().color = visualizerColor;
        }
    }




}
