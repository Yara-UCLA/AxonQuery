using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour
{
    [SerializeField] private RawImage img;
    private WebCamTexture _webCamTexture;

    private void Start()
    {
        _webCamTexture = new WebCamTexture
        {
            requestedWidth = 1280,
            requestedFPS = 60,
            requestedHeight = 720
        };
        if (!_webCamTexture.isPlaying) _webCamTexture.Play();
        img.texture = _webCamTexture;
    }
}