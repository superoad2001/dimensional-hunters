using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;

public class enemigo : Agent
{
    public DynamicTextData textDatadano;

    public DynamicTextData textDatamana;

    public DynamicTextData textDatamanamas;

    public DynamicTextData textDataturbomas;
    public DynamicTextData textDataturbomenos;

    public float tempdtext;
    public float tempesc;


    public bool turbo = false;
    public bool rapido = false;
    public bool fuerte = false;
    public bool rapfue = false;
    public bool def = false;
    public bool defusar;
    public Text turboui;
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

    public GameObject ev1;

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
    public override void OnActionReceived(ActionBuffers actions)
    {
        decision = actions.DiscreteActions[0];
    }
    // Start is called before the first frame update
    void Start()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();

        decision3 = Random.Range(25,35);

        hp = inv.datosserial.hpene;
        mana = inv.datosserial.manaene;
        manarec = inv.datosserial.manarecene;
        fuerza = inv.datosserial.fuerzaene;
        rango = inv.datosserial.rangoene;
        name = inv.datosserial.nameene;
        bicho = inv.datosserial.razaene;
        nivel = inv.datosserial.nivelene;

        if(inv.datosserial.modotorneo == true)
        {
            hp = inv.datosserial.hptorneo[inv.datosserial.torneopuesto];
            mana = inv.datosserial.manatorneo[inv.datosserial.torneopuesto];
            manarec = inv.datosserial.manarectorneo[inv.datosserial.torneopuesto];
            fuerza = inv.datosserial.fuerzatorneo[inv.datosserial.torneopuesto];
            rango = inv.datosserial.rangotorneo[inv.datosserial.torneopuesto];
            name = inv.datosserial.nametorneo[inv.datosserial.torneopuesto];
            bicho = inv.datosserial.razatorneo[inv.datosserial.torneopuesto];
            nivel = inv.datosserial.niveltorneo[inv.datosserial.torneopuesto];
        }

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
        if(rango == 18)
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
            
            dragonron.SetActive(true);
            ev1.SetActive(true);
            dragonron.name = "dragonron";
            
