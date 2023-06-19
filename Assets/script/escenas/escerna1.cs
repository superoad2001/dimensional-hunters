using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class escerna1 : MonoBehaviour
{
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
        if (temp >= max + 1)
        {SceneManager.LoadScene(escena);}
        if(temp >= 10)
        {
            con1.text = "sin conexion";
            con2.text = "no puedes ver esta cinematica sin conexion a internet";
        }
    }
 

    
}
