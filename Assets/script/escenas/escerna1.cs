using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;
using YoutubePlayer.Components;

public class escerna1 : MonoBehaviour
{
    public VideoPlayer video;
    public string url;
    public float temp;
    public float max;

    public string escena;

    public Text con1;

    public Text con2;

    public UnityEngine.Video.VideoPlayer videoPlayer;

    // Start is called before the first frame update
    async void Start()
    {
        con1.text = "cargando";
        con2.text = "";
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        InvidiousVideoPlayer url = UnityEngine.Object.FindObjectOfType<InvidiousVideoPlayer>();
        if(inv.datosserial.clip == 0)
        {url.VideoId = "MsJ9jGQysx8";}
        if(inv.datosserial.clip == 1)
        {url.VideoId = "MsJ9jGQysx8";}
        await url.PlayVideoAsync();

        
        
        //video.url = "https://drive.google.com/uc?export=download&id="+url;
    }
    void Awake()
    {
        
    }
    public void saltar()
    {
        SceneManager.LoadScene(escena);
    }

    // Update is called once per frame
    void Update()
    {
        temp += 1 * Time.deltaTime;
        if(temp >= 10)
        {
            con1.text = "sin conexion";
            con2.text = "no puedes ver esta cinematica sin conexion a internet";
        }
        if(temp >= 15)
        {
            if(!videoPlayer.isPlaying)
            {
                SceneManager.LoadScene(escena);
            }
        }
    }
 

    
}
