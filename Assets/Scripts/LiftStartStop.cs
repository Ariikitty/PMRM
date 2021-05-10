using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftStartStop : MonoBehaviour
{
    public bool isPlaying = true;
    public Animator lift;

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            lift.speed = 1f;
        }
        if (!isPlaying)
        {
            lift.speed = 0f;
        }
    }

    public void Button()
    {
        isPlaying =! isPlaying;
    }
}
