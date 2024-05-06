using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour
{

    [SerializeField]private RawImage img;
    private WebCamTexture webCamTexture;

    void Start()
    {
        webCamTexture = new WebCamTexture();
        if (!webCamTexture.isPlaying) webCamTexture.Play();
        img.texture = webCamTexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
