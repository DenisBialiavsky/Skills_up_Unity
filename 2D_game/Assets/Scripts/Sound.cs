using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private AudioSource AudioMenu;
    private float MusicVolume = 1.0f;

    void Start()
    {
        AudioMenu = GetComponent<AudioSource>();
    }

    void Update()
    {
        AudioMenu.volume = MusicVolume;
    }

    public void SetVolume(float vol)
    {
        MusicVolume = vol;
    }
}
