using UnityEngine;

public class Marble : MonoBehaviour
{
    public GameObject marble;
    public AudioSource marbleImpactSound;
    public Material marbleInside;
    private float minPitch = 0.75f;
    private float maxPitch = 1f;


    private void Start()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 2)
        {
            marbleImpactSound.volume = collision.relativeVelocity.magnitude / 10f;
            marbleImpactSound.pitch = Random.Range(minPitch, maxPitch);
            Debug.Log("Volume: " + marbleImpactSound.volume + " Pitch: " + marbleImpactSound.pitch);
            marbleImpactSound.Play();
        }
    }
}