using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using Unity.Collections;

public class intercambio2 : NetworkBehaviour 
{

    public bool carga;







    public string hname;
    public string bicho;
    public float hp;
    public float mana;
    public float manarec;
    public float fuerza;
    public float rango;
    public float nivel;

    public string elemento;

    public float exp;
    public managermulti2 managermulti;
    public float o;




    public NetworkVariable<FixedString64Bytes> hnamer = new NetworkVariable<FixedString64Bytes>(" ", 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<FixedString64Bytes> bichor = new NetworkVariable<FixedString64Bytes>(" ", 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<FixedString64Bytes> elementor = new NetworkVariable<FixedString64Bytes>(" ", 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> expr = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> hpr = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<float> manar = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<float> manarecr = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    public NetworkVariable<float> fuerzar = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> rangor = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> nivelr = new NetworkVariable<float>(1, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);


    
    // Start is called before the first frame update
    public void Start()
    {   
        
        
        hp = PlayerPrefs.GetFloat("hps", 100);
        mana = PlayerPrefs.GetFloat("manas", 100);
        manarec = PlayerPrefs.GetFloat("manarecs", 1);
        fuerza = PlayerPrefs.GetFloat("fuerzas", 1);
        rango = PlayerPrefs.GetFloat("rangos", 1);
        hname = (string)PlayerPrefs.GetString("names", "misigno");
        bicho = (string)PlayerPrefs.GetString("bichosh", "madcat");
        nivel = PlayerPrefs.GetFloat("nivelss", 1);
        exp = PlayerPrefs.GetFloat("exph", 0);
        elemento = (string)PlayerPrefs.GetString("elementoh", "nulo");
        o = PlayerPrefs.GetFloat("selec", 0);

        
    }
    // Update is called once per frame

    public void Update()
    {   
    if(carga == false && managermulti.comenzar.Value == true)
    {
        carga = true;
        if(!IsOwner)
        
        {
        hp = PlayerPrefs.GetFloat("hps", 100);
        mana = PlayerPrefs.GetFloat("manas", 100);
        manarec = PlayerPrefs.GetFloat("manarecs", 1);
        fuerza = PlayerPrefs.GetFloat("fuerzas", 1);
        rango = PlayerPrefs.GetFloat("rangos", 1);
        hname = (string)PlayerPrefs.GetString("names", "misigno");
        bicho = (string)PlayerPrefs.GetString("bichosh", "madcat");
        nivel = PlayerPrefs.GetFloat("nivelss", 1);
        exp = PlayerPrefs.GetFloat("exph", 0);
        elemento = (string)PlayerPrefs.GetString("elementoh", "nulo");
        o = PlayerPrefs.GetFloat("selec", 0);
        
        cargadatosServerRpc(hp,mana,manarec,fuerza,rango,nivel,exp,hname,bicho,elemento);
        }
        

        
    }
        hp = hpr.Value;
        mana = manar.Value;
        manarec = manarecr.Value;
        fuerza = fuerzar.Value;
        rango = rangor.Value;
        hname = hnamer.Value.ToString();
        bicho = bichor.Value.ToString();
        nivel = nivelr.Value;
        exp = expr.Value;
        elemento = elementor.Value.ToString();

        
    }
    [ServerRpc(RequireOwnership = false)]
    public void cargadatosServerRpc(float hpc,float manac,float manarecc,float fuerzac,float rangoc,float nivelc,float expc,string namec,string bichoc,string elementoc)
    {
        hpr.Value = hpc;
        manar.Value = manac;
        manarecr.Value = manarecc;
        fuerzar.Value = fuerzac;
        rangor.Value = rangoc;
        hnamer.Value = namec;
        bichor.Value = bichoc;
        nivelr.Value = nivelc;
        expr.Value = expc;
        elementor.Value = elementoc;
    }




}

