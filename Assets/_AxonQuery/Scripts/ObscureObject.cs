using UnityEngine;

public class ObscureObject : MonoBehaviour
{
    private void Start()
    {
        var renders = GetComponentsInChildren<Renderer>();
        foreach (var rend in renders) rend.material.renderQueue = 2002;
    }
}