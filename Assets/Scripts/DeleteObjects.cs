using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObjects : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject destoryObject = collision.gameObject;
        Destroy(destoryObject);
    }
}
