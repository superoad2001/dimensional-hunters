using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cargaescena : MonoBehaviour
{
    public UnityEngine.Video.VideoPlayer videoPlayer;

    public UnityEngine.Video.VideoClip clip1;
    void Start()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(inv.datosserial.clip == 1)
        {videoPlayer.clip = clip1;}
        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
