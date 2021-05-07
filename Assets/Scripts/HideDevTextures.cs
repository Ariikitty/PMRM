using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideDevTextures : MonoBehaviour
{
    private MeshRenderer meshRender;
    void Start()
    {
        meshRender = GetComponent<MeshRenderer>();
        meshRender.enabled = false;
    }
}
