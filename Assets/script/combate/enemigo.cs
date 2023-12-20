using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemigo : MonoBehaviour
{

    public bool turbo = false;
    public bool rapido = false;
    public bool fuerte = false;
    public bool rapfue = false;
    public bool def = false;
    public bool defusar;
    public bool botebool = false;

    public string name;
    public string bicho;
    public float hp;
    public float mana;
    public float manarec;
    public float fuerza;
    public float nivel;

    public Collider ev1c;

    public int limite = 3;

    public AudioSource rapsound;
    public AudioSource fuesound;
    public AudioSource rapfuesound;
    public AudioSource turbosound;

    public AudioSource rapsoundcat;
    public AudioSource fuesoundcat;
    public AudioSource rapfuesoundcat;
    public AudioSource turbosoundcat;

    
    public RuntimeAnimatorController madcatanim1;
    public RuntimeAnimatorController shitanim1;
    public RuntimeAnimatorController topoanim1;
    public RuntimeAnimatorController skybirdanim1;

    public RuntimeAnimatorController ghostanim;
    public RuntimeAnimatorController algosaurioanim;
    public RuntimeAnimatorController bigfatanim;
    public RuntimeAnimatorController cazafantasmasanim;

    public RuntimeAnimatorController darkknightanim;
    public RuntimeAnimatorController antidoganim;
    public RuntimeAnimatorController pinguinoanim;
    public RuntimeAnimatorController craneovilanim;

    public RuntimeAnimatorController dogtableanim;
    public RuntimeAnimatorController beeanim;
    public RuntimeAnimatorController elephantanim;
    public RuntimeAnimatorController flyeraanim;

    public RuntimeAnimatorController friendanim;
    public RuntimeAnimatorController gunmananim;
    public RuntimeAnimatorController flanerioanim;
    public RuntimeAnimatorController fenixanim;





    public RuntimeAnimatorController kingdragonanim;
    public RuntimeAnimatorController heavydevilanim;
    public RuntimeAnimatorController krakenanim;
    public RuntimeAnimatorController lizardoanim;

    public RuntimeAnimatorController livedishanim;
    public RuntimeAnimatorController pesadillaanim;
    public RuntimeAnimatorController mirroranim;
    public RuntimeAnimatorController rabmonanim;

    public RuntimeAnimatorController antanim;
    public RuntimeAnimatorController kingsluganim;
    public RuntimeAnimatorController rosedragonanim;
    public RuntimeAnimatorController sharkmananim;

    public RuntimeAnimatorController pollovionanim;
    public RuntimeAnimatorController trepilloanim;
    public RuntimeAnimatorController roboertoanim;
    public RuntimeAnimatorController tufoanim;

    public RuntimeAnimatorController trashratanim;
    public RuntimeAnimatorController spideranim;
    public RuntimeAnimatorController vivodadoanim;
    public RuntimeAnimatorController dragonronanim;

    public Animator baseanim;


    public float temp;
    public float temp1;
    public float temp4;
    public float temp3;
    public float ventaja = 0;
    public float atb = 100;
    public float rangoexp;
    public float rango;
    public float turbobar = 0;


    public Text mehp;
    public Text memana;
    public Text mename;

    public AudioSource bote;

    public Collider prot;

    public GameObject escudo;

    public int hpmax;
    public int manamax;


    public int dano;

    public AudioSource danos;

    public AudioSource dano0;
    public AudioSource dano1;
    public AudioSource dano2;

    public AudioSource dano1cat;
    public AudioSource dano2cat;

    public GameObject ev1;

    public GameObject madcat1;
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

    public AudioSource fueson;
    public AudioSource rapson;
    public AudioSource fulson;
    public AudioSource defson;
    public AudioSource turboson;

    




    public float floattoint;

    public float ataque;
    public bool activar;
    public bool permiso;

    public string inteligencia = "inteligencia1";

    public int decision = 0;
    public int decision2 = 0;
    public int decision3 = 0;
    // Start is called before the first frame update
    void Start()
    {

        decision3 = Random.Range(25,35);

        hp = PlayerPrefs.GetFloat("hpene", 100);
        mana = PlayerPrefs.GetFloat("manaene", 100);
        manarec = PlayerPrefs.GetFloat("manarecene", 1);
        fuerza = PlayerPrefs.GetFloat("fuerzaene", 1);
        rango = PlayerPrefs.GetFloat("rangoene", 1);
        name = (string)PlayerPrefs.GetString("nameene", "misigno");
        bicho = (string)PlayerPrefs.GetString("bichosene", "madcat");
        nivel = PlayerPrefs.GetFloat("nivelg", 1);

        if(rango == 1)
        {rangoexp = 1;}
        if(rango == 2)
        {rangoexp = 1.50f;}
        if(rango == 3)
        {rangoexp = 2f;}
        if(rango == 4)
        {rangoexp = 2.50f;}
        if(rango == 5)
        {rangoexp = 3f;}

        if(rango == 6)
        {rangoexp = 3.25f;}
        if(rango == 7)
        {rangoexp = 3.75f;}
        if(rango == 8)
        {rangoexp = 4.25f;}
        if(rango == 9)
        {rangoexp = 4.75f;}
        if(rango == 10)
        {rangoexp = 5.25f;}

        if(rango == 11)
        {rangoexp = 5.5f;}
        if(rango == 12)
        {rangoexp = 6f;}
        if(rango == 13)
        {rangoexp = 6.50f;}
        if(rango == 14)
        {rangoexp = 7f;}
        if(rango == 15)
        {rangoexp = 7.50f;}

        if(rango == 16)
        {rangoexp = 7.75f;}
        if(rango == 17)
        {rangoexp = 8.25f;}
        if(rango == 48)
        {rangoexp = 8.75f;}
        if(rango == 19)
        {rangoexp = 9.25f;}
        if(rango == 20)
        {rangoexp = 9.75f;}

        if(rango == 21)
        {rangoexp = 10;}
        
        

       

        hpmax = (int)hp;
        manamax = (int)mana;
         if(bicho == "madcat")
        {
            
            madcat1.SetActive(true);
            ev1.SetActive(true);
            madcat1.name = "madcatn";
            baseanim.runtimeAnimatorController = madcatanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "shitfloor")
        {
            shitfloor.SetActive(true);
            ev1.SetActive(true);
            shitfloor.name = "shitfloor";
            
            baseanim.runtimeAnimatorController = shitanim1;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "topo topo")
        {
            topo.SetActive(true);
            ev1.SetActive(true);
            topo.name = "topo";
            
            baseanim.runtimeAnimatorController = topoanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "skybird")
        {
            skybird.SetActive(true);
            ev1.SetActive(true);
            skybird.name = "birdn";
            
            baseanim.runtimeAnimatorController = skybirdanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        //2
        if(bicho == "dragonron")
        {
            
            madcat1.SetActive(true);
            ev1.SetActive(true);
            madcat1.name = "dragonron";
            
            baseanim.runtimeAnimatorController = dragonronanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "eleph-ant")
        {
            shitfloor.SetActive(true);
            ev1.SetActive(true);
            shitfloor.name = "eleph-ant";
            
            baseanim.runtimeAnimatorController = elephantanim;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "roboerto")
        {
            topo.SetActive(true);
            ev1.SetActive(true);
            topo.name = "roboerto";
            
            baseanim.runtimeAnimatorController = roboertoanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "tufo")
        {
            skybird.SetActive(true);
            ev1.SetActive(true);
            skybird.name = "tufo";
            
            baseanim.runtimeAnimatorController = tufoanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        //3
        if(bicho == "antidog")
        {
            
            madcat1.SetActive(true);
            ev1.SetActive(true);
            madcat1.name = "antidog";
            
            baseanim.runtimeAnimatorController = antidoganim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "cazafantasmas")
        {
            shitfloor.SetActive(true);
            ev1.SetActive(true);
            shitfloor.name = "cazafantasmas";
            
            baseanim.runtimeAnimatorController = cazafantasmasanim;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "rabmon")
        {
            topo.SetActive(true);
            ev1.SetActive(true);
            topo.name = "rabmon";
            
            baseanim.runtimeAnimatorController = rabmonanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "vivodado")
        {
            skybird.SetActive(true);
            ev1.SetActive(true);
            skybird.name = "vivodado";
            
            baseanim.runtimeAnimatorController = vivodadoanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        //4
        if(bicho == "livedish")
        {
            
            madcat1.SetActive(true);
            ev1.SetActive(true);
            madcat1.name = "livedish";
            
            baseanim.runtimeAnimatorController = livedishanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "rose dragon")
        {
            shitfloor.SetActive(true);
            ev1.SetActive(true);
            shitfloor.name = "rosedragon";
            
            baseanim.runtimeAnimatorController = rosedragonanim;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "sharkman")
        {
            topo.SetActive(true);
            ev1.SetActive(true);
            topo.name = "sharkman";
            
            baseanim.runtimeAnimatorController = sharkmananim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "spider")
        {
            skybird.SetActive(true);
            ev1.SetActive(true);
            skybird.name = "spider";
            
            baseanim.runtimeAnimatorController = spideranim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        //5
        if(bicho == "algosaurio")
        {
            
            madcat1.SetActive(true);
            ev1.SetActive(true);
            madcat1.name = "algosaurio";
            
            baseanim.runtimeAnimatorController = algosaurioanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "dogtable")
        {
            shitfloor.SetActive(true);
            ev1.SetActive(true);
            shitfloor.name = "dogtable";
            
            baseanim.runtimeAnimatorController = dogtableanim;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "friend")
        {
            topo.SetActive(true);
            ev1.SetActive(true);
            topo.name = "friend";
            
            baseanim.runtimeAnimatorController = friendanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "trashrat")
        {
            skybird.SetActive(true);
            ev1.SetActive(true);
            skybird.name = "trashrat";
            
            baseanim.runtimeAnimatorController = trashratanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }




        //1
        if(bicho == "aghostin")
        {
            
            madcat1.SetActive(true);
            ev1.SetActive(true);
            madcat1.name = "aghostin";
            
            baseanim.runtimeAnimatorController = ghostanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "heavy devil")
        {
            shitfloor.SetActive(true);
            ev1.SetActive(true);
            shitfloor.name = "heavydevil";
            
            baseanim.runtimeAnimatorController = heavydevilanim;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "king slug")
        {
            topo.SetActive(true);
            ev1.SetActive(true);
            topo.name = "kingslug";
            
            baseanim.runtimeAnimatorController = kingsluganim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "pollovion")
        {
            skybird.SetActive(true);
            ev1.SetActive(true);
            skybird.name = "pollovion";
            
            baseanim.runtimeAnimatorController = pollovionanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        //2
        if(bicho == "sadistic ant")
        {
            
            madcat1.SetActive(true);
            ev1.SetActive(true);
            madcat1.name = "sadisticant";
            
            baseanim.runtimeAnimatorController = antanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "flanerio")
        {
            shitfloor.SetActive(true);
            ev1.SetActive(true);
            shitfloor.name = "flanerio";
            
            baseanim.runtimeAnimatorController = flanerioanim;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "flyera")
        {
            topo.SetActive(true);
            ev1.SetActive(true);
            topo.name = "flyera";
            
            baseanim.runtimeAnimatorController = flyeraanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "gunman")
        {
            skybird.SetActive(true);
            ev1.SetActive(true);
            skybird.name = "gunman";
            
            baseanim.runtimeAnimatorController = gunmananim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        //3
        if(bicho == "craneovil")
        {
            
            madcat1.SetActive(true);
            ev1.SetActive(true);
            madcat1.name = "craneovil";
            
            baseanim.runtimeAnimatorController = craneovilanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "dark knight")
        {
            shitfloor.SetActive(true);
            ev1.SetActive(true);
            shitfloor.name = "darkknight";
            
            baseanim.runtimeAnimatorController = darkknightanim;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "lizardo")
        {
            topo.SetActive(true);
            ev1.SetActive(true);
            topo.name = "lizardo";
            
            baseanim.runtimeAnimatorController = lizardoanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "trepillo")
        {
            skybird.SetActive(true);
            ev1.SetActive(true);
            skybird.name = "trepillo";
            
            baseanim.runtimeAnimatorController = trepilloanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        //4
        if(bicho == "beestosa")
        {
            
            madcat1.SetActive(true);
            ev1.SetActive(true);
            madcat1.name = "beestosa";
            
            baseanim.runtimeAnimatorController = beeanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "fenix")
        {
            shitfloor.SetActive(true);
            ev1.SetActive(true);
            shitfloor.name = "fenixbug";
            
            baseanim.runtimeAnimatorController = fenixanim;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "kraken")
        {
            topo.SetActive(true);
            ev1.SetActive(true);
            topo.name = "kraken";
            
            baseanim.runtimeAnimatorController = krakenanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "pesadilla")
        {
            skybird.SetActive(true);
            ev1.SetActive(true);
            skybird.name = "pesadilla";
            
            baseanim.runtimeAnimatorController = pesadillaanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        //5
        if(bicho == "bigfat")
        {
            
            madcat1.SetActive(true);
            ev1.SetActive(true);
            madcat1.name = "bigfat";
            
            baseanim.runtimeAnimatorController = bigfatanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "king dragon")
        {
            shitfloor.SetActive(true);
            ev1.SetActive(true);
            shitfloor.name = "king dragon";
            
            baseanim.runtimeAnimatorController = kingdragonanim;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "mirror-mirror")
        {
            topo.SetActive(true);
            ev1.SetActive(true);
            topo.name = "mirror-mirror";
            
            baseanim.runtimeAnimatorController = mirroranim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "cyberpinguino")
        {
            skybird.SetActive(true);
            ev1.SetActive(true);
            skybird.name = "cyberpinguino";
            
            baseanim.runtimeAnimatorController = pinguinoanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }

    }

    // Update is called once per frame
    void Update()
    {
        managerdecombate manager = UnityEngine.Object.FindObjectOfType<managerdecombate>();
        if (manager.comienzo == true)
        {
            
            if (dano == 0)
            {
                danos = dano0;
            }
            if (dano == 1)
            {
                danos = dano1;
            }
            if (dano == 2)
            {
                danos = dano2;
            }
            if (ventaja < 15)
            {ventaja += 1 * Time.deltaTime;}
            hero heroe = UnityEngine.Object.FindObjectOfType<hero>();
            if (inteligencia == "inteligencia1" && hp > 0 && ventaja > 2)
            {




                if(mana < 1)
                {   
                    if (temp > 0)
                    {decision = 0;}
                    if (decision == 0)
                    {
                        temp = -10;
                        decision = 10;
                    }
                    if(decision == 10){}

                }
                if(hp > 0 && hp <= 25 && mana > 0 && mana <= 30)
                {   
                    if (temp > 1)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){}
                    if(decision == 2){}
                    if(decision == 3){def = true;defson.Play();}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                    
                }
                if(hp > 0 && hp <= 25 && mana > 30 && mana <= 50)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,4);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){def = true;defson.Play();}
                    if(decision == 3){fuerte = true;}
                    if(decision == 4){fuerte = true;}
                    
                    
                }
                if(hp > 0 && hp <= 25 && mana > 50 && mana <= 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,4);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){}
                    if(decision == 3){rapido = true;}
                    if(decision == 4){rapido = true;}
                    
                    
                }
                if(hp > 0 && hp <= 25 && mana > 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,4);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){rapfue = true;}
                    
                    
                }
                if(hp > 0 && hp <= 50 && mana > 0 && mana <= 30)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){}
                    if(decision == 2){}
                    if(decision == 3){rapido = true;}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                    
                }
                if(hp > 25 && hp <= 50 && mana > 30 && mana <= 50)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){fuerte = true;}
                    if(decision == 3){}
                    if(decision == 4){}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                }
                if(hp > 25 && hp <= 50 && mana > 50 && mana <= 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){}
                    if(decision == 3){}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                }
                if(hp > 25 && hp <= 50 && mana > 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,4);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){rapfue = true;}
                    
                    
                }

                if(hp > 50 && hp <= 100 && mana > 0 && mana <= 30)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){}
                    if(decision == 2){}
                    if(decision == 3){}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                    
                }
                if(hp > 50 && hp <= 100 && mana > 30 && mana <= 50)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                }
                if(hp > 50 && hp <= 100 && mana > 50 && mana <= 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,4);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){fuerte = true;}
                    if(decision == 3){fuerte = true;}
                    if(decision == 4){fuerte = true;}
                    
                    
                }
                if(hp > 50 && hp <= 100 && mana > 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){fuerte = true;}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapfue = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapfue = true;}
                    
                    
                }
                if(hp > 100 && hp <= 200 && mana > 0 && mana <= 30)
                {   
                    if (temp > 10)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){}
                    if(decision == 2){fuerte = true;}
                    if(decision == 3){rapido = true;}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                    
                }
                if(hp > 100 && hp <= 200 && mana > 30 && mana <= 50)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,6);
                    }
                    if(decision == 1){}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){fuerte = true;}
                    if(decision == 4){rapido = true;}
                    if(decision == 5){fuerte = true;}
                    if(decision == 6){rapido = true;}
                    
                    
                }
                if(hp > 100 && hp <= 200 && mana > 50 && mana <= 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = 1;
                    }
                    if(decision == 1){fuerte = true;}
                    
                    
                    
                }
                if(hp > 100 && hp <= 200 && mana > 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(1,4);
                    }
                    
                    if(decision == 1){fuerte = true;}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){rapfue = true;}
                    
                    
                    
                }
                if(hp > 200 && mana > 0 && mana <= 30)
                {   
                    if (temp > 10)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){}
                    if(decision == 2){}
                    if(decision == 3){}
                    if(decision == 4){}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                    
                }
                if(hp > 200 &&  mana > 30 && mana <= 50)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,6);
                    }
                    if(decision == 1){}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){}
                    if(decision == 4){rapfue = true;}
                    if(decision == 5){fuerte = true;}
                    if(decision == 6){rapido = true;}
                    if(decision == 3){rapfue = true;}
                    if(decision == 3){rapfue = true;}
                    
                    
                }
                if(hp > 200 &&  mana > 50 && mana <= 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        Random.Range(1,2);
                    }
                    if(decision == 1){fuerte = true;}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){rapfue = true;}
                    
                    
                }
                if(hp > 200 && mana > 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,2);
                    }
                    if(decision == 1){fuerte = true;}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){fuerte = true;}
                    if(decision == 4){rapfue = true;}
                    if(decision == 5){fuerte = true;}
                    if(decision == 6){rapfue = true;}
                    
                    
                }
                if (turbobar == 100)
                {
                    decision = 0;
                    turbo = true;
                }
                

            }
            if(nivel == 2 || nivel == 3)
            {
                if(limite  > 0)
                {
                    decision2 = Random.Range(1,3);
                    if (temp3 > decision3)
                    {   
                        if(decision2 == 1)
                        {
                            temp3 = 0;
                            hp += 40;
                            limite--;
                            decision2 = 0;
                            decision3 = Random.Range(25,30);
                        }
                        if(decision2 == 2)
                        {
                            temp3 = 0;
                            heroe.mana += 90;
                            limite--;
                            decision2 = 0;
                            decision3 = Random.Range(25,30);
                        }
                    }
                }
            }
            if(nivel == 4 || nivel == 5)
            {
                if(limite  > 0)
                {
                    decision2 = Random.Range(1,5);
                    if (temp3 > decision3)
                    {   
                        if(decision2 == 1)
                        {
                            temp3 = 0;
                            hp += 100;
                            limite--;
                            decision2 = 0;
                            decision3 = Random.Range(25,30);
                        }
                        if(decision2 == 2)
                        {
                            temp3 = 0;
                            heroe.mana += 130;
                            limite--;
                            decision2 = 0;
                            decision3 = Random.Range(25,30);
                        }
                    }
                }
            }
            if(nivel == 6 || nivel == 7)
            {
                if(limite  > 0)
                {
                    decision2 = Random.Range(1,5);
                    if (temp3 > decision3)
                    {   
                        if(decision2 == 1)
                        {
                            temp3 = 0;
                            hp += 200;
                            limite--;
                            decision2 = 0;
                            decision3 = Random.Range(25,30);
                        }
                        if(decision2 == 2)
                        {
                            temp3 = 0;
                            heroe.mana += 200;
                            limite--;
                            decision2 = 0;
                            decision3 = Random.Range(25,30);
                        }
                    }
                }
            }
            
















            if (rapido == true && atb == 100 && mana >= 20  * rangoexp&& permiso == false && heroe.permiso == false)
            {
                mana -= 20 * rangoexp;
                ataque = Random.Range(10,16) * fuerza;
                activar = true;
                permiso = true;
                turbobar += 10;
                atb = 0;
                rapson.Play();
                rapsound.Play();
                baseanim.SetBool("atkvel", true);
                
                dano = Random.Range(0,3);
            }
            else if (fuerte == true && atb == 100 && mana >= 30 * rangoexp && permiso == false  && heroe.permiso == false)
            {
                mana -= 30 * rangoexp;
                ataque = Random.Range(16,20) * fuerza;
                activar = true;
                permiso = true;
                turbobar += 15;
                atb = 0;
                fueson.Play();
                fuesound.Play();
                baseanim.SetBool("atkfue", true);
                
                dano = Random.Range(0,3);
            }
            else if (rapfue == true && atb == 100 && mana >= 40 * rangoexp && permiso == false  && heroe.permiso == false) 
            {
                mana -= 40 * rangoexp;
                turbobar += 35;
                ataque = Random.Range(18,25) * fuerza;
                activar = true;
                permiso = true;
                atb = 0;
                fulson.Play();
                rapfuesound.Play();
                baseanim.SetBool("atkrapfue", true);
                
                dano = Random.Range(0,3);
            }
            else if (turbo == true && atb == 100 && turbobar == 100 && permiso == false && heroe.permiso == false)
            {
                activar = true;
                permiso = true;
                turbobar = 0;
                turbosound.Play();
                turboson.Play();
                ataque = Random.Range(40,50) * fuerza;
                atb = 0;
                baseanim.SetBool("atkturbo", true);
                
                dano = Random.Range(0,3);
                
            }
            else
            {
                baseanim.SetBool("atkrapfue", false);
                baseanim.SetBool("atkvel", false);
                baseanim.SetBool("atkfue", false);
                baseanim.SetBool("atkturbo", false);

            
        

            }

            if (def == true && mana >= 5 * rangoexp && activar == false && permiso == false)
            {
                if(botebool == false)
                {bote.Play();}
                mana -= 3.5f * rangoexp * Time.deltaTime;
                turbobar += 0.7f * Time.deltaTime;
                prot.enabled = false;
               
                botebool = true;
                escudo.gameObject.SetActive(true);
                defusar = true;
                
            }
            else if (def == true && mana > 0  && mana < 5 * rangoexp && permiso == false && defusar == true)
            {
                mana -= 3.5f * rangoexp * Time.deltaTime;
                turbobar += 0.7f * Time.deltaTime;
                prot.enabled = false;
                
                escudo.gameObject.SetActive(true);
            }
            else 
            {   
                defusar = false;
                botebool = false;
                bote.Stop();
                prot.enabled = true;
                
                if(mana > -1)
                {
                    if (mana < manamax)
                    {mana+= 3f * manarec * Time.deltaTime;}
                }
                if(mana > 50)
                {
                    if (mana < manamax)
                    {mana+= 3.5f * manarec * Time.deltaTime;}
                }
                if(mana > 65)
                {
                    if (mana < manamax)
                    {mana+= 4f * manarec * Time.deltaTime;}
                }
            
                escudo.gameObject.SetActive(false);
            
            }
            

            if (mana < 0)
            {mana = 0;}

            if (turbobar > 100)
            {turbobar = 100;}
            if (hp > hpmax)
            {hp = hpmax;}
            if (mana > manamax)
            {mana = manamax;}
            if (hp < 0)
            {hp = 0;}
            if (mana < 0)
            {mana = 0;}



            rapido = false;
            fuerte = false;
            rapfue = false;
            turbo = false;

            mehp.text = "vit "+(int)hp+" / " + hpmax;
            memana.text = "Stamina "+(int)mana+" / " + manamax;


            

            if (temp < 15)
            {temp += 1 * Time.deltaTime;}

            if (temp1 < 15)
            {temp1 += 1 * Time.deltaTime;}
            if (temp4 < 15)
            {temp4 += 1 * Time.deltaTime;}
            

            
            mename.text = name;
            if (atb < 100)
            {atb += 15 * Time.deltaTime;}
            if (atb > 99) {atb = 100;}
        }
        mename.text = name;
    }
    
}
