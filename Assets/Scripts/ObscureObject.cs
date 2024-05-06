using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObscureObject : MonoBehaviour
{
    void Start()
    {
        var renders = GetComponentsInChildren<Renderer>();
        foreach (var renderer in renders)
        {
            renderer.material.renderQueue = 2002; // set their renderQueue
        }
    }
}
