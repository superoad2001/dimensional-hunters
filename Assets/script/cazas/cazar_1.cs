using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class cazar_1 : MonoBehaviour
{
    public ARSession arSession;
    public float iniciotem = 0;
    //cuando comienzas hay un solido negro que tapa la carga del nivel
    public GameObject negro;
    public GameObject cam;
    void Start()
    {
        
        cam.transform.position = new Vector3(0,0,0);
        //resetea el espacio de juego entre sesiones asi no se guarada la posicion cuando cambias de nivel
    }
    
    public void _salir()
    {
        SceneManager.LoadScene("seleccion");
    }
    void Update()
    {

        // a los 2 segundo el solido negro desaparece
        if (iniciotem > 2)
        {
            negro.gameObject.SetActive(false);

        }
        //temporizador hasta 15 para no sobrecargar la cpu
        if(iniciotem < 15)
        {iniciotem += 1 * Time.deltaTime;}

    }
    public void OnTriggerEnter(Collider col)
    {
        // si colisionas con objetos de este tipo eres teletransportado a su nivel
       if (col.gameObject.tag == "madcat")
        {
            SceneManager.LoadScene("madcatev2");
        }
        if (col.gameObject.tag == "shitfloor")
        {
            SceneManager.LoadScene("shitfloorev2");
        }
        if (col.gameObject.tag == "topo")
        {
            SceneManager.LoadScene("topoev2");
        }
        if (col.gameObject.tag == "skybird")
        {
            SceneManager.LoadScene("skybirdev2");
        }
    }
}
