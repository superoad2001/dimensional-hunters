using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using Unity.Collections;


public class heromulti : NetworkBehaviour 
{


    public bool carga;
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
    public heromulti2 enemigo;

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

    public Text atbbar;
    public Text mehp;
    public Text memana;
    public Text mename;

    public Collider prot;
    public Collider prot2;
    public Collider prot3;

    public GameObject escudo;






    public string hname;
    public string bicho;
    public float hp;
    public float mana;
    public float manarec;
    public float fuerza;
    public float nivel;

    public int hpmax;
    public int manamax;

    public Animator baseanim;
    public Animator baseanim2;
    public Animator baseanim3;
    
    public GameObject ev1;
    public GameObject ev2;
    public GameObject ev3;

    public RuntimeAnimatorController madcatanim1;
    public RuntimeAnimatorController shitanim1;
    public RuntimeAnimatorController topoanim1;
    public RuntimeAnimatorController skybirdanim1;


    public GameObject madcat1;
    public GameObject shitfloor;
    public GameObject topo;
    public GameObject skybird;

    public GameObject madcat12;
    public GameObject shitfloor2;
    public GameObject topo2;
    public GameObject skybird2;

    public GameObject madcat13;
    public GameObject shitfloor3;
    public GameObject topo3;
    public GameObject skybird3;
    public managermulti managermulti;



