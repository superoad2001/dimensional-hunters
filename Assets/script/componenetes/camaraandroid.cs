using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camaraandroid : MonoBehaviour
{
    private bool camavailable;
    private WebCamTexture backcam;
    private Texture deafaultbackground;

    public RawImage background;
    public AspectRatioFitter fit;
    private void Start()
    {
        deafaultbackground = background.texture;
        WebCamDevice[] devices = WebCamTexture.devices;

        if (devices.Length == 0)
        {
            Debug.Log("Camara No Detectada");
            camavailable = false;
            return;
        }
        for (int i = 0; i < devices.Length; i++)
        {
            if (!devices[i].isFrontFacing)
            {
               backcam = new WebCamTexture(devices[i].name, Screen.width, Screen.height); 
            }
        }
        if(backcam == null)
        {
            Debug.Log("Camara No Detectada");
            return;
        }
        backcam.Play();
        background.texture = backcam;

        camavailable = true;

    }
     private void Update()
    {
        if (!camavailable)
        return;

        float ratio = (float)backcam.width / (float)backcam.height;
        fit.aspectRatio = ratio;
        float scaleY = backcam.videoVerticallyMirrored ? -1f: 1f;
        background.rectTransform.localScale = new Vector3(1f, scaleY, 1f);


        int orient = -backcam.videoRotationAngle;
        background.rectTransform.localEulerAngles = new Vector3(0,0,orient);

    }
}
