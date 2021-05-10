using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStartStop : MonoBehaviour
{
    public bool isPlaying = true;
    public AudioSource music;

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            music.UnPause();
        }
        if (!isPlaying)
        {
            music.Pause();
        }
    }

    public void Button()
    {
        isPlaying = !isPlaying;
    }
}
