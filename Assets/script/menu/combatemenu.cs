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
    public float[] rangobarcelona;
    public float[] clasebarcelona;
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

    public bool hist;

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
    public GameObject historiacaja;

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

    
    public GameObject ghost;
    public GameObject algosaurio;
    public GameObject bigfat;
    public GameObject cazafantasmas;

    public GameObject darkknight;
    public GameObject antidog;
    public GameObject pinguino;
    public GameObject craneovil;

    public GameObject dogtable;
    public GameObject bee;
    public GameObject elephant;
    public GameObject flyera;

    public GameObject friend;
    public GameObject gunman;
    public GameObject flanerio;
    public GameObject fenix;





    public GameObject kingdragon;
    public GameObject heavydevil;
    public GameObject kraken;
    public GameObject lizardo;

    public GameObject livedish;
    public GameObject pesadilla;
    public GameObject mirror;
    public GameObject rabmon;

    public GameObject ant;
    public GameObject kingslug;
    public GameObject rosedragon;
    public GameObject sharkman;

    public GameObject pollovion;
    public GameObject trepillo;
    public GameObject roboerto;
    public GameObject tufo;

    public GameObject trashrat;
    public GameObject spider;
    public GameObject vivodado;
    public GameObject dragonron;



    public Text tornetext;
    public int tutorial2;


    // Start is called before the first frame update

    public void _multi()
    {
       SceneManager.LoadScene("combatemenumulti");
    }
    public void _cajon()
    {
        actc = true;
    }
    public void _cajoncomb()
    {
        ciudades = true;
    }
    public void _hist()
    {
        hist = true;
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
        

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

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
        rangobarcelona = new float[6];
        clasebarcelona = new float[6];

        
        


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
        elementobarcelona[0] = "comun rango : 1";
        rangobarcelona[0] = 1;
        clasebarcelona[0] = 1;
        bichosbarcelona.Add( "");
        bichosbarcelona[0] = catalogo[3];


        namebarcelona[1] = "jaume";
        hpbarcelona[1] = 60;
        manabarcelona[1] = 100;
        manarecbarcelona[1] = 0.3f;
        fuerzabarcelona[1] = 0.8f;
        elementobarcelona[1] = "comun rango : 1";
        rangobarcelona[1] = 1;
        clasebarcelona[1] = 1;
        nivelbarcelona[1] = 1;
        bichosbarcelona.Add( "");
        bichosbarcelona[1] = catalogo[2];


        namebarcelona[2] = "agusti";
        hpbarcelona[2] = 80;
        manabarcelona[2] = 70;
        manarecbarcelona[2] = 0.4f;
        fuerzabarcelona[2] = 1f;
        elementobarcelona[2] = "comun rango : 1";
        rangobarcelona[2] = 1;
        clasebarcelona[2] = 1;
        nivelbarcelona[2] = 2;
        bichosbarcelona.Add( "");
        bichosbarcelona[2] = catalogo[1];


        namebarcelona[3] = "enric";
        hpbarcelona[3] = 120;
        manabarcelona[3] = 80;
        manarecbarcelona[3] = 0.7f;
        fuerzabarcelona[3] = 0.7f;
        elementobarcelona[3] = "comun rango : 1";
        rangobarcelona[3] = 1;
        clasebarcelona[3] = 1;
        nivelbarcelona[3] = 3;
        bichosbarcelona.Add( "");
        bichosbarcelona[3] = catalogo[0];

        namebarcelona[4] = "josep";
        hpbarcelona[4] = 100;
        manabarcelona[4] = 110;
        manarecbarcelona[4] = 0.4f;
        fuerzabarcelona[4] = 1.1f;
        elementobarcelona[4] = "comun rango : 1";
        rangobarcelona[4] = 1;
        clasebarcelona[4] = 1;
        nivelbarcelona[4] = 5;
        bichosbarcelona.Add( "");
        bichosbarcelona[4] = catalogo[1];


        namebarcelona[5] = "maria";
        hpbarcelona[5] = 130;
        manabarcelona[5] = 100;
        manarecbarcelona[5] = 0.8f;
        fuerzabarcelona[5] = 1f;
        elementobarcelona[5] = "comun rango : 1";
        rangobarcelona[5] = 1;
        clasebarcelona[5] = 1;
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
            if (inv.datosserial.name.Count == 0)
            {actnobichos2 = true;}
            inventario1 = false;
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(true);
            ciu.gameObject.SetActive(false);
            nobichos.gameObject.SetActive(false);
            botlib.gameObject.SetActive(false);
            bichno.gameObject.SetActive(false);
            historiacaja.gameObject.SetActive(true);
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
            historiacaja.gameObject.SetActive(false);
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
            historiacaja.gameObject.SetActive(false);
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
            historiacaja.gameObject.SetActive(false);
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
            historiacaja.gameObject.SetActive(false);
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
            if (inv.datosserial.name.Count == 0)
            {actnobichos2 = true;}
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(true);
            ciu.gameObject.SetActive(false);
            nobichos.gameObject.SetActive(false);
            botlib.gameObject.SetActive(false);
            bichno.gameObject.SetActive(false);
            historiacaja.gameObject.SetActive(false);
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
            if (inv.datosserial.name.Count == 0)
            {actnobichos2 = true;}
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(false);
            ciu.gameObject.SetActive(true);
            nobichos.gameObject.SetActive(false);
            botlib.gameObject.SetActive(false);
            bichno.gameObject.SetActive(false);
            historiacaja.gameObject.SetActive(false);
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
            historiacaja.gameObject.SetActive(false);
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
                
                bichos = inv.datosserial.bichosmios;
                if(vez1 == false)
                {
                    modelos();
                    colorbicho2 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho2>();
                    colorbicho.colorbcajon();
                }
                vez1 = true;
                indexmax = bichos.Count;
                if(atras == true)
                {acta = true;}
                bicho.text = inv.datosserial.name[i];
                bichoti.text ="RAZA "+ bichos[i];
                hpt.text = "VIT :"+inv.datosserial.hp[i].ToString("F2");
                mat.text = "STAMINA :"+inv.datosserial.mana[i].ToString("F2");
                rect.text = "REC :"+inv.datosserial.manarec[i].ToString("F2");
                danot.text = "FUE :"+inv.datosserial.fuerza[i].ToString("F2");
                elementot.text = "CAT : "+inv.datosserial.elemento[i];
                nivelt.text = "NIVEL : "+inv.datosserial.nivel[i];
                who.text = "TUS HEROES";
                if(borrar == true && temp > 0.3f)
                {
                    actnobichos = true;
                
                }
                if(hist == true && temp > 0.3f)
                {
                    if(bichos[i] == "madcat")
                    {SceneManager.LoadScene("escenamadcat");}
                    if(bichos[i] == "shitfloor")
                    {SceneManager.LoadScene("escenashitfloor");}
                    if(bichos[i] == "topo")
                    {SceneManager.LoadScene("escenatopo");}
                    if(bichos[i] == "skybird")
                    {SceneManager.LoadScene("escenaskybird");}
                    if(bichos[i] == "aghostin")
                    {}
                    if(bichos[i] == "algosaurio")
                    {}
                    if(bichos[i] == "bigfat")
                    {}
                    if(bichos[i] == "cazafantasmas")
                    {}
                    //3
                    if(bichos[i] == "darkknight")
                    {}
                    if(bichos[i] == "antidog")
                    {}
                    if(bichos[i] == "cyberpinguino")
                    {}
                    if(bichos[i] == "craneovil")
                    {}
                    //4
                    if(bichos[i] == "dogtable")
                    {}
                    if(bichos[i] == "beestosa")
                    {}
                    if(bichos[i] == "elephant")
                    {}
                    if(bichos[i] == "flyera")
                    {}
                    //5
                    if(bichos[i] == "friend")
                    {}
                    if(bichos[i] == "gunman")
                    {}
                    if(bichos[i] == "flanerio")
                    {}
                    if(bichos[i] == "fenix")
                    {}

                    //1
                    if(bichos[i] == "kingdragon")
                    {}
                    if(bichos[i] == "heavydevil")
                    {}
                    if(bichos[i] == "kraken")
                    {}
                    if(bichos[i] == "lizardo")
                    {}
                    //2
                    if(bichos[i] == "livedish")
                    {}
                    if(bichos[i] == "pesadilla")
                    {}
                    if(bichos[i] == "mirror")
                    {}
                    if(bichos[i] == "rabmon")
                    {}
                    //3
                    if(bichos[i] == "ant")
                    {}
                    if(bichos[i] == "kingslug")
                    {}
                    if(bichos[i] == "rosedragon")
                    {}
                    if(bichos[i] == "sharkman")
                    {}
                    //4
                    if(bichos[i] == "pollovion")
                    {}
                    if(bichos[i] == "trepillo")
                    {}
                    if(bichos[i] == "roboerto")
                    {}
                    if(bichos[i] == "tufo")
                    {}
                    //5
                    if(bichos[i] == "trashrat")
                    {}
                    if(bichos[i] == "spider")
                    {}
                    if(bichos[i] == "vivodado")
                    {}
                    if(bichos[i] == "dragonron")
                    {}

                }
            if (izq == true && i > 0 && temp > 0.3f)
            {
                i--;
                temp = 0;
                modelos();
                colorbicho2 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho2>();
                colorbicho.colorbcajon();
            }
            if (der == true && i < indexmax - 1 && temp > 0.3f)
            {
                i++;
                temp = 0;
                modelos();
                colorbicho2 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho2>();
                colorbicho.colorbcajon();
            }
            if (inv.datosserial.name.Count == 0)
            {actnobichos2 = true;}
        }
        if(nobich == true)
        {

            lib.text = "DESEAS LIBERAR A "+inv.datosserial.name[i];
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
            if (inv.datosserial.name.Count == 0)
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
                bichos = inv.datosserial.bichosmios;
                indexmax = bichos.Count;
                if(vez1 == false)
                {
                    modelos();
                    colorbicho2 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho2>();
                    colorbicho.colorbcajon();
                }
                vez1 = true;
                if(atras == true)
                {
                    acta = true;
                }
                bicho.text = inv.datosserial.name[i];
                bichoti.text ="RAZA "+ bichos[i];
                hpt.text = "VIT :"+inv.datosserial.hp[i].ToString("F2");
                mat.text = "STAMINA :"+inv.datosserial.mana[i].ToString("F2");
                rect.text = "REC :"+inv.datosserial.manarec[i].ToString("F2");
                danot.text = "FUE :"+inv.datosserial.fuerza[i].ToString("F2");
                elementot.text = "CAT : "+inv.datosserial.elemento[i];
                nivelt.text = "NIVEL : "+inv.datosserial.nivel[i];
                who.text = "ELIGE TU HEROE";
                if(bichoselec == true && temp > 0.3f)
                {
                inv.datosserial.hps = inv.datosserial.hp[i];
                inv.datosserial.manas = inv.datosserial.mana[i];
                inv.datosserial.manarecs = inv.datosserial.manarec[i];
                inv.datosserial.fuerzas = inv.datosserial.fuerza[i];
                inv.datosserial.names = inv.datosserial.name[i];
                inv.datosserial.razas = bichos[i];
                inv.datosserial.nivels = inv.datosserial.nivel[i];
                inv.datosserial.clases = inv.datosserial.clase[i];
                inv.datosserial.rangors = inv.datosserial.rango[i];
                inv.datosserial.varsel1 = i;
                inv.guardar();
                cajon = false;
                temp = 0;
                SceneManager.LoadScene("combate");
                }
        
            if (izq == true && i > 0 && temp > 0.3f)
            {
                i--;
                temp = 0;
                modelos();
                colorbicho2 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho2>();
                colorbicho.colorbcajon();
            }
            if (der == true && i < indexmax - 1 && temp > 0.3f)
            {
                i++;
                temp = 0;
                modelos();
                colorbicho2 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho2>();
                colorbicho.colorbcajon();
            }
        }
        if(cajonentr == true)
        {
                bichos = inv.datosserial.bichosmios;
                indexmax = bichos.Count;
                if(vez1 == false)
                {
                    modelos();
                    colorbicho2 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho2>();
                    colorbicho.colorbcajon();
                }
                vez1 = true;
                if(atras == true)
                {acta = true;}
                bicho.text = inv.datosserial.name[i];
                bichoti.text ="RAZA "+ bichos[i];
                hpt.text = "VIT :"+inv.datosserial.hp[i].ToString("F2");
                mat.text = "STAMINA :"+inv.datosserial.mana[i].ToString("F2");
                rect.text = "REC :"+inv.datosserial.manarec[i].ToString("F2");
                danot.text = "FUE :"+inv.datosserial.fuerza[i].ToString("F2");
                elementot.text = "CAT : "+inv.datosserial.elemento[i];
                nivelt.text = "NIVEL : "+inv.datosserial.nivel[i];
                who.text = "ELIGE TU HEROE";
                if(bichoselec == true && temp > 0.3f)
                {
                inv.datosserial.hps = inv.datosserial.hp[i];
                inv.datosserial.manas = inv.datosserial.mana[i];
                inv.datosserial.manarecs = inv.datosserial.manarec[i];
                inv.datosserial.fuerzas = inv.datosserial.fuerza[i];
                inv.datosserial.names = inv.datosserial.name[i];
                inv.datosserial.razas = bichos[i];
                inv.datosserial.nivels = inv.datosserial.nivel[i];
                inv.datosserial.clases = inv.datosserial.clase[i];
                inv.datosserial.rangors = inv.datosserial.rango[i];
                inv.datosserial.varsel1 = i;
                inv.guardar();
                cajon = false;
                temp = 0;
                SceneManager.LoadScene("entrenamiento");
                }
        
            if (izq == true && i > 0 && temp > 0.3f)
            {
                i--;
                temp = 0;
                modelos();
                colorbicho2 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho2>();
                colorbicho.colorbcajon();
            }
            if (der == true && i < indexmax - 1 && temp > 0.3f)
            {
                i++;
                temp = 0;
                modelos();
                colorbicho2 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho2>();
                colorbicho.colorbcajon();
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
                {
                    modelos();
                    colorbicho2 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho2>();
                    colorbicho.colorbbarcelona();
                }
                vez1 = true;
                bicho.text = namebarcelona[i];
                bichoti.text ="RAZA "+ bichosbarcelona[i];
                hpt.text = "VIT :"+(float)hpbarcelona[i];
                mat.text = "STAMINA :"+(float)manabarcelona[i];
                rect.text = "REC :"+(float)manarecbarcelona[i];
                danot.text = "FUE :"+(float)fuerzabarcelona[i];
                elementot.text = "CAT : "+elementobarcelona[i];
                nivelt.text = "NIVEL : "+nivelbarcelona[i];
                who.text = "QUIEN ES TU ENEMIGO ?";
                if(bichoselec == true && temp > 0.3f)
                {
                    
                inv.datosserial.hpene = hpbarcelona[i];
                inv.datosserial.manaene = manabarcelona[i];
                inv.datosserial.manarecene = manarecbarcelona[i];
                inv.datosserial.fuerzaene = fuerzabarcelona[i];
                inv.datosserial.nameene = namebarcelona[i];
                inv.datosserial.razaene =  bichosbarcelona[i];
                inv.datosserial.nivelene = (int)nivelbarcelona[i];
                inv.datosserial.claseene = clasebarcelona[i];
                inv.datosserial.rangoene = rangobarcelona[i];
                inv.guardar();

                actheroe = true;
                }
        
            if (izq == true && i > 0 && temp > 0.3f)
            {
                i--;
                temp = 0;
                modelos();
                colorbicho2 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho2>();
                colorbicho.colorbbarcelona();
            }
            if (der == true && i < 5 && temp > 0.3f)
            {
                i++;
                temp = 0;
                modelos();
                colorbicho2 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho2>();
                colorbicho.colorbbarcelona();
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
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
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
        if(bichos[i] == "aghostin")
        {
            bichom.SetActive(false);
            bichom = ghost;
        }
        if(bichos[i] == "algosaurio")
        {
            bichom.SetActive(false);
            bichom = algosaurio;
        }
        if(bichos[i] == "bigfat")
        {
            bichom.SetActive(false);
            bichom = bigfat;
        }
        if(bichos[i] == "cazafantasmas")
        {
            bichom.SetActive(false);
            bichom = cazafantasmas;
        }
        //3
        if(bichos[i] == "darkknight")
        {
            bichom.SetActive(false);
            bichom = darkknight;
        }
        if(bichos[i] == "antidog")
        {
            bichom.SetActive(false);
            bichom = skybird;
        }
        if(bichos[i] == "cyberpinguino")
        {
            bichom.SetActive(false);
            bichom = pinguino;
        }
        if(bichos[i] == "craneovil")
        {
            bichom.SetActive(false);
            bichom = craneovil;
        }
        //4
        if(bichos[i] == "dogtable")
        {
            bichom.SetActive(false);
            bichom = dogtable;
        }
        if(bichos[i] == "beestosa")
        {
            bichom.SetActive(false);
            bichom = bee;
        }
        if(bichos[i] == "elephant")
        {
            bichom.SetActive(false);
            bichom = elephant;
        }
        if(bichos[i] == "flyera")
        {
            bichom.SetActive(false);
            bichom = flyera;
        }
        //5
        if(bichos[i] == "friend")
        {
            bichom.SetActive(false);
            bichom = friend;
        }
        if(bichos[i] == "gunman")
        {
            bichom.SetActive(false);
            bichom = gunman;
        }
        if(bichos[i] == "flanerio")
        {
            bichom.SetActive(false);
            bichom = flanerio;
        }
        if(bichos[i] == "fenix")
        {
            bichom.SetActive(false);
            bichom = fenix;
        }

        //1
        if(bichos[i] == "kingdragon")
        {
            bichom.SetActive(false);
            bichom = kingdragon;
        }
        if(bichos[i] == "heavydevil")
        {
            bichom.SetActive(false);
            bichom = heavydevil;
        }
        if(bichos[i] == "kraken")
        {
            bichom.SetActive(false);
            bichom = kraken;
        }
        if(bichos[i] == "lizardo")
        {
            bichom.SetActive(false);
            bichom = lizardo;
        }
         //2
        if(bichos[i] == "livedish")
        {
            bichom.SetActive(false);
            bichom = livedish;
        }
        if(bichos[i] == "pesadilla")
        {
            bichom.SetActive(false);
            bichom = pesadilla;
        }
        if(bichos[i] == "mirror")
        {
            bichom.SetActive(false);
            bichom = mirror;
        }
        if(bichos[i] == "rabmon")
        {
            bichom.SetActive(false);
            bichom = rabmon;
        }
        //3
        if(bichos[i] == "ant")
        {
            bichom.SetActive(false);
            bichom = ant;
        }
        if(bichos[i] == "kingslug")
        {
            bichom.SetActive(false);
            bichom = kingdragon;
        }
        if(bichos[i] == "rosedragon")
        {
            bichom.SetActive(false);
            bichom = rosedragon;
        }
        if(bichos[i] == "sharkman")
        {
            bichom.SetActive(false);
            bichom = sharkman;
        }
        //4
        if(bichos[i] == "pollovion")
        {
            bichom.SetActive(false);
            bichom = pollovion;
        }
        if(bichos[i] == "trepillo")
        {
            bichom.SetActive(false);
            bichom = trepillo;
        }
        if(bichos[i] == "roboerto")
        {
            bichom.SetActive(false);
            bichom = roboerto;
        }
        if(bichos[i] == "tufo")
        {
            bichom.SetActive(false);
            bichom = tufo;
        }
        //5
        if(bichos[i] == "trashrat")
        {
            bichom.SetActive(false);
            bichom = trashrat;
        }
        if(bichos[i] == "spider")
        {
            bichom.SetActive(false);
            bichom = spider;
        }
        if(bichos[i] == "vivodado")
        {
            bichom.SetActive(false);
            bichom = vivodado;
        }
        if(bichos[i] == "dragonron")
        {
            bichom.SetActive(false);
            bichom = dragonron;
        }

        bichom.SetActive(true);
    }
}
