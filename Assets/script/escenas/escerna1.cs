using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class escerna1 : MonoBehaviour
{
    public VideoPlayer video;
    public string url;
    public float temp;
    public float max;

    public string escena;

    public Text con1;

    public Text con2;

    // Start is called before the first frame update
    void Start()
    {
        con1.text = "cargando";
        con2.text = "";
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        
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
        if (temp >= max + 5)
        {SceneManager.LoadScene(escena);}
        if(temp >= 10)
        {
            con1.text = "sin conexion";
            con2.text = "no puedes ver esta cinematica sin conexion a internet";
        }
    }
 

    
}
