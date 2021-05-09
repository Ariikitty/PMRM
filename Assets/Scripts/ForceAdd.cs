using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceAdd : MonoBehaviour
{
    public float xForce;
    public float yForce;
    public float zForce;
    public bool disableGravity;
    private bool gravitySwitch = true;

    // Disables gravity on all rigidbodies entering this collider.
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            if (disableGravity)
            {
                other.attachedRigidbody.useGravity = false;
                gravitySwitch = false;
            }
            other.attachedRigidbody.AddForce(xForce, yForce, zForce);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody)
        {
            if (!gravitySwitch)
            {
                other.attachedRigidbody.useGravity = true;
                gravitySwitch = false;
            }
        }
    }
}
