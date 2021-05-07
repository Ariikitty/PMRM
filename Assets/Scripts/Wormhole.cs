using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wormhole : MonoBehaviour
{
    public Transform wormholeExit;
    public GameObject marble;
    public Rigidbody marbleRB;

    public void Start()
    {
        marbleRB = marble.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        marbleRB.velocity = wormholeExit.transform.forward * marbleRB.velocity.magnitude;
        marble.transform.position = wormholeExit.transform.position;
    }
}
