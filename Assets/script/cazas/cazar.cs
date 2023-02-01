using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class cazar : MonoBehaviour
{
    public ARSession arSession;
    public float iniciotem = 0;
    //cuando comienzas hay un solido negro que tapa la carga del nivel
    public GameObject negro;
    void Start()
    {
        

        //resetea el espacio de juego entre sesiones asi no se guarada la posicion cuando cambias de nivel
        arSession.Reset();
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
            SceneManager.LoadScene("esccat");
        }
        if (col.gameObject.tag == "shitfloor")
        {
            SceneManager.LoadScene("escshit");
        }
        if (col.gameObject.tag == "topo")
        {
            SceneManager.LoadScene("esctopo");
        }
        if (col.gameObject.tag == "skybird")
        {
            SceneManager.LoadScene("escsky");
        }
    }
}
