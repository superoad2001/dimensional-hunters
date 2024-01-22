using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Collections;
using Unity.Netcode;
using Rewired;


public class heromulti2  : NetworkBehaviour
{

    [SerializeField]private int playerID = 0;
	[SerializeField]private Player player;
    public string plat;
    public heromulti heroe2;

    public DynamicTextData textDatadano;

    public DynamicTextData textDatamana;

    public DynamicTextData textDatamanamas;

    public DynamicTextData textDataturbomas;
    public DynamicTextData textDataturbomenos;


    public float tempdtext;
    
    public NetworkVariable<float> ataquem = new NetworkVariable<float>(1, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<FixedString64Bytes> hnamer = new NetworkVariable<FixedString64Bytes>("misigno", 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<FixedString64Bytes> bichor = new NetworkVariable<FixedString64Bytes>("shitfloor", 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> hpr = new NetworkVariable<float>(100, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<float> manar = new NetworkVariable<float>(100, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<float> manarecr = new NetworkVariable<float>(2, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<float> fuerzar = new NetworkVariable<float>(2, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> atbr = new NetworkVariable<float>(2, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> turbor = new NetworkVariable<float>(2, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> hpmaxr = new NetworkVariable<float>(100, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<float> manamaxr = new NetworkVariable<float>(100, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> atkr = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<bool> permisor = new NetworkVariable<bool>(false, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> nivelr = new NetworkVariable<float>(1, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> rangor = new NetworkVariable<float>(1, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> claser = new NetworkVariable<float>(1, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> turborest = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public string hname;
    public string bicho;
    public float hp;
    public float mana;
    public float manarec;
    public float fuerza;

    public float nivel;
    public float rango;
    public float clase;

    public NetworkVariable<bool> defr = new NetworkVariable<bool>(false, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<int> mostrarr = new NetworkVariable<int>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<int> mostrarr2 = new NetworkVariable<int>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> manarest = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);


    public Text turboui;

    public colorbicho7 colorbicho;





    public bool activar;
    public bool defusar;
    public bool permiso;
    public float ataque;
    public bool vez1 = false;
    public bool turbo = false;
    public bool rapido = false;
    public bool fuerte = false;
    public bool rapfue = false;
    public bool def = false;
    public float temp;
    public float temp4;
    public float atb = 100;
    public bool atkreal;
    public float turbobar = 0;
    public heromulti enemigo;

    public int dano;

    public AudioSource danos;

    public AudioSource dano0;
    public AudioSource dano1;
    public AudioSource dano2;

    public AudioSource dano1cat;
    public AudioSource dano2cat;

    public AudioSource rapsound;
    public AudioSource fuesound;
    public AudioSource rapfuesound;
    public AudioSource turbosound;

    public AudioSource rapsoundcat;
    public AudioSource fuesoundcat;
    public AudioSource rapfuesoundcat;
    public AudioSource turbosoundcat;

    public AudioSource botcl;
    public AudioSource botno;
    public AudioSource bote;

    public bool botebool;

    public Text mehp;
    public Text memana;
    public Text mename;

    public Collider prot;

    public float tempc;

    public GameObject escudo;
    public float rangoexp;



    public int hpmax;
    public int manamax;

    public Animator baseanim;
    
    public GameObject ev1;

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

    public managermulti managermulti;

    public bool carga;

    public int client;


    
    // Start is called before the first frame update
    public void Start()
    {

        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        plat = inv.datosserial.plat;
        if(plat == "game3d")
        {player = ReInput.players.GetPlayer(playerID);}
        

        
    }
    public void _turbo()
    {
        turbo = true;
    }
    public void _rapido()
    {
        rapido = true;
    }
    public void _fuerte()
    {
        fuerte = true;
    }
    public void _rapfue()
    {
        rapfue = true;
    }
    public void _def()
    {
        def = true;
    }
    public void _notdef()
    {
        def = false;
    }
    // Update is called once per frame
    public void Update()
    {  
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        client = inv.datosserial.client;

        turboui.text = (int)turbobar+"%";
        if(client == 1)
        {
            if(atkr.Value == 0)
            {
                baseanim.SetBool("atkrapfue", false);
                baseanim.SetBool("atkvel", false);
                baseanim.SetBool("atkfue", false);
                baseanim.SetBool("atkturbo", false); 
            }
            if(atkr.Value == 1)
            {
                baseanim.SetBool("atkvel", true);
                
            }
            if(atkr.Value == 2)
            {
                baseanim.SetBool("atkfue", true);
                
            }
            if(atkr.Value == 3)
            {
                baseanim.SetBool("atkrapfue", true);
                
            }
            if(atkr.Value == 4)
            {
                baseanim.SetBool("atkturbo", true);
            }
        }
        if(managermulti.comenzar.Value == true && tempc < 3f)
        {
        if(client == 2)
        {
        hp = inv.datosserial.hps;
        mana = inv.datosserial.manas;
        manarec = inv.datosserial.manarecs;
        fuerza = inv.datosserial.fuerzas;
        rango = inv.datosserial.rangors;
        clase = inv.datosserial.clases;
        hname = inv.datosserial.names;
        bicho = inv.datosserial.razas;
        nivel = inv.datosserial.nivels;
        hpmax = (int)hp;
        manamax = (int)mana;

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

        cargadatosServerRpc(hp,mana,manarec,fuerza,hname,bicho,turbobar,atb,hpmax,manamax,nivel,rango,clase);
        modelos();
        colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho7>();
        colorbicho.colorb();
        tempc += 1 * Time.deltaTime;
        }
        if(client == 1)
        {
        hp = hpr.Value;
        mana = manar.Value;
        manarec = manarecr.Value;
        fuerza = fuerzar.Value;
        hname = hnamer.Value.ToString();
        bicho = bichor.Value.ToString();
        hpmax = (int)hpmaxr.Value;
        manamax = (int)manamaxr.Value;
        clase = claser.Value;
        rango = rangor.Value;
        nivel = nivelr.Value;
        tempc += 1 * Time.deltaTime;
        Debug.Log("proceso");
        Debug.Log("hp1: "+hpr.Value);
        }
        

        }




        managerdecombatemulti manager = UnityEngine.Object.FindObjectOfType<managerdecombatemulti>();
        if(managermulti.comenzar.Value == true && tempc >= 3f)
        {
            Debug.Log("hp2: "+hpr.Value);
        if(client == 1 && manager.comienzo == false)
        {
            modelos();
            colorbicho = UnityEngine.Object.FindObjectOfType<colorbicho7>();
            colorbicho.colorb();
        }
        permiso = permisor.Value;
        hp = hpr.Value;
        if(client == 1)
        {
        mana = manar.Value;
        manarec = manarecr.Value;
        fuerza = fuerzar.Value;
        atb = atbr.Value;
        turbobar = turbor.Value;
        hpmax = (int)hpmaxr.Value;
        manamax = (int)manamaxr.Value;
        hname = hnamer.Value.ToString();
        bicho = bichor.Value.ToString();
        }
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
        if (manager.comienzo == true)
        {


            if(client == 2)
            {
                if(player.GetAxis("a") > 0f)
                {
                    rapido = true;
                }
                else if(player.GetAxis("x") > 0f)
                {
                    fuerte = true;
                }
                else if(player.GetAxis("y") > 0f)
                {
                    rapfue = true;
                }
                else if(player.GetAxis("rb") > 0f)
                {
                    turbo = true;
                }
                if(player.GetAxis("lb") > 0f)
                {
                    def = true;
                }
                else
                {
                    def = false;
                }
            }
            if(client == 2)
            {
            baseanim.SetBool("atkrapfue", false);
            baseanim.SetBool("atkvel", false);
            baseanim.SetBool("atkfue", false);
            baseanim.SetBool("atkturbo", false);

            if (rapido == true && atb == 100 && mana >= 20  * rangoexp && permiso == false && enemigo.permiso == false)
            {
                activar = true;
                permiso = true;
                permisoServerRpc(true);
                atkServerRpc(1);
                mana -= 20 * rangoexp ;
                manarestServerRpc(20 * rangoexp);
                turbobar += 25;
                turborestServerRpc(25);
                ataque = Random.Range(5,10) * fuerza;
                ataquemServerRpc(ataque);
                atb = 0;
                rapsound.Play();
                baseanim.SetBool("atkvel", true);
            
                dano = Random.Range(0,3);
                botcl.Play();

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(20 * rangoexp),textDatamana);  

                dtext.CreateText(ev1.transform.position,"+"+(int)(25),textDataturbomas);
                mostrarServerRpc(2);
                temp4 = 0;
                
            }
            else if (fuerte == true && atb == 100 && mana >= 30 * rangoexp  && permiso == false && enemigo.permiso == false)
            {
            
                activar = true;
                permiso = true;
                atkServerRpc(2);
                permisoServerRpc(true);
                mana -= 30 * rangoexp ;
                manarestServerRpc(30 * rangoexp);
                fuesound.Play();
                turbobar += 25;
                turborestServerRpc(25);
                ataque = Random.Range(15,20) * fuerza;
                ataquemServerRpc(ataque);
                atb = 0;
                baseanim.SetBool("atkfue", true);
                
                dano = Random.Range(0,3);
                botcl.Play();
                botno.Stop();

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(30 * rangoexp),textDatamana);  

                dtext.CreateText(ev1.transform.position,"+"+(int)(25),textDataturbomas);
                mostrarServerRpc(2);
                temp4 = 0;
                
            }
            else if (rapfue == true && atb == 100 && mana >= 50 * rangoexp  && permiso == false && enemigo.permiso == false)
            {
                activar = true;
                permiso = true;
                permisoServerRpc(true);
                atkServerRpc(3);
                mana -= 50 * rangoexp ;
                manarestServerRpc(50 * rangoexp);
                rapfuesound.Play();
                turbobar += 50;
                turborestServerRpc(50);
                ataque = Random.Range(37,40) * fuerza;
                ataquemServerRpc(ataque);
                atb = 0;
                baseanim.SetBool("atkrapfue", true);
                
                dano = Random.Range(0,3);
                botcl.Play();
                botno.Stop();

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(50 * rangoexp),textDatamana);  

                dtext.CreateText(ev1.transform.position,"+"+(int)(50),textDataturbomas);
                mostrarServerRpc(2);
                temp4 = 0;
                
            }
            else if (turbo == true && atb == 100 && turbobar == 100 && permiso == false && enemigo.permiso == false)
            {
                activar = true;
                permiso = true;
                permisoServerRpc(true);
                atkServerRpc(4);
                turbobar = 0;
                turborestServerRpc(100);
                turbosound.Play();
                ataque = Random.Range(40,50) * fuerza;
                ataquemServerRpc(ataque);
                atb = 0;
                baseanim.SetBool("atkturbo", true);
                
                dano = Random.Range(0,3);
                botcl.Play();
                botno.Stop();

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(100),textDataturbomenos);
                mostrarServerRpc(3);
                temp4 = 0;
                
            }
            else if (turbo == true || rapfue == true || fuerte == true || rapido == true)
            {
                botno.Play();
                
            }
            else
            {
                baseanim.SetBool("atkrapfue", false);
                baseanim.SetBool("atkvel", false);
                baseanim.SetBool("atkfue", false);
                baseanim.SetBool("atkturbo", false);

        

            }
            if (def == true && mana >= 5  * rangoexp && permiso == false)
            {

                if(botebool == false)
                {bote.Play();}
                botno.Stop();
                botebool = true;
                mana -= 8.5f  * rangoexp * Time.deltaTime;
                turbobar += 5f * Time.deltaTime;
                prot.enabled = false;
                escudo.gameObject.SetActive(true);
                if(tempdtext > 1f)
                {
                    DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                    dtext.CreateText(ev1.transform.position,("-"+(8.5 * rangoexp)),textDatamana);
                    tempdtext = 0;
                    mostrar2ServerRpc(4);
                }
                tempdtext += 1 * Time.deltaTime;
                defServerRpc(true);
                defusar = true;
            }
            else if (def == true && mana > 0  && mana < 5  * rangoexp && permiso == false && defusar == true)
            {
                mana -= 8.5f  * rangoexp * Time.deltaTime;
                turbobar += 5f * Time.deltaTime;
                prot.enabled = false;
                escudo.gameObject.SetActive(true);
                if(tempdtext > 1f)
                {
                    DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                    dtext.CreateText(ev1.transform.position,("-"+(8.5 * rangoexp)),textDatamana);
                    tempdtext = 0;
                    mostrar2ServerRpc(4);
                }
                tempdtext += 1 * Time.deltaTime;
                defServerRpc(true);
            }
            else if(def == true && mana < 5 * rangoexp && defusar == false)
            {botno.Play();}
            else if(client == 2)
            {   
                botebool = false;
                bote.Stop();
                defusar = false;
                prot.enabled = true;
                
                if (mana < manamax)
                {
                    mana+= 1.5f * manarec * Time.deltaTime;
                    if(tempdtext > 1f)
                    {
                        DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                        dtext.CreateText(ev1.transform.position,("+"+(1.5f * manarec)),textDatamanamas);
                        tempdtext = 0;
                        mostrar2ServerRpc(5);
                    }
                }
                tempdtext += 1 * Time.deltaTime;
                escudo.gameObject.SetActive(false);
                defServerRpc(false);
            
            }
            
            

            if (temp < 15)
            {temp += 1 * Time.deltaTime;}
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

            }

            if(mostrarr.Value == 1 && client == 2 && tempdtext > 0.1f)
            {
                int ataqued = (int)heroe2.ataquem.Value;
                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position, "-"+ataqued.ToString(),textDatadano);  
                mostrarServerRpc(0);
                tempdtext = 0;
            }
            if(mostrarr.Value == 2 && client == 1)
            {
                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(manarest.Value),textDatamana);

                dtext.CreateText(ev1.transform.position,"+"+(int)(turborest.Value),textDataturbomas);
                mostrarServerRpc(0);
            }
            if(mostrarr.Value == 3 && client == 1)
            {
                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(turborest.Value),textDataturbomenos);
                mostrarServerRpc(0);
            }
            if(mostrarr2.Value == 4 && client == 1)
            {

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,("-"+(8.5 * rangor.Value)),textDatamana);
                mostrar2ServerRpc(0);
            }
            if(mostrarr2.Value == 5 && client == 1)
            {
                
                
                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,("+"+(1.5f * manarecr.Value)),textDatamanamas);
                mostrar2ServerRpc(0);

            }
            if(client == 2)
            {
                tempdtext += 1 * Time.deltaTime;
            }
            mehp.text = "vit "+(int)hp+" / " + hpmax;
            memana.text = "Stamina "+(int)mana+" / " + manamax;


            if (atb < 100)
            {atb += 15 * Time.deltaTime;}
            if (atb > 99) {atb = 100;}
        }
        mename.text = hname;
    

        if(client == 1 && defr.Value == true)
        {
            prot.enabled = false;
            escudo.gameObject.SetActive(true);
        }
        if(client == 1 && defr.Value == false)
        {
            prot.enabled = true;
            escudo.gameObject.SetActive(false);
        }
        if(client == 2)
        {
            cargadatos2ServerRpc(mana,turbobar,atb);
        }
        if(client == 2)
        {
            inv.datosserial.nivelene = (int)enemigo.nivel;
            inv.datosserial.rangoene = enemigo.rango;
        }
        }
        if(client == 2)
        {rapfue = false;
        fuerte = false;
        rapido = false;
        turbo = false;}
        if (temp4 < 15)
        {temp4 += 1 * Time.deltaTime;}
        
    }
    [ServerRpc(RequireOwnership = false)]
    private void cargadatosServerRpc(float hpc,float manac,float manarecc,float fuerzac,string hnamec,string bichoc,float turboc,float atbc,float hpmaxc,float manamaxc,float nvc,float rangoc,float clasec)
    {
        hpr.Value = hpc;
        manar.Value = manac;
        manarecr.Value = manarecc;
        fuerzar.Value = fuerzac;
        hnamer.Value = hnamec;
        bichor.Value = bichoc;
        turbor.Value = turboc;
        atbr.Value = atbc;
        hpmaxr.Value = hpmaxc;
        manamaxr.Value = manamaxc;
        nivelr.Value = nvc;
        rangor.Value = rangoc;
        claser.Value = clasec;
    }

    [ServerRpc(RequireOwnership = false)]
    private void cargadatos2ServerRpc(float manac,float turboc,float atbc)
    {
        manar.Value = manac;
        turbor.Value = turboc;
        atbr.Value = atbc;
    }



    [ServerRpc(RequireOwnership = false)]
    public void defServerRpc(bool defrc)
    {
        defr.Value = defrc;
    }
    [ServerRpc(RequireOwnership = false)]
    public void atkServerRpc(int tipo)
    {
       atkr.Value = tipo;
    }
    [ServerRpc]
    public void golpeServerRpc(float atk)
    {
       hpr.Value -= atk;
    }


    public void modelos()
    {
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
    [ServerRpc(RequireOwnership = false)]
    public void permisoServerRpc(bool permisoc)
    {
        permisor.Value = permisoc;
    }
    [ServerRpc(RequireOwnership = false)]
    public void ataquemServerRpc(float ataquem1)
    {
        ataquem.Value = ataquem1;
    }
    [ServerRpc(RequireOwnership = false)]
    public void mostrarServerRpc(int mostrar)
    {
        mostrarr.Value = mostrar;
    }
    [ServerRpc(RequireOwnership = false)]
    public void mostrar2ServerRpc(int mostrar)
    {
        mostrarr2.Value = mostrar;
    }

    [ServerRpc(RequireOwnership = false)]
    public void manarestServerRpc(float manarestc)
    {
        manarest.Value = manarestc;
    }

    [ServerRpc(RequireOwnership = false)]
    public void turborestServerRpc(float turborestc)
    {
        turborest.Value = turborestc;
    }

    
    

}
