using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class managermulti2 : NetworkBehaviour
{
    public GameObject menu;
    public GameObject combate;
    public GameObject botones;
    public int client;


    public Text listo;

    public bool carga;
 
        public NetworkVariable<bool> comenzar = new NetworkVariable<bool>(false);
        public NetworkVariable<bool> cambio = new NetworkVariable<bool>(false);
        public NetworkVariable<bool> check1 = new NetworkVariable<bool>(false);
        public NetworkVariable<bool> check2 = new NetworkVariable<bool>(false);

        public bool check1i;
        public bool check2i;

        public float temp;

        public intercambio1 intercambio1;

        public intercambio2 intercambio2;
        

    // Start is called before the first frame update
    public void Start()
    {
        listo.text = "Se Host o Cliente";
    }
    public void atras()
    {
        SceneManager.LoadScene("combatemenumulti");
        
    }
    public void iniciar()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        client = inv.datosserial.client;
        if(client == 1 && check2i == true && check1i == true)
        {
            cambiarServerRpc(true,true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(NetworkManager.Singleton.IsConnectedClient)
        {
        check1i = check1.Value;
        check2i = check2.Value;
        }
        client = inv.datosserial.client;
        if(client == 1 && check2i == true && check1i == true)
        {
            listo.text = "efectuar intercambio";
        }
        if(client == 2 &&  check2i == true && check1i == true)
        {
            listo.text = "Esperando que el host comienze la partida";
        }
        if(client == 1 && check2i == false && check1i == true)
        {
            listo.text = "Esperando al Rival";
        }
        if(client == 2 && check2i == true && check1i == false)
        {
            listo.text = "Esperando al Host";
        }
        if(client == 0 && check2i == false && check1i == false)
        {
            listo.text = "Se Host o Cliente";
        }
        if(comenzar.Value == true && carga == false)
        {
            temp = 0;
            carga = true;
        }
        if(temp > 1 && comenzar.Value == true)
        {   
            client = inv.datosserial.client;
            if(client == 1)
            {
                inv.datosserial.nameinter = intercambio2.hname;
                inv.datosserial.hpinter = intercambio2.hp;
                inv.datosserial.manainter = intercambio2.mana;
                inv.datosserial.manarecinter = intercambio2.manarec;
                inv.datosserial.fuerzainter = intercambio2.fuerza;
                inv.datosserial.nivelinter = intercambio2.nivel;
                inv.datosserial.elementointer = intercambio2.elemento;
                inv.datosserial.razainter = intercambio2.bicho;
                inv.datosserial.expinter = intercambio2.exp;
                inv.datosserial.rangorinter = intercambio2.rango;
                inv.datosserial.claseinter = intercambio2.clase;
            }
            if(client == 2)
            {

                inv.datosserial.nameinter2 = intercambio1.hname;
                inv.datosserial.hpinter2 = intercambio1.hp;
                inv.datosserial.manainter2 = intercambio1.mana;
                inv.datosserial.manarecinter2 = intercambio1.manarec;
                inv.datosserial.fuerzainter2 = intercambio1.fuerza;
                inv.datosserial.nivelinter2 = intercambio1.nivel;
                inv.datosserial.elementointer2 = intercambio1.elemento;
                inv.datosserial.razainter2 = intercambio1.bicho;
                inv.datosserial.expinter2 = intercambio1.exp;
                inv.datosserial.rangorinter2 = intercambio1.rango;
                inv.datosserial.claseinter2 = intercambio1.clase;
            }
            inv.guardar();
            SceneManager.LoadScene("combatemenumulti");


        }else{temp += 1 * Time.deltaTime;}
    }
    [ServerRpc(RequireOwnership = false)]
    public void cambiarServerRpc(bool cambioc, bool comenzarc)
    {
        cambio.Value = cambioc;
        comenzar.Value = comenzarc;
    }
    [ServerRpc(RequireOwnership = false)]
    public void checkServerRpc(bool check1c, bool check2c)
    {
        check1.Value = check1c;
        check2.Value = check2c;
    }
}
