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
        
        if (iniciotem > 1 && iniciotem < 2)
        {
            arSession.Reset ();

        }
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
        //1
        if (col.gameObject.tag == "madcat")
        {
            PlayerPrefs.SetString("bichocaza", "madcat");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "shitfloor")
        {
            PlayerPrefs.SetString("bichocaza", "shitfloor");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "topo")
        {
            PlayerPrefs.SetString("bichocaza", "topo");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "skybird")
        {
            PlayerPrefs.SetString("bichocaza", "skybird");
            SceneManager.LoadScene("combatecaza");
        }


        //2
        if (col.gameObject.tag == "tufo")
        {
            PlayerPrefs.SetString("bichocaza", "tufo");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "roboerto")
        {
            PlayerPrefs.SetString("bichocaza", "roboerto");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "darkknight")
        {
            PlayerPrefs.SetString("bichocaza", "darkknight");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "bee")
        {
            PlayerPrefs.SetString("bichocaza", "bee");
            SceneManager.LoadScene("combatecaza");
        }

        //3
        if (col.gameObject.tag == "fenix")
        {
            PlayerPrefs.SetString("bichocaza", "fenix");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "dogtable")
        {
            PlayerPrefs.SetString("bichocaza", "dogtable");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "gunman")
        {
            PlayerPrefs.SetString("bichocaza", "gunman");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "antidog")
        {
            PlayerPrefs.SetString("bichocaza", "antidog");
            SceneManager.LoadScene("combatecaza");
        }
        //4
        if (col.gameObject.tag == "ant")
        {
            PlayerPrefs.SetString("bichocaza", "ant");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "trashrat")
        {
            PlayerPrefs.SetString("bichocaza", "trashrat");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "heavydevil")
        {
            PlayerPrefs.SetString("bichocaza", "heavydevil");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "cazafantasmas")
        {
            PlayerPrefs.SetString("bichocaza", "cazafantasmas");
            SceneManager.LoadScene("combatecaza");
        }
        //5
        if (col.gameObject.tag == "polloavion")
        {
            PlayerPrefs.SetString("bichocaza", "polloavion");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "kingslug")
        {
            PlayerPrefs.SetString("bichocaza", "kingslug");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "sharkman")
        {
            PlayerPrefs.SetString("bichocaza", "sharkman");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "craneovil")
        {
            PlayerPrefs.SetString("bichocaza", "craneovil");
            SceneManager.LoadScene("combatecaza");
        }

        //1
        if (col.gameObject.tag == "spider")
        {
            PlayerPrefs.SetString("bichocaza", "spider");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "vivodado")
        {
            PlayerPrefs.SetString("bichocaza", "vivodado");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "algosaurio")
        {
            PlayerPrefs.SetString("bichocaza", "algosaurio");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "flyera")
        {
            PlayerPrefs.SetString("bichocaza", "flyera");
            SceneManager.LoadScene("combatecaza");
        }


        //2
        if (col.gameObject.tag == "pinguino")
        {
            PlayerPrefs.SetString("bichocaza", "pinguino");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "dragonron")
        {
            PlayerPrefs.SetString("bichocaza", "dragonronr");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "kraken")
        {
            PlayerPrefs.SetString("bichocaza", "kraken");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "lizardo")
        {
            PlayerPrefs.SetString("bichocaza", "lizardo");
            SceneManager.LoadScene("combatecaza");
        }

        //3
        if (col.gameObject.tag == "flanerio")
        {
            PlayerPrefs.SetString("bichocaza", "flanerio");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "ghost")
        {
            PlayerPrefs.SetString("bichocaza", "ghost");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "friend")
        {
            PlayerPrefs.SetString("bichocaza", "friend");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "rosedragon")
        {
            PlayerPrefs.SetString("bichocaza", "rosedragon");
            SceneManager.LoadScene("combatecaza");
        }
        //4
        if (col.gameObject.tag == "trepillo")
        {
            PlayerPrefs.SetString("bichocaza", "trepillo");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "elephant")
        {
            PlayerPrefs.SetString("bichocaza", "elephant");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "rabman")
        {
            PlayerPrefs.SetString("bichocaza", "rabman");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "bigfat")
        {
            PlayerPrefs.SetString("bichocaza", "bigfat");
            SceneManager.LoadScene("combatecaza");
        }
        //5
        if (col.gameObject.tag == "mirror")
        {
            PlayerPrefs.SetString("bichocaza", "mirror");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "livedish")
        {
            PlayerPrefs.SetString("bichocaza", "livedish");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "pesadilla")
        {
            PlayerPrefs.SetString("bichocaza", "pesadilla");
            SceneManager.LoadScene("combatecaza");
        }
        if (col.gameObject.tag == "kingdragon")
        {
            PlayerPrefs.SetString("bichocaza", "kingdragon");
            SceneManager.LoadScene("combatecaza");
        }
    }
}
