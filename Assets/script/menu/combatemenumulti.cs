using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class combatemenumulti : MonoBehaviour
{
    public bool cajon = false;
    public bool nobich = false;
    public bool cajoncomb = false;
    public bool inventario1 = true;

    public bool vez1;
    
    public bool bichoselec;
    public bool cajonentr;
    public bool actentre;
    public Text libera;

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

    public GameObject intercambiom;
    
    public bool intercambio;

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

    public bool intercambioc;

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
    public void _inter()
    {
        intercambioc = true;
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


        ciuda = new string[6];


        ciuda[0] = "barcelona";




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
        {SceneManager.LoadScene("combatemenu");}
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
            intercambiom.gameObject.SetActive(false);
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
            intercambioc = false;
            intercambio = false;
            
            
            
        }
        if (intercambioc == true)
        {
            if (inv.datosserial.name.Count == 0)
            {actnobichos2 = true;}
            inventario1 = false;
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(false);
            ciu.gameObject.SetActive(false);
            nobichos.gameObject.SetActive(false);
            botlib.gameObject.SetActive(false);
            bichno.gameObject.SetActive(false);
            intercambiom.gameObject.SetActive(true);
            bicho = bicho1;
            i = 0;
            cajonbarcelona = false;
            cajoncomb = false;
            acta = false;
            ciudades1 = false;
            cajon = false;
            actc = false;
            actheroe = false;
            nobich = false;
            nobich2 = false;
            intercambioc = false;
            intercambio = true;
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
            intercambiom.gameObject.SetActive(false);
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
            intercambioc = false;
            intercambio = false;
            
            
            
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
            intercambiom.gameObject.SetActive(false);
            cajon = false;
            cajonbarcelona = false;
            cajoncomb = false;
            acta = false;
            ciudades1 = false;
            actheroe = false;
            bichom.SetActive(false);
            actentre = false;
            cajonentr = false;
            intercambioc = false;
            intercambio = false;
            
            
            
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
            intercambiom.gameObject.SetActive(false);
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
            intercambioc = false;
            intercambio = false;
            
            
            
        }
        if (actheroe == true)
        {
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(true);
            ciu.gameObject.SetActive(false);
            nobichos.gameObject.SetActive(false);
            botlib.gameObject.SetActive(false);
            intercambiom.gameObject.SetActive(false);
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
            intercambioc = false;
            intercambio = false;
            
            
            
        }
        if (actentre == true)
        {
            if (inv.datosserial.name.Count == 0)
            {actnobichos2 = true;}
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(true);
            ciu.gameObject.SetActive(false);
            intercambiom.gameObject.SetActive(false);
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
            intercambioc = false;
            intercambio = false;
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
            intercambiom.gameObject.SetActive(false);
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
            intercambioc = false;
            intercambio = false;

            i = 0;
            
            
            
            
        }
        if (actnobichos2 == true)
        {
            inventario1 = false;
            elemento_.gameObject.SetActive(false);
            elemt.gameObject.SetActive(false);
            ciu.gameObject.SetActive(false);
            intercambiom.gameObject.SetActive(false);
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
            intercambioc = false;
            intercambio = false;

            
            
            
        }
        if(cajon == true)
        {
                botlib.gameObject.SetActive(true);
                
                bichos = inv.datosserial.bichosmios;
                if(vez1 == false)
                {
                    modelos();
                    colorbicho5 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho5>();
                    colorbicho.colorb();
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
            if (izq == true && i > 0 && temp > 0.3f)
            {
                i--;
                temp = 0;
                modelos();
                colorbicho5 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho5>();
                colorbicho.colorb();
            }
            if (der == true && i < indexmax - 1 && temp > 0.3f)
            {
                i++;
                temp = 0;
                modelos();
                colorbicho5 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho5>();
                colorbicho.colorb();
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
                    colorbicho5 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho5>();
                    colorbicho.colorb();
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
                SceneManager.LoadScene("cola");
                }
        
            if (izq == true && i > 0 && temp > 0.3f)
            {
                i--;
                temp = 0;
                modelos();
                colorbicho5 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho5>();
                colorbicho.colorb();
            }
            if (der == true && i < indexmax - 1 && temp > 0.3f)
            {
                i++;
                temp = 0;
                modelos();
                colorbicho5 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho5>();
                colorbicho.colorb();
            }
        }
        if(cajonentr == true)
        {
                bichos = inv.datosserial.bichosmios;
                indexmax = bichos.Count;

                if(vez1 == false)
                {
                    modelos();
                    colorbicho5 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho5>();
                    colorbicho.colorb();
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
                inv.datosserial.elementos = inv.datosserial.elemento[i];
                inv.datosserial.exps = inv.datosserial.exp[i];
                inv.datosserial.nivels = inv.datosserial.nivel[i];
                inv.datosserial.clases = inv.datosserial.clase[i];
                inv.datosserial.rangors = inv.datosserial.rango[i];
                inv.datosserial.varsel1 = i;
                inv.guardar();
                cajon = false;
                temp = 0;
                SceneManager.LoadScene("intercambiador");
                }
        
            if (izq == true && i > 0 && temp > 0.3f)
            {
                i--;
                temp = 0;
                modelos();
                colorbicho5 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho5>();
                colorbicho.colorb();
            }
            if (der == true && i < indexmax - 1 && temp > 0.3f)
            {
                i++;
                temp = 0;
                modelos();
                colorbicho5 colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho5>();
                colorbicho.colorb();
            }
        }
        if(ciudades1 == true)
        {
                bichom.SetActive(false);
                if(atras == true)
                {acta = true;}
                ciudatext.text = "1vs1";
                if(bichoselec == true && temp > 0.3f && inv.datosserial.dinero >= 200)
                {
                    inv.datosserial.dinero -= 200;
                    inv.guardar();
                    actheroe = true;
                }
        
        }
        if(intercambio == true)
        {
                bichom.SetActive(false);
                if(atras == true)
                {acta = true;}
                ciudatext.text = "Intercambiador";
                if(bichoselec == true && temp > 0.3f && inv.datosserial.dinero >= 50 && inv.datosserial.indexmax != inv.datosserial.limite)
                {
                        inv.datosserial.dinero -= 50;
                        inv.guardar();
                        actentre = true;
                }
                else if(inv.datosserial.indexmax == inv.datosserial.limite)
                {
                    libera.text = "libera a un heroe para intercambiar";
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
