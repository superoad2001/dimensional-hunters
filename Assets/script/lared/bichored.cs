using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bichored : MonoBehaviour
{
    public bool cajon = false;
    public bool nobich = false;
    public bool cajoncomb = false;
    public bool inventario1 = true;

    public bool vez1;
    
    public bool bichoselec;

    //el hp para los terrenales
    //la mana para los viscosos
    //la fuerza para los de tipo fuerza
    //el gasto de mana para los aereos

    public List<string> catalogo= new List<string>();
    public float indexmax;


    public string[] ciuda;

    public List<string> bichos = new List<string>();

    public float hps;
    public float manas;
    public float manarecs;
    public float fuerzas;

    public int index;


    public bool der;
    public bool izq;
    public bool si;
    public bool no;

    public bool salir;
    public bool atras;
    public bool borrar;

    public bool tut;
    public bool tie;
    public bool vvez1;

    public Text bicho;
    public Text bicho1;
    public float temp = 0;


    public Text hpt;
    public Text mat;
    public Text rect;
    public Text nivelt;
    public Text danot;
    public Text bichoti;
    public Text elementot;
    public Text lib;

    public Text who;

    public GameObject bichom;
    public GameObject madcat;
    public GameObject shitfloor;
    public GameObject topo;
    public GameObject skybird;

    public GameObject madcat2;
    public GameObject shitfloor2;
    public GameObject topo2;
    public GameObject skybird2;

    public GameObject madcat3;
    public GameObject shitfloor3;
    public GameObject topo3;
    public GameObject skybird3;

    public Text tornetext;
    public int tutorial2;

    // Start is called before the first frame update

    public void _izq()
    {
        izq = true;
    }
     public void _der()
    {
        der = true;
    }
     public void _selec()
    {
        bichoselec = true;
    }
     public void _salir()
    {
        salir = true;
    }
     public void _atras()
    {
        atras = true;
    }
     public void _si()
    {
        si = true;
    }
    public void _no()
    {
        no = true;
    }









    void Start()
    {
        


        catalogo.Add( "skybird");
        catalogo.Add("topo topo");
        catalogo.Add("shitfloor");
        catalogo.Add("madcat");
        



    }
    public int i = 0; 

    // Update is called once per frame
    void Update()
    {

        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(cajoncomb == true)
        {
                bichos = inv.bichosmios;
                indexmax = bichos.Count;
                if(vez1 == false)
                {modelos();}
                vez1 = true;
                bicho.text = inv.name[i];
                bichoti.text ="RAZA "+ bichos[i];
                hpt.text = "VIT :"+inv.hp[i].ToString("F2");
                mat.text = "STAMINA :"+inv.mana[i].ToString("F2");
                rect.text = "REC :"+inv.manarec[i].ToString("F2");
                danot.text = "FUE :"+inv.fuerza[i].ToString("F2");
                elementot.text = "ELEM : "+inv.elemento[i];
                nivelt.text = "NIVEL : "+inv.nivel[i];
                who.text = "ELIGE TU HEROE";
                if(bichoselec == true && temp > 0.3f)
                {
                PlayerPrefs.SetFloat("hps", inv.hp[i]);
                PlayerPrefs.SetFloat("manas", inv.mana[i]);
                PlayerPrefs.SetFloat("manarecs",inv.manarec[i]);
                PlayerPrefs.SetFloat("fuerzas",inv.fuerza[i]);
                PlayerPrefs.SetString("names", inv.name[i]);
                PlayerPrefs.SetString("bichosh", bichos[i]);
                PlayerPrefs.SetFloat("nivelss", inv.nivel[i]);
                PlayerPrefs.SetFloat("selec", i);
                cajon = false;
                temp = 0;
                SceneManager.LoadScene("mundored");
                }
        
            if (izq == true && i > 0 && temp > 0.3f)
            {
                i--;
                temp = 0;
                modelos();
            }
            if (der == true && i < indexmax - 1 && temp > 0.3f)
            {
                i++;
                temp = 0;
                modelos();
            }
        }
        if (temp < 15)
        {temp += 1 * Time.deltaTime;}
        bichoselec = false;
        izq = false;
        der = false;
        salir = false;
        atras = false;
        borrar = false;
        si = false;
        no = false;

    }
    public void modelos()
    {
        if(bichos[i] == "madcat")
        {
            bichom.SetActive(false);
            bichom = madcat;
        }
    
        if(bichos[i] == "shitfloor")
        {
            bichom.SetActive(false);
            bichom = shitfloor;
            
        }
        
        if(bichos[i] == "topo topo")
        {
            bichom.SetActive(false);
            bichom = topo;
        }
        
        if(bichos[i] == "skybird")
        {
            bichom.SetActive(false);
            bichom = skybird;
        }






        if(bichos[i] == "happycat")
        {
            bichom.SetActive(false);
            bichom = madcat2;
        }
    
        if(bichos[i] == "shitplus")
        {
            bichom.SetActive(false);
            bichom = shitfloor2;
            
        }
        
        if(bichos[i] == "toto topo")
        {
            bichom.SetActive(false);
            bichom = topo2;
        }
        
        if(bichos[i] == "sunbird")
        {
            bichom.SetActive(false);
            bichom = skybird2;
        }



        if(bichos[i] == "crazycat")
        {
            bichom.SetActive(false);
            bichom = madcat3;
        }
    
        if(bichos[i] == "shitplusplus")
        {
            bichom.SetActive(false);
            bichom = shitfloor3;
            
        }
        
        if(bichos[i] == "poro topo")
        {
            bichom.SetActive(false);
            bichom = topo3;
        }
        
        if(bichos[i] == "moonbird")
        {
            bichom.SetActive(false);
            bichom = skybird3;
        }
        bichom.SetActive(true);
    }
}
