using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGravStart : MonoBehaviour
{
    public float thrust;
    // Disables gravity on all rigidbodies entering this collider.
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            other.attachedRigidbody.useGravity = false;
            other.attachedRigidbody.AddForce(0, thrust, 0);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody)
        {
            other.attachedRigidbody.useGravity = true;
        }
    }
}
