using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marble : MonoBehaviour 
{
    public GameObject marble;
    public AudioSource marbleImpactSound;
    public Material marbleInside;

    private void Start()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 2)
        {
            marbleImpactSound.Play();
        }
    }
}
