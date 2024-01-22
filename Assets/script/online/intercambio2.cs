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
    public float clase;
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

    public NetworkVariable<float> claser = new NetworkVariable<float>(0, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public NetworkVariable<float> nivelr = new NetworkVariable<float>(1, 
    NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public int client;

    
    // Start is called before the first frame update
    public void Start()
    {   
        
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        hp = inv.datosserial.hps;
        mana = inv.datosserial.manas;
        manarec = inv.datosserial.manarecs;
        fuerza = inv.datosserial.fuerzas;
        rango = inv.datosserial.rangors;
        clase = inv.datosserial.clases;
        hname = inv.datosserial.names;
        bicho = inv.datosserial.razas;
        nivel = inv.datosserial.nivels;
        exp = inv.datosserial.varsel1;
        elemento = inv.datosserial.elementos;
        o = inv.datosserial.varsel1;

        
    }
    // Update is called once per frame

    public void Update()
    {   
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        client = inv.datosserial.client;
    if(carga == false && managermulti.comenzar.Value == true)
    {
        carga = true;
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
        exp = inv.datosserial.varsel1;
        elemento = inv.datosserial.elementos;
        o = inv.datosserial.varsel1;
        
        cargadatosServerRpc(hp,mana,manarec,fuerza,rango,clase,nivel,exp,hname,bicho,elemento);
        }
        

        
    }
        hp = hpr.Value;
        mana = manar.Value;
        manarec = manarecr.Value;
        fuerza = fuerzar.Value;
        rango = rangor.Value;
        clase = claser.Value;
        hname = hnamer.Value.ToString();
        bicho = bichor.Value.ToString();
        nivel = nivelr.Value;
        exp = expr.Value;
        elemento = elementor.Value.ToString();

        
    }
    [ServerRpc(RequireOwnership = false)]
    public void cargadatosServerRpc(float hpc,float manac,float manarecc,float fuerzac,float rangoc,float clasec,float nivelc,float expc,string namec,string bichoc,string elementoc)
    {
        hpr.Value = hpc;
        manar.Value = manac;
        manarecr.Value = manarecc;
        fuerzar.Value = fuerzac;
        rangor.Value = rangoc;
        claser.Value = clasec;
        hnamer.Value = namec;
        bichor.Value = bichoc;
        nivelr.Value = nivelc;
        expr.Value = expc;
        elementor.Value = elementoc;
    }




}

