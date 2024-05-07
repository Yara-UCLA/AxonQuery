using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour
{

    [SerializeField]private RawImage img;
    private WebCamTexture webCamTexture;

    void Start()
    {
        webCamTexture = new WebCamTexture();
        webCamTexture.requestedWidth = 1280;
        webCamTexture.requestedFPS = 60;
        webCamTexture.requestedHeight = 720;
        if (!webCamTexture.isPlaying) webCamTexture.Play();
        img.texture = webCamTexture;
    }
}
