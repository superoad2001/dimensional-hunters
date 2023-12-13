using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Collections;
using Unity.Netcode;


public class heromulti2  : NetworkBehaviour
{
    
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

    public string hname;
    public string bicho;
    public float hp;
    public float mana;
    public float manarec;
    public float fuerza;

    public float nivel;

    public NetworkVariable<bool> defr = new NetworkVariable<bool>(false, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);










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

    public GameObject escudo;



    public int hpmax;
    public int manamax;

    public Animator baseanim;
    
    public GameObject ev1;

    public RuntimeAnimatorController madcatanim1;
    public RuntimeAnimatorController shitanim1;
    public RuntimeAnimatorController topoanim1;
    public RuntimeAnimatorController skybirdanim1;


    public GameObject madcat1;
    public GameObject shitfloor;
    public GameObject topo;
    public GameObject skybird;

    public managermulti managermulti;

    public bool carga;

    
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
        if(IsOwner)
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
        if(carga == false && managermulti.comenzar.Value == true)
        {
        carga = true;
        
        if(!IsOwner)
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

        cargadatosServerRpc(hp,mana,manarec,fuerza,hname,bicho,turbobar,atb,hpmax,manamax,nivel);

    
        }
        if(IsOwner)
        {
        hp = hpr.Value;
        mana = manar.Value;
        manarec = manarecr.Value;
        fuerza = fuerzar.Value;
        hname = hnamer.Value.ToString();
        bicho = bichor.Value.ToString();
        hpmax = (int)hpmaxr.Value;
        manamax = (int)manamaxr.Value;
        }
        modelos();

        carga = true;
        }




        managerdecombatemulti manager = UnityEngine.Object.FindObjectOfType<managerdecombatemulti>();
        if(managermulti.comenzar.Value == true)
        {
        if(IsOwner && manager.comienzo == false)
        {
            modelos();
        }
        if(!IsOwner)
        {
            permiso = permisor.Value;
        }
        hp = hpr.Value;
        if(IsOwner)
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
            if(!IsOwner)
            {
            baseanim.SetBool("atkrapfue", false);
            baseanim.SetBool("atkvel", false);
            baseanim.SetBool("atkfue", false);
            baseanim.SetBool("atkturbo", false);

            if (rapido == true && atb == 100 && mana >= 20 && permiso == false && enemigo.permiso == false)
            {
                activar = true;
                permiso = true;
                atkServerRpc(1);
                mana -= 20;
                turbobar += 10;
                ataque = Random.Range(10,16) * fuerza;
                atb = 0;
                rapsound.Play();
                baseanim.SetBool("atkvel", true);
            
                dano = Random.Range(0,3);
                botcl.Play();
                
            }
            else if (fuerte == true && atb == 100 && mana >= 30 && permiso == false && enemigo.permiso == false)
            {
            
                activar = true;
                permiso = true;
                atkServerRpc(2);
                mana -= 30;
                fuesound.Play();
                turbobar += 15;
                ataque = Random.Range(16,20) * fuerza;
                atb = 0;
                baseanim.SetBool("atkfue", true);
                
                dano = Random.Range(0,3);
                botcl.Play();
                botno.Stop();
                
            }
            else if (rapfue == true && atb == 100 && mana >= 40 && permiso == false && enemigo.permiso == false)
            {
                activar = true;
                permiso = true;
                atkServerRpc(3);
                mana -= 50;
                rapfuesound.Play();
                turbobar += 35;
                ataque = Random.Range(18,25) * fuerza;
                atb = 0;
                baseanim.SetBool("atkrapfue", true);
                
                dano = Random.Range(0,3);
                botcl.Play();
                botno.Stop();
                
            }
            else if (turbo == true && atb == 100 && turbobar == 100 && permiso == false && enemigo.permiso == false)
            {
                activar = true;
                permiso = true;
                atkServerRpc(4);
                turbobar = 0;
                turbosound.Play();
                ataque = Random.Range(40,50) * fuerza;
                atb = 0;
                baseanim.SetBool("atkturbo", true);
                
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
                escudo.gameObject.SetActive(true);
                defServerRpc(true);
                defusar = true;
            }
            else if (def == true && mana > 0  && mana < 5 && permiso == false && defusar == true)
            {
                mana -= 3.5f * Time.deltaTime;
                turbobar += 0.7f * Time.deltaTime;
                prot.enabled = false;
                escudo.gameObject.SetActive(true);
                defServerRpc(true);
            }
            else if(def == true)
            {botno.Play();}
            else if(!IsOwner)
            {   
                botebool = false;
                bote.Stop();
                defusar = false;
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
                if(mana > 75)
                {
                    if (mana < manamax)
                    {mana+= 4f * manarec * Time.deltaTime;}
                }
                escudo.gameObject.SetActive(false);
                defServerRpc(false);
            
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
    

        if(IsOwner && defr.Value == true)
        {
            prot.enabled = false;
            escudo.gameObject.SetActive(true);
        }
        if(IsOwner && defr.Value == false)
        {
            prot.enabled = true;
            escudo.gameObject.SetActive(false);
        }
        if(!IsOwner)
        {
            cargadatos2ServerRpc(mana,turbobar,atb,permiso);
        }
        if(!IsOwner)
        {
            PlayerPrefs.SetFloat("nivelg",enemigo.nivel);
        }
        }
        if (temp4 < 15)
        {temp4 += 1 * Time.deltaTime;}
        
    }
    [ServerRpc(RequireOwnership = false)]
    private void cargadatosServerRpc(float hpc,float manac,float manarecc,float fuerzac,string hnamec,string bichoc,float turboc,float atbc,float hpmaxc,float manamaxc,float nvc)
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
    }

    [ServerRpc(RequireOwnership = false)]
    private void cargadatos2ServerRpc(float manac,float turboc,float atbc,bool permisoc)
    {
        permisor.Value = permisoc;
        manar.Value = manac;
        turbor.Value = turboc;
        atbr.Value = atbc;
    }



    [ServerRpc(RequireOwnership = false)]
    public void defServerRpc(bool defrc)
    {
        defr.Value = defrc;
    }
    public void _golpe(float atk)
    {
        hpr.Value -= atk;
    }
    [ServerRpc(RequireOwnership = false)]
    public void atkServerRpc(int tipo)
    {
       atkr.Value = tipo;
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
    }
    [ServerRpc(RequireOwnership = false)]
    public void permisoServerRpc(bool permisoc)
    {
        permisor.Value = permisoc;
    }

    
    

}
