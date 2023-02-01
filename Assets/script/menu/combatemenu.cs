using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class combatemenu : MonoBehaviour
{
    public bool cajon = false;
    public bool nobich = false;
    public bool cajoncomb = false;
    public bool inventario1 = true;

    public bool vez1;
    
    public bool bichoselec;
    public bool cajonentr;
    public bool actentre;

    public List<string> name = new List<string>();
    public List<float> hp = new List<float>();
    public List<float> mana = new List<float>();
    public List<float> manarec = new List<float>();
    public List<float> fuerza = new List<float>();
    public List<string> elemento = new List<string>();
    public List<float> nivel = new List<float>();

    //el hp para los terrenales
    //la mana para los viscosos
    //la fuerza para los de tipo fuerza
    //el gasto de mana para los aereos

    public string[] namebarcelona;
    public List<string> catalogo= new List<string>();
    public List<string> bichosmios = new List<string>();
    public float indexmax;


    public float[] hpbarcelona;
    public float[] manabarcelona;
    public float[] manarecbarcelona;
    public float[] fuerzabarcelona;
    public string[] elementobarcelona;
    public float[] nivelbarcelona;
    public List<string> bichosbarcelona = new List<string>();

    public string[] ciuda;

    public List<string> bichos = new List<string>();

    public float hps;
    public float manas;
    public float manarecs;
    public float fuerzas;

    public int index;
    public bool actbarcelona;
    public bool actheroe;
    public bool actnobichos;
    public bool actc;
    public bool acta;

    public bool cajonbarcelona;

    public bool der;
    public bool izq;
    public bool si;
    public bool no;

    public bool salir;
    public bool atras;
    public bool borrar;
    public bool ciudades;
    public bool ciudades1;
    public bool actnobichos2;
    public bool nobich2;

    public bool tut;
    public bool tie;

    public GameObject elemento_;
    public GameObject elemt;
    public GameObject ciu;
    public GameObject nobichos;
    public GameObject botlib;
    public GameObject bichno;

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
    public Text ciudatext;
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

    public void _cajon()
    {
        actc = true;
    }
    public void _cajoncomb()
    {
        ciudades = true;
    }
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
    public void _borrar()
    {
        borrar = true;
    }
     public void _si()
    {
        si = true;
    }
    public void _no()
    {
        no = true;
    }
    public void _entr()
    {
        actentre = true;
    }
    public void _tut()
    {
        SceneManager.LoadScene("tutorial");
    }
    public void _mision()
    {
        SceneManager.LoadScene("mision");
    }








    void Start()
    {

        tutorial2 = PlayerPrefs.GetInt("tutorial2",0);
        if(tutorial2 == 0)
        {tornetext.text = "bloqueado";}

        ciuda = new string[6];


        ciuda[0] = "barcelona";
        ciuda[1] = "paris";
        ciuda[2] = "nueva york";
        ciuda[3] = "pekin";
        ciuda[4] = "mexico";
        ciuda[5] = "londres";




        namebarcelona = new string[6];
        hpbarcelona = new float[6];
        manabarcelona = new float[6];
        manarecbarcelona = new float[6];
        fuerzabarcelona = new float[6];
        elementobarcelona = new string[6];
        nivelbarcelona = new float[6];

        
        


        catalogo.Add( "skybird");
        catalogo.Add("topo topo");
        catalogo.Add("shitfloor");
        catalogo.Add("madcat");
        


        namebarcelona[0] = "paco";
        hpbarcelona[0] = 100;
        manabarcelona[0] = 60;
        manarecbarcelona[0] = 0.5f;
        fuerzabarcelona[0] = 0.8f;
        nivelbarcelona[0] = 1;
        elementobarcelona[0] = "terreno";
        bichosbarcelona.Add( "");
        bichosbarcelona[0] = catalogo[3];


        namebarcelona[1] = "jaume";
        hpbarcelona[1] = 60;
        manabarcelona[1] = 100;
        manarecbarcelona[1] = 0.3f;
        fuerzabarcelona[1] = 0.8f;
        elementobarcelona[1] = "viscoso";
        nivelbarcelona[1] = 1;
        bichosbarcelona.Add( "");
        bichosbarcelona[1] = catalogo[2];


        namebarcelona[2] = "agusti";
        hpbarcelona[2] = 80;
        manabarcelona[2] = 70;
        manarecbarcelona[2] = 0.4f;
        fuerzabarcelona[2] = 1f;
        elementobarcelona[2] = "fuerza";
        nivelbarcelona[2] = 2;
        bichosbarcelona.Add( "");
        bichosbarcelona[2] = catalogo[1];


        namebarcelona[3] = "enric";
        hpbarcelona[3] = 120;
        manabarcelona[3] = 80;
        manarecbarcelona[3] = 0.7f;
        fuerzabarcelona[3] = 0.7f;
        elementobarcelona[3] = "aereo";
        nivelbarcelona[3] = 3;
        bichosbarcelona.Add( "");
        bichosbarcelona[3] = catalogo[0];

        namebarcelona[4] = "josep";
        hpbarcelona[4] = 100;
        manabarcelona[4] = 110;
        manarecbarcelona[4] = 0.4f;
        fuerzabarcelona[4] = 1.1f;
        elementobarcelona[4] = "fuerza";
        nivelbarcelona[4] = 5;
        bichosbarcelona.Add( "");
        bichosbarcelona[4] = catalogo[1];


        namebarcelona[5] = "maria";
        hpbarcelona[5] = 130;
        manabarcelona[5] = 100;
        manarecbarcelona[5] = 0.8f;
        fuerzabarcelona[5] = 1f;
        elementobarcelona[5] = "terreno";
        nivelbarcelona[5] = 5;
        bichosbarcelona.Add( "");
        bichosbarcelona[5] = catalogo[3];

    }
    public int i = 1; 

    // Update is called once per frame
    void Update()
    {

        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(inventario1 == true && atras == true)
        {SceneManager.LoadScene("seleccion");}
        if (actc == true)
        {
            if (inv.name.Count == 0)
            {actnobichos2 = true;}
            inventario1 = false;
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(true);
            ciu.gameObject.SetActive(false);
            nobichos.gameObject.SetActive(false);
            botlib.gameObject.SetActive(false);
            bichno.gameObject.SetActive(false);
            bicho = bicho1;
            i = 0;
            cajonbarcelona = false;
            cajoncomb = false;
            acta = false;
            ciudades1 = false;
            cajon = true;
            actc = false;
            actheroe = false;
            nobich = false;
            nobich2 = false;
            
            vez1 = false;
            
            
            
        }
        if (actnobichos == true)
        {
            inventario1 = false;
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(false);
            ciu.gameObject.SetActive(false);
            nobichos.gameObject.SetActive(true);
            botlib.gameObject.SetActive(false);
            bichno.gameObject.SetActive(false);
            bicho = bicho1;
            cajonbarcelona = false;
            cajoncomb = false;
            acta = false;
            ciudades1 = false;
            cajon = false;
            actc = false;
            actheroe = false;
            nobich = true;
            nobich2 = false;
            actnobichos = false;
            
            
            
        }
        if (acta == true)
        {
            inventario1 = true;
            elemento_.gameObject.SetActive(true);
            elemt.gameObject.SetActive(false);
            ciu.gameObject.SetActive(false);
            nobichos.gameObject.SetActive(false);
            botlib.gameObject.SetActive(false);
            bichno.gameObject.SetActive(false);
            cajon = false;
            cajonbarcelona = false;
            cajoncomb = false;
            acta = false;
            ciudades1 = false;
            actheroe = false;
            bichom.SetActive(false);
            actentre = false;
            cajonentr = false;
            
            
            
        }
        if (actbarcelona == true)
        {
            inventario1 = false;
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(true);
            ciu.gameObject.SetActive(false);
            nobichos.gameObject.SetActive(false);
            botlib.gameObject.SetActive(false);
            bichno.gameObject.SetActive(false);
            bicho = bicho1;
            i = 0;
            cajon = false;
            cajoncomb = false;
            acta = false;
            ciudades1 = false;
            cajonbarcelona = true;
            actbarcelona = false;
            actheroe = false;
            vez1 = false;
            actentre = false;
            
            
            
        }
        if (actheroe == true)
        {
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(true);
            ciu.gameObject.SetActive(false);
            nobichos.gameObject.SetActive(false);
            botlib.gameObject.SetActive(false);
            bichno.gameObject.SetActive(false);
            inventario1 = false;
            bicho = bicho1;
            i = 0;
            cajon = false;
            cajonbarcelona = false;
            cajoncomb = false;
            acta = false;
            ciudades1 = false;
            cajoncomb = true;
            actheroe = false;
            vez1 = false;
            actentre = false;
            
            
            
        }
        if (actentre == true)
        {
            if (inv.name.Count == 0)
            {actnobichos2 = true;}
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(true);
            ciu.gameObject.SetActive(false);
            nobichos.gameObject.SetActive(false);
            botlib.gameObject.SetActive(false);
            bichno.gameObject.SetActive(false);
            inventario1 = false;
            bicho = bicho1;
            i = 0;
            cajon = false;
            cajonbarcelona = false;
            cajoncomb = false;
            acta = false;
            ciudades1 = false;
            cajoncomb = false;
            actheroe = false;
            vez1 = false;
            actentre = false;
            cajonentr = true;
            
            
            
            
        }
        if (ciudades == true)
        {
            if (inv.name.Count == 0)
            {actnobichos2 = true;}
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(false);
            ciu.gameObject.SetActive(true);
            nobichos.gameObject.SetActive(false);
            botlib.gameObject.SetActive(false);
            bichno.gameObject.SetActive(false);
            inventario1 = false;
            cajon = false;
            cajonbarcelona = false;
            cajoncomb = false;
            acta = false;
            ciudades1 = false;
            ciudades1 = true;
            ciudades = false;
            actheroe = false;
            i = 0;
            
            
            
            
        }
        if (actnobichos2 == true)
        {
            inventario1 = false;
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(false);
            ciu.gameObject.SetActive(false);
            nobichos.gameObject.SetActive(false);
            botlib.gameObject.SetActive(false);
            bichno.gameObject.SetActive(true);
            bicho = bicho1;
            cajonbarcelona = false;
            cajoncomb = false;
            acta = false;
            ciudades1 = false;
            cajon = false;
            actc = false;
            actheroe = false;
            nobich = false;
            nobich2 = true;
            actnobichos2 = false;
            cajonentr = false;
            
            
            
        }
        if(cajon == true)
        {
                botlib.gameObject.SetActive(true);
                
                bichos = inv.bichosmios;
                if(vez1 == false)
                {modelos();}
                vez1 = true;
                indexmax = bichos.Count;
                if(atras == true)
                {acta = true;}
                bicho.text = inv.name[i];
                bichoti.text ="RAZA "+ bichos[i];
                hpt.text = "VIT :"+inv.hp[i].ToString("F2");
                mat.text = "STAMINA :"+inv.mana[i].ToString("F2");
                rect.text = "REC :"+inv.manarec[i].ToString("F2");
                danot.text = "FUE :"+inv.fuerza[i].ToString("F2");
                elementot.text = "ELEM : "+inv.elemento[i];
                nivelt.text = "NIVEL : "+inv.nivel[i];
                who.text = "TUS HEROES";
                if(borrar == true && temp > 0.3f)
                {
                    actnobichos = true;
                
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
            if (inv.name.Count == 0)
            {actnobichos2 = true;}
        }
        if(nobich == true)
        {

            lib.text = "DESEAS LIBERAR A "+inv.name[i];
            if(si == true)
            {
                inv.o = i;
                actc = true;
                inv._borrar();
                i--;
            }
            if(no == true)
            {
                actc = true;
            }
            if (inv.name.Count == 0)
            {actnobichos2 = true;}
        }
        if(nobich2 == true)
        {

            if(no == true)
            {
                acta = true;
            }
        }
        if(cajoncomb == true)
        {
                bichos = inv.bichosmios;
                indexmax = bichos.Count;
                if(vez1 == false)
                {modelos();}
                vez1 = true;
                if(atras == true)
                {
                    acta = true;
                    PlayerPrefs.SetInt("jefe1",0);
                }
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
                SceneManager.LoadScene("combate");
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
        if(cajonentr == true)
        {
                bichos = inv.bichosmios;
                indexmax = bichos.Count;
                if(atras == true)
                {acta = true;}
                if(vez1 == false)
                {modelos();}
                vez1 = true;
                if(atras == true)
                {acta = true;}
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
                SceneManager.LoadScene("entrenamiento");
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
        if(cajonbarcelona == true)
        {
                bichos = bichosbarcelona;
                if(atras == true)
                {
                    acta = true;
                }
                if(vez1 == false)
                {modelos();}
                vez1 = true;
                bicho.text = namebarcelona[i];
                bichoti.text ="RAZA "+ bichos[i];
                hpt.text = "VIT :"+(float)hpbarcelona[i];
                mat.text = "STAMINA :"+(float)manabarcelona[i];
                rect.text = "REC :"+(float)manarecbarcelona[i];
                danot.text = "FUE :"+(float)fuerzabarcelona[i];
                elementot.text = "ELEM : "+elementobarcelona[i];
                nivelt.text = "NIVEL : "+nivelbarcelona[i];
                who.text = "QUIEN ES TU ENEMIGO ?";
                if(bichoselec == true && temp > 0.3f)
                {
                PlayerPrefs.SetFloat("hpene", hpbarcelona[i]);
                PlayerPrefs.SetFloat("manaene", manabarcelona[i]);
                PlayerPrefs.SetFloat("manarecene", manarecbarcelona[i]);
                PlayerPrefs.SetFloat("fuerzaene", fuerzabarcelona[i]);
                PlayerPrefs.SetString("tipoene", bichosbarcelona[i]);
                PlayerPrefs.SetString("nameene", namebarcelona[i]);
                PlayerPrefs.SetFloat("nivelg", nivelbarcelona[i]);
                PlayerPrefs.SetString("bichosene", bichos[i]);
                if(i == 3)
                {PlayerPrefs.SetInt("jefe1",1);}
                actheroe = true;
                }
        
            if (izq == true && i > 0 && temp > 0.3f)
            {
                i--;
                temp = 0;
                modelos();
            }
            if (der == true && i < 5 && temp > 0.3f)
            {
                i++;
                temp = 0;
                modelos();
            }
        }
        if(ciudades1 == true)
        {
                bichom.SetActive(false);
                if(atras == true)
                {acta = true;}
                ciudatext.text = ciuda[i];
                if(bichoselec == true && temp > 0.3f)
                {
                    if(i == 0)
                    {
                        actbarcelona = true;
                    }
                }
        
            if (izq == true && i > 0 && temp > 0.3f)
            {
                i--;
                temp = 0;
            }
            if (der == true && i < 6 && temp > 0.3f)
            {
                i++;
                temp = 0;
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