    public NetworkVariable<FixedString64Bytes> hnamer = new NetworkVariable<FixedString64Bytes>(" ", 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<FixedString64Bytes> bichor = new NetworkVariable<FixedString64Bytes>(" ", 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> hpr = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<float> manar = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<float> manarecr = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<float> fuerzar = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<bool> defr = new NetworkVariable<bool>(false, 
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


    
    // Start is called before the first frame update
    public void Start()
    {   
        
        
        

        
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
    if(!IsOwner)
        {
            if(atkr.Value == 0)
            {
                baseanim.SetBool("atkrapfue", false);
                baseanim.SetBool("atkvel", false);
                baseanim.SetBool("atkfue", false);
                baseanim.SetBool("atkturbo", false);

                baseanim2.SetBool("atkrapfue", false);
                baseanim2.SetBool("atkvel", false);
                baseanim2.SetBool("atkfue", false);
                baseanim2.SetBool("atkturbo", false);

                baseanim3.SetBool("atkrapfue", false);
                baseanim3.SetBool("atkvel", false);
                baseanim3.SetBool("atkfue", false);
                baseanim3.SetBool("atkturbo", false);
            }
            if(atkr.Value == 1)
            {
                baseanim.SetBool("atkvel", true);
                baseanim2.SetBool("atkvel", true);
                baseanim3.SetBool("atkvel", true);
            }
            if(atkr.Value == 2)
            {
                baseanim.SetBool("atkfue", true);
                baseanim2.SetBool("atkfue", true);
                baseanim3.SetBool("atkfue", true);
            }
            if(atkr.Value == 3)
            {
                baseanim.SetBool("atkrapfue", true);
                baseanim2.SetBool("atkrapfue", true);
                baseanim3.SetBool("atkrapfue", true);
            }
            if(atkr.Value == 4)
            {
                baseanim.SetBool("atkturbo", true);
                baseanim2.SetBool("atkturbo", true);
                baseanim3.SetBool("atkturbo", true);
            }
        }
    if(carga == false && managermulti.comenzar.Value == true)
    {
        carga = true;
        if(IsOwner)
        
        {
        hp = PlayerPrefs.GetFloat("hps", 100);
        mana = PlayerPrefs.GetFloat("manas", 100);
        manarec = PlayerPrefs.GetFloat("manarecs", 1);
        fuerza = PlayerPrefs.GetFloat("fuerzas", 1);
        hname = (string)PlayerPrefs.GetString("names", "misigno");
        bicho = (string)PlayerPrefs.GetString("bichosh", "madcat");
        nivel = PlayerPrefs.GetFloat("nivelss", 1);
        hpmax = (int)hp;
        manamax = (int)mana;

        cargadatos();
        }
        hp = hpr.Value;
        mana = manar.Value;
        manarec = manarecr.Value;
        fuerza = fuerzar.Value;
        hname = hnamer.Value.ToString();
        bicho = bichor.Value.ToString();
        hpmax = (int)hpmaxr.Value;
        manamax = (int)manamaxr.Value;

        modelos();
        
    }
    managerdecombatemulti manager = UnityEngine.Object.FindObjectOfType<managerdecombatemulti>();
    if(managermulti.comenzar.Value == true)
    {
        if(IsOwner == false && manager.comienzo == false)
        {
            modelos();
        }
        if(IsOwner)
        {
            permiso = permisor.Value;
        }
        hp = hpr.Value;
        if(!IsOwner)
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
            if(IsOwner)
            {
            baseanim.SetBool("atkrapfue", false);
            baseanim.SetBool("atkvel", false);
            baseanim.SetBool("atkfue", false);
            baseanim.SetBool("atkturbo", false);

            baseanim2.SetBool("atkrapfue", false);
            baseanim2.SetBool("atkvel", false);
            baseanim2.SetBool("atkfue", false);
            baseanim2.SetBool("atkturbo", false);

            baseanim3.SetBool("atkrapfue", false);
            baseanim3.SetBool("atkvel", false);
            baseanim3.SetBool("atkfue", false);
            baseanim3.SetBool("atkturbo", false);
            if (rapido == true && atb == 100 && mana >= 20 && permiso == false && enemigo.permiso == false)
            {
                activar = true;
                permiso = true;
                atkr.Value = 1;
                mana -= 20;
                turbobar += 10;
                ataque = Random.Range(10,16) * fuerza;
                atb = 0;
                rapsound.Play();
                baseanim.SetBool("atkvel", true);
                baseanim2.SetBool("atkvel", true);
                baseanim3.SetBool("atkvel", true);
                dano = Random.Range(0,3);
                botcl.Play();
                
            }
            else if (fuerte == true && atb == 100 && mana >= 30 && permiso == false && enemigo.permiso == false)
            {
            
                activar = true;
                permiso = true;
                atkr.Value = 2;
                mana -= 30;
                fuesound.Play();
                turbobar += 15;
                ataque = Random.Range(16,20) * fuerza;
                atb = 0;
                baseanim.SetBool("atkfue", true);
                baseanim2.SetBool("atkfue", true);
                baseanim3.SetBool("atkfue", true);
                dano = Random.Range(0,3);
                botcl.Play();
                botno.Stop();
                
            }
            else if (rapfue == true && atb == 100 && mana >= 40 && permiso == false && enemigo.permiso == false)
            {
                activar = true;
                permiso = true;
                atkr.Value = 3;
                mana -= 50;
                rapfuesound.Play();
                turbobar += 35;
                ataque = Random.Range(18,25) * fuerza;
                atb = 0;
                baseanim.SetBool("atkrapfue", true);
                baseanim2.SetBool("atkrapfue", true);
                baseanim3.SetBool("atkrapfue", true);
                dano = Random.Range(0,3);
                botcl.Play();
                botno.Stop();
                
            }
            else if (turbo == true && atb == 100 && turbobar == 100 && permiso == false && enemigo.permiso == false)
            {
                activar = true;
                permiso = true;
                atkr.Value = 4;
                turbobar = 0;
                turbosound.Play();
                ataque = Random.Range(40,50) * fuerza;
                atb = 0;
                baseanim.SetBool("atkturbo", true);
                baseanim2.SetBool("atkturbo", true);
                baseanim3.SetBool("atkturbo", true);
                dano = Random.Range(0,3);
                botcl.Play();
                botno.Stop();
                
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

                baseanim2.SetBool("atkrapfue", false);
                baseanim2.SetBool("atkvel", false);
                baseanim2.SetBool("atkfue", false);
                baseanim2.SetBool("atkturbo", false);

                baseanim3.SetBool("atkrapfue", false);
                baseanim3.SetBool("atkvel", false);
                baseanim3.SetBool("atkfue", false);
                baseanim3.SetBool("atkturbo", false);
        

            }
            if (def == true && mana >= 5 && permiso == false && permiso == false)
            {

                if(botebool == false)
                {bote.Play();}
                botno.Stop();
                botebool = true;
                mana -= 3.5f * Time.deltaTime;
                turbobar += 0.7f * Time.deltaTime;
                prot.enabled = false;
                prot2.enabled = false;
                prot3.enabled = false;
                escudo.gameObject.SetActive(true);
                defr.Value = true;
                defusar = true;
            }
            else if (def == true && mana > 0  && mana < 5 && permiso == false && defusar == true)
            {
                mana -= 3.5f * Time.deltaTime;
                turbobar += 0.7f * Time.deltaTime;
                prot.enabled = false;
                prot2.enabled = false;
                prot3.enabled = false;
                escudo.gameObject.SetActive(true);
                defr.Value = true;
            }
            else if(def == true)
            {botno.Play();}
            else
            {   
                botebool = false;
                bote.Stop();
                defusar = false;
                prot.enabled = true;
                prot2.enabled = true;
                prot3.enabled = true;
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
                if(mana > 75)
                {
                    if (mana < manamax)
                    {mana+= 4f * manarec * Time.deltaTime;}
                }
                escudo.gameObject.SetActive(false);
                defr.Value = false;
            
            }
            
            
            

            if (temp < 15)
            {temp += 1 * Time.deltaTime;}
            rapfue = false;
            fuerte = false;
            rapido = false;
            turbo = false;

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

            mehp.text = "vit "+(int)hp+" / " + hpmax;
            memana.text = "Stamina "+(int)mana+" / " + manamax;


            if (atb < 100)
            {atb += 15 * Time.deltaTime;}
            if (atb > 99) {atb = 100;}
        }
        mename.text = hname;

        if(IsOwner == false && defr.Value == true)
        {
            prot.enabled = false;
            prot2.enabled = false;
            prot3.enabled = false;
            escudo.gameObject.SetActive(true);
        }
        if(IsOwner == false && defr.Value == false)
        {
            prot.enabled = true;
            prot2.enabled = true;
            prot3.enabled = true;
            escudo.gameObject.SetActive(false);
        }
        if(IsOwner)
        {
            cargadatos2();
        }
        if(IsOwner)
        {
            PlayerPrefs.SetFloat("nivelg",enemigo.nivel);
        }
        }
        if (temp4 < 15)
        {temp4 += 1 * Time.deltaTime;}

        
    }
    private void cargadatos()
    {
        hpr.Value = hp;
        manar.Value = mana;
        manarecr.Value = manarec;
        fuerzar.Value = fuerza;
        hnamer.Value = hname;
        bichor.Value = bicho;
        turbor.Value = turbobar;
        atbr.Value = atb;
        hpmaxr.Value = hpmax;
        manamaxr.Value = manamax;
        nivelr.Value = nivel;
    }
    private void cargadatos2()
    {
        permisor.Value = permiso;
        manar.Value = mana;
        turbor.Value = turbobar;
        atbr.Value = atb;
    }
    [ServerRpc(RequireOwnership = false)]
    public void golpeServerRpc(float atk)
    {
        hpr.Value -= atk;
    }
    public void _atk(int tipo)
    {
       atkr.Value = tipo;
    }
    public void modelos()
    {
        if(bicho == "madcat")
        {
            
            madcat1.SetActive(true);
            ev1.SetActive(true);
            madcat1.name = "madcat (1)";
            
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
            skybird.name = "skybird";
            
            baseanim.runtimeAnimatorController = skybirdanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }








        if(bicho == "happycat")
        {
            
            madcat12.SetActive(true);
            ev2.SetActive(true);
            madcat1.name = "madcat (1)";
            
            baseanim2.runtimeAnimatorController = madcatanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "shitplus")
        {
            shitfloor2.SetActive(true);
            ev2.SetActive(true);
            shitfloor.name = "shitfloor";
            
            baseanim2.runtimeAnimatorController = shitanim1;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "toto topo")
        {
            topo2.SetActive(true);
            ev2.SetActive(true);
            topo.name = "topo";
            
            baseanim2.runtimeAnimatorController = topoanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "sunbird")
        {
            skybird2.SetActive(true);
            ev2.SetActive(true);
            skybird.name = "skybird";
            
            baseanim2.runtimeAnimatorController = skybirdanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }




        if(bicho == "crazycat")
        {
            
            madcat13.SetActive(true);
            ev3.SetActive(true);
            madcat1.name = "madcat (1)";
            
            baseanim3.runtimeAnimatorController = madcatanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "shitplusplus")
        {
            shitfloor3.SetActive(true);
            ev3.SetActive(true);
            shitfloor.name = "shitfloor";
            
            baseanim3.runtimeAnimatorController = shitanim1;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "poro topo")
        {
            topo3.SetActive(true);
            ev3.SetActive(true);
            topo.name = "topo";
            
            baseanim3.runtimeAnimatorController = topoanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "moonbird")
        {
            skybird3.SetActive(true);
            ev3.SetActive(true);
            skybird.name = "skybird";
            
            baseanim3.runtimeAnimatorController = skybirdanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
    }
    public void _permiso(bool permisoc)
    {
        permisor.Value = permisoc;
    }
    
    

}
