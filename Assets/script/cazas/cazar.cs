using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class cazar : MonoBehaviour
{
    public GameObject arSession;
    public float iniciotem = 0;
    //cuando comienzas hay un solido negro que tapa la carga del nivel
    public GameObject negro;
    public string plat;

    public GameObject cam;
    void Awake()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        plat = inv.datosserial.plat;
        if(plat == "arcore")
        {
    
        }
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
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        //1
        if (col.gameObject.tag == "madcat")
        {
            inv.datosserial.bichocaza ="madcat";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "shitfloor")
        {
            inv.datosserial.bichocaza ="shitfloor";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "topo")
        {
            inv.datosserial.bichocaza ="topo";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "skybird")
        {
            inv.datosserial.bichocaza ="skybird";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }


        //2
        if (col.gameObject.tag == "tufo")
        {
            inv.datosserial.bichocaza ="tufo";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "roboerto")
        {
            inv.datosserial.bichocaza ="roboerto";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "darkknight")
        {
            inv.datosserial.bichocaza ="darkknight";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "bee")
        {
            inv.datosserial.bichocaza ="bee";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }

        //3
        if (col.gameObject.tag == "fenix")
        {
            inv.datosserial.bichocaza ="fenix";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "dogtable")
        {
            inv.datosserial.bichocaza ="dogtable";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "gunman")
        {
            inv.datosserial.bichocaza ="gunman";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "antidog")
        {
            inv.datosserial.bichocaza ="antidog";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        //4
        if (col.gameObject.tag == "ant")
        {
            inv.datosserial.bichocaza ="ant";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "trashrat")
        {
            inv.datosserial.bichocaza ="trashrat";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "heavydevil")
        {
            inv.datosserial.bichocaza ="heavydevil";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "cazafantasmas")
        {
            inv.datosserial.bichocaza ="cazafantasmas";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        //5
        if (col.gameObject.tag == "polloavion")
        {
            inv.datosserial.bichocaza ="polloavion";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "kingslug")
        {
            inv.datosserial.bichocaza ="kingslug";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "sharkman")
        {
            inv.datosserial.bichocaza ="sharkman";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "craneovil")
        {
            inv.datosserial.bichocaza ="craneovil";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }

        //1
        if (col.gameObject.tag == "spider")
        {
            inv.datosserial.bichocaza ="spider";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "vivodado")
        {
            inv.datosserial.bichocaza ="vivodado";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "algosaurio")
        {
            inv.datosserial.bichocaza ="algosaurio";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "flyera")
        {
            inv.datosserial.bichocaza ="flyera";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }


        //2
        if (col.gameObject.tag == "pinguino")
        {
            inv.datosserial.bichocaza ="pinguino";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "dragonron")
        {
            inv.datosserial.bichocaza ="dragonronr";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "kraken")
        {
            inv.datosserial.bichocaza ="kraken";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "lizardo")
        {
            inv.datosserial.bichocaza ="lizardo";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }

        //3
        if (col.gameObject.tag == "flanerio")
        {
            inv.datosserial.bichocaza ="flanerio";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "ghost")
        {
            inv.datosserial.bichocaza ="ghost";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "friend")
        {
            inv.datosserial.bichocaza ="friend";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "rosedragon")
        {
            inv.datosserial.bichocaza ="rosedragon";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        //4
        if (col.gameObject.tag == "trepillo")
        {
            inv.datosserial.bichocaza ="trepillo";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "elephant")
        {
            inv.datosserial.bichocaza ="elephant";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "rabmon")
        {
            inv.datosserial.bichocaza ="rabmon";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "bigfat")
        {
            inv.datosserial.bichocaza ="bigfat";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        //5
        if (col.gameObject.tag == "mirror")
        {
            inv.datosserial.bichocaza ="mirror";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "livedish")
        {
            inv.datosserial.bichocaza ="livedish";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "pesadilla")
        {
            inv.datosserial.bichocaza ="pesadilla";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "kingdragon")
        {
            inv.datosserial.bichocaza ="kingdragon";
            inv.guardar();
            SceneManager.LoadScene("combatecaza");
        }
    }
}