            baseanim.runtimeAnimatorController = dragonronanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "elephant")
        {
            elephant.SetActive(true);
            ev1.SetActive(true);
            elephant.name = "eleph-ant";
            
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
            roboerto.SetActive(true);
            ev1.SetActive(true);
            roboerto.name = "roboerto";
            
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
            tufo.SetActive(true);
            ev1.SetActive(true);
            tufo.name = "tufo";
            
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
            
            antidog.SetActive(true);
            ev1.SetActive(true);
            antidog.name = "antidog";
            
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
            cazafantasmas.SetActive(true);
            ev1.SetActive(true);
            cazafantasmas.name = "cazafantasmas";
            
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
            rabmon.SetActive(true);
            ev1.SetActive(true);
            rabmon.name = "rabmon";
            
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
            vivodado.SetActive(true);
            ev1.SetActive(true);
            vivodado.name = "vivodado";
            
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
            
            livedish.SetActive(true);
            ev1.SetActive(true);
            livedish.name = "livedish";
            
            baseanim.runtimeAnimatorController = livedishanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "rosedragon")
        {
            rosedragon.SetActive(true);
            ev1.SetActive(true);
            rosedragon.name = "rosedragon";
            
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
            sharkman.SetActive(true);
            ev1.SetActive(true);
            sharkman.name = "sharkman";
            
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
            spider.SetActive(true);
            ev1.SetActive(true);
            spider.name = "spider";
            
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
            
            algosaurio.SetActive(true);
            ev1.SetActive(true);
            algosaurio.name = "algosaurio";
            
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
            dogtable.SetActive(true);
            ev1.SetActive(true);
            dogtable.name = "dogtable";
            
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
            dogtable.SetActive(true);
            ev1.SetActive(true);
            dogtable.name = "friend";
            
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
            trashrat.SetActive(true);
            ev1.SetActive(true);
            trashrat.name = "trashrat";
            
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
            
            ghost.SetActive(true);
            ev1.SetActive(true);
            ghost.name = "aghostin";
            
            baseanim.runtimeAnimatorController = ghostanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "heavydevil")
        {
            heavydevil.SetActive(true);
            ev1.SetActive(true);
            heavydevil.name = "heavydevil";
            
            baseanim.runtimeAnimatorController = heavydevilanim;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "kingslug")
        {
            kingslug.SetActive(true);
            ev1.SetActive(true);
            kingslug.name = "kingslug";
            
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
            pollovion.SetActive(true);
            ev1.SetActive(true);
            pollovion.name = "pollovion";
            
            baseanim.runtimeAnimatorController = pollovionanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        //2
        if(bicho == "sadisticant")
        {
            
            ant.SetActive(true);
            ev1.SetActive(true);
            ant.name = "sadisticant";
            
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
            flanerio.SetActive(true);
            ev1.SetActive(true);
            flanerio.name = "flanerio";
            
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
            flyera.SetActive(true);
            ev1.SetActive(true);
            flyera.name = "flyera";
            
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
            gunman.SetActive(true);
            ev1.SetActive(true);
            gunman.name = "gunman";
            
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
            
            craneovil.SetActive(true);
            ev1.SetActive(true);
            craneovil.name = "craneovil";
            
            baseanim.runtimeAnimatorController = craneovilanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "darkknight")
        {
            darkknight.SetActive(true);
            ev1.SetActive(true);
            darkknight.name = "darkknight";
            
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
            lizardo.SetActive(true);
            ev1.SetActive(true);
            lizardo.name = "lizardo";
            
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
            trepillo.SetActive(true);
            ev1.SetActive(true);
            trepillo.name = "trepillo";
            
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
            
            bee.SetActive(true);
            ev1.SetActive(true);
            bee.name = "beestosa";
            
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
            fenix.SetActive(true);
            ev1.SetActive(true);
            fenix.name = "fenixbug";
            
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
            kraken.SetActive(true);
            ev1.SetActive(true);
            kraken.name = "kraken";
            
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
            pesadilla.SetActive(true);
            ev1.SetActive(true);
            pesadilla.name = "pesadilla";
            
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
            
            bigfat.SetActive(true);
            ev1.SetActive(true);
            bigfat.name = "bigfat";
            
            baseanim.runtimeAnimatorController = bigfatanim;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "kingdragon")
        {
            kingdragon.SetActive(true);
            ev1.SetActive(true);
            kingdragon.name = "king dragon";
            
            baseanim.runtimeAnimatorController = kingdragonanim;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "mirror")
        {
            mirror.SetActive(true);
            ev1.SetActive(true);
            mirror.name = "mirror-mirror";
            
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
            pinguino.SetActive(true);
            ev1.SetActive(true);
            pinguino.name = "cyberpiguino";
            
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
        turboui.text = (int)turbobar+"%";
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


                if(decision == 1){def = true;defson.Play();tempesc = 0;}
                if(decision == 2){def = false;turbo = true;tempesc = 0;}
                if(decision == 3){def = false;rapido = true;tempesc = 0;}
                if(decision == 4){def = false;fuerte = true;tempesc = 0;}
                if(decision == 5){def = false;rapfue = true;tempesc = 0;}
                if(tempesc > 5 && def == true){def = false;tempesc = 0;}



                /*if(mana < 1)
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
                if(hp > (hpmax/100)* 0 && hp <= (hpmax/100)* 10 && mana > 0 * rangoexp && mana <= 30 * rangoexp)
                {   
                    if (temp > 1)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,8);
                    }
                    if(decision == 1){}
                    if(decision == 2){}
                    if(decision == 3){def = true;defson.Play();}
                    if(decision == 4){rapido = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){rapido = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                    
                }
                if(hp > (hpmax/100)* 0 && hp <= (hpmax/100)* 10 && mana > 30 * rangoexp && mana <= 50 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,5);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){def = true;defson.Play();}
                    if(decision == 3){fuerte = true;}
                    if(decision == 4){fuerte = true;}
                    
                    
                }
                if(hp > (hpmax/100)* 0 && hp <= (hpmax/100)* 10 && mana > 50 * rangoexp && mana <= 60 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,5);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){}
                    if(decision == 3){rapido = true;}
                    if(decision == 4){rapido = true;}
                    
                    
                }
                if(hp > (hpmax/100)* 0 && hp <= (hpmax/100)* 10 && mana > 60 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,5);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){rapfue = true;}
                    
                    
                }
                if(hp > (hpmax/100)* 0 && hp <= (hpmax/100)* 10 && mana > 0 * rangoexp && mana <= 30 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,8);
                    }
                    if(decision == 1){}
                    if(decision == 2){}
                    if(decision == 3){rapido = true;}
                    if(decision == 4){rapido = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){rapido = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                    
                }
                if(hp > (hpmax/100)* 10 && hp <= (hpmax/100)* 25 && mana > 30 * rangoexp && mana <= 50 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,8);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){fuerte = true;}
                    if(decision == 3){}
                    if(decision == 4){}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                }
                if(hp > (hpmax/100)* 10 && hp <= (hpmax/100)* 25 && mana > 50 * rangoexp && mana <= 60 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,8);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){}
                    if(decision == 3){}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                }
                if(hp > (hpmax/100)* 10 && hp <= (hpmax/100)* 25 && mana > 60 * rangoexp )
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,5);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){rapfue = true;}
                    
                    
                }

                if(hp > (hpmax/100)* 25 && hp <= (hpmax/100)* 50 && mana > 0 * rangoexp && mana <= 30 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,8);
                    }
                    if(decision == 1){}
                    if(decision == 2){}
                    if(decision == 3){}
                    if(decision == 4){rapido = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){rapido = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                    
                }
                if(hp > (hpmax/100)* 25 && hp <= (hpmax/100)* 50 && mana > 30 * rangoexp && mana <= 50 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,8);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){}
                    if(decision == 3){rapido = true;}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                }
                if(hp > (hpmax/100)* 25 && hp <= (hpmax/100)* 50 && mana > 50 * rangoexp && mana <= 60 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,5);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){fuerte = true;}
                    if(decision == 3){fuerte = true;}
                    if(decision == 4){fuerte = true;}
                    
                    
                }
                if(hp > (hpmax/100)* 25 && hp <= (hpmax/100)* 50 && mana > 60 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,8);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){fuerte = true;}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapfue = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapfue = true;}
                    
                    
                }
                if(hp > (hpmax/100)* 50 && hp <= (hpmax/100)* 80 && mana > 0 * rangoexp && mana <= 30 * rangoexp)
                {   
                    if (temp > 10)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,4);
                    }
                    if(decision == 1){}
                    if(decision == 2){rapido = true;}
                    if(decision == 3){rapido = true;}
                    
                    
                    
                }
                if(hp > (hpmax/100)* 50 && hp <= (hpmax/100)* 80 && mana > 30 * rangoexp && mana <= 50 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){}
                    if(decision == 2){fuerte = true;}
                    if(decision == 3){fuerte = true;}
                    if(decision == 4){rapido = true;}
                    if(decision == 5){fuerte = true;}
                    if(decision == 6){rapido = true;}
                    
                    
                }
                if(hp > (hpmax/100)* 50 && hp <= (hpmax/100)* 80 && mana > 50 * rangoexp && mana <= 60 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = 1;
                    }
                    if(decision == 1){fuerte = true;}
                    
                    
                    
                }
                if(hp > (hpmax/100)* 50 && hp <= (hpmax/100)* 80 && mana > 60 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(1,5);
                    }
                    
                    if(decision == 1){fuerte = true;}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){rapfue = true;}
                    
                    
                    
                }
                if(hp > (hpmax/100)* 80 && mana > 0 * rangoexp && mana <= 30 * rangoexp)
                {   
                    if (temp > 10)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(1,6);
                    }
                    if(decision == 1){}
                    if(decision == 2){}
                    if(decision == 3){rapido = true;}
                    if(decision == 4){rapido = true;}
                    if(decision == 5){rapido = true;}
                    
                    
                    
                }
                if(hp > (hpmax/100)* 80 &&  mana > 30 * rangoexp && mana <= 50 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(1,5);
                    }
                    if(decision == 1){}
                    if(decision == 2){fuerte = true;}
                    if(decision == 3){fuerte = true;}
                    if(decision == 4){rapido = true;}
                    
                    
                }
                if(hp > (hpmax/100)* 80 &&  mana > 50 * rangoexp && mana <= 60 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        Random.Range(1,4);
                    }
                    if(decision == 1){fuerte = true;}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){rapfue = true;}
                    
                    
                }
                if(hp > (hpmax/100)* 80 && mana > 60 * rangoexp)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(1,7);
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
                }*/
                

            }
            
















            if (rapido == true && atb == 100 && mana >= 10  * rangoexp&& permiso == false && heroe.permiso == false)
            {
                mana -= 10 * rangoexp;
                ataque = Random.Range(5,8) * fuerza;
                activar = true;
                permiso = true;
                turbobar += 25;
                atb = 0;
                rapson.Play();
                rapsound.Play();
                baseanim.SetBool("atkvel", true);
                
                dano = Random.Range(0,3);

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(10 * rangoexp),textDatamana);  
 
                dtext.CreateText(ev1.transform.position,"+"+(int)(25),textDataturbomas);
            }
            else if (fuerte == true && atb == 100 && mana >= 30 * rangoexp && permiso == false  && heroe.permiso == false)
            {
                mana -= 30 * rangoexp;
                ataque = Random.Range(15,20) * fuerza;
                activar = true;
                permiso = true;
                turbobar += 25;
                atb = 0;
                fueson.Play();
                fuesound.Play();
                baseanim.SetBool("atkfue", true);

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(30 * rangoexp),textDatamana);  
            
                dtext.CreateText(ev1.transform.position,"+"+(int)(25),textDataturbomas);
                
                dano = Random.Range(0,3);
            }
            else if (rapfue == true && atb == 100 && mana >= 50 * rangoexp && permiso == false  && heroe.permiso == false) 
            {
                mana -= 50 * rangoexp;
                turbobar += 50;
                ataque = Random.Range(37,40) * fuerza;
                activar = true;
                permiso = true;
                atb = 0;
                fulson.Play();
                rapfuesound.Play();
                baseanim.SetBool("atkrapfue", true);
                
                dano = Random.Range(0,3);

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(50 * rangoexp),textDatamana);  

                dtext.CreateText(ev1.transform.position,"+"+(int)(50),textDataturbomas);
            }
            else if (turbo == true && atb == 100 && turbobar == 100 && permiso == false && heroe.permiso == false)
            {
                activar = true;
                permiso = true;
                turbobar = 0;
                turbosound.Play();
                turboson.Play();
                ataque = Random.Range(37,40) * fuerza;
                atb = 0;
                baseanim.SetBool("atkturbo", true);
                
                dano = Random.Range(0,3);

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(100),textDataturbomenos);
                
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
                mana -= 8.5f * rangoexp * Time.deltaTime;
                turbobar += 5f * Time.deltaTime;
                prot.enabled = false;
               
                botebool = true;
                escudo.gameObject.SetActive(true);
                defusar = true;

                if(tempdtext > 1f)
                {
                    DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                    dtext.CreateText(ev1.transform.position,("-"+(8.5 * rangoexp)).Substring(0, 6),textDatamana);
                    tempdtext = 0;
                }
                tempdtext += 1 * Time.deltaTime; 
                
            }
            else if (def == true && mana > 0  && mana < 5 * rangoexp && permiso == false && defusar == true)
            {
                mana -= 8.5f * rangoexp * Time.deltaTime;
                turbobar += 5f * Time.deltaTime;
                prot.enabled = false;
                
                escudo.gameObject.SetActive(true);
                if(tempdtext > 1f)
                {
                    DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                    dtext.CreateText(ev1.transform.position,("-"+(8.5 * rangoexp)).Substring(0, 6),textDatamana);
                    tempdtext = 0;
                }
                tempdtext += 1 * Time.deltaTime;
            }
            else 
            {   
                defusar = false;
                botebool = false;
                bote.Stop();
                prot.enabled = true;
                
                
                    if (mana < manamax)
                    {
                        mana+= 1.5f * manarec * Time.deltaTime;
                        if(tempdtext > 1f)
                        {
                            DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                            dtext.CreateText(ev1.transform.position,("+"+(1.5f * manarec)),textDatamanamas);
                            tempdtext = 0;
                        }
                    }
                    tempdtext += 1 * Time.deltaTime;
            
            
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
            if (tempesc < 15)
            {tempesc += 1 * Time.deltaTime;}
            

            
            mename.text = name;
            if (atb < 100)
            {atb += 15 * Time.deltaTime;}
            if (atb > 99) {atb = 100;}
        }
        mename.text = name;
    }
    
}
