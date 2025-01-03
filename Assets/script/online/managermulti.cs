using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class managermulti : NetworkBehaviour
{
    public GameObject menu;
    public GameObject combate;


    public heromulti heroe;
    public heromulti2 heroe2;

    public Text listo;
    public int client;
 
        public NetworkVariable<bool> comenzar = new NetworkVariable<bool>(false);
        public NetworkVariable<bool> cambio = new NetworkVariable<bool>(false);
        public NetworkVariable<bool> check1 = new NetworkVariable<bool>(false);
        public NetworkVariable<bool> check2 = new NetworkVariable<bool>(false);

        public bool check1c;
        public bool check2c;
    // Start is called before the first frame update
    public void Start()
    {
        listo.text = "Se Host o Cliente";
    }
    
    public void iniciar()
    {
        
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        client = inv.datosserial.client;
        if(client == 1 && check2c == true && check1c == true)
        {
            cambiarServerRpc(true,true);
        }
        
    }
    public void atras()
    {
        SceneManager.LoadScene("combatemenumulti");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(NetworkManager.Singleton.IsConnectedClient)
        {
            check1c = check1.Value;
            check2c = check2.Value;
        }
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        client = inv.datosserial.client;
        if(client == 1 && check2c == true && check1c == true)
        {
            listo.text = "Comenzar";
        }
        if(client == 2 && check2c == true && check1c == true)
        {
            listo.text = "Esperando que el host comienze la partida";
        }
        if(client == 1 && check2c == false && check1c == true)
        {
            listo.text = "Esperando al Rival";
        }
        if(client == 2 && check2c == true && check1c == false)
        {
            listo.text = "Esperando al Host";
        }
        if(client == 0 && check2c == false && check1c == false)
        {
            listo.text = "Se Host o Cliente";
        }
        if(cambio.Value == true)
        {
            menu.SetActive(false);
            combate.SetActive(true);
        }
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
