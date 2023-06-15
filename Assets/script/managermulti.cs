using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using UnityEngine.Networking;

public class managermulti : NetworkBehaviour
{
    public GameObject menu;
    public GameObject combate;
    public GameObject botones;

    public heromulti heroe;
    public heromulti2 heroe2;

    public Text listo;
 
        public NetworkVariable<bool> comenzar = new NetworkVariable<bool>(false);
        public NetworkVariable<bool> cambio = new NetworkVariable<bool>(false);
        public NetworkVariable<bool> check1 = new NetworkVariable<bool>(false);
        public NetworkVariable<bool> check2 = new NetworkVariable<bool>(false);

        public bool check1c;
        public bool check2c;
    // Start is called before the first frame update
    public void Start()
    {
        
    }
    
    public void iniciar()
    {
        if(IsOwner && check2c == true && check1c == true)
        {
            cambio.Value = true;
            comenzar.Value = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        check1c = check1.Value;
        check2c = check2.Value;
        if(NetworkManager.IsHost && check2c == true && check1c == true)
        {
            listo.text = "Comenzar";
        }
        if(NetworkManager.IsHost == false && check2c == true && check1c == true)
        {
            listo.text = "Esperando que el host comienze la partida";
        }
        if(NetworkManager.IsHost && check2c == false && check1c == true)
        {
            listo.text = "Esperando al Rival";
        }
        if(NetworkManager.IsHost == false && check2c == true && check1c == false)
        {
            listo.text = "Esperando al Host";
        }
        if(check2c == false && check1c == false)
        {
            listo.text = "Se Host o Cliente";
        }
        if(cambio.Value == true)
        {
            menu.SetActive(false);
            combate.SetActive(true);
        }
    }
}
