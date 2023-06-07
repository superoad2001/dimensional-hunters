using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class managermulti : NetworkBehaviour
{
    public GameObject menu;
    public GameObject combate;
    public GameObject botones;

    public heromulti heroe;
    public heromulti2 heroe2;

    public Text listo;



 
        public bool comenzar ;
        public bool cambio ;
        public bool check1 ;
        public bool check2;
    // Start is called before the first frame update
    public void Start()
    {
        
    }
    public void iniciar()
    {
        if(IsOwner && check2 == true && check1 == true)
        {
            cambio = true;
            comenzar = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(NetworkManager.IsHost && check2 == true && check1 == true)
        {
            listo.text = "Comenzar";
        }
        if(NetworkManager.IsHost == false && check2 == true && check1 == true)
        {
            listo.text = "Esperando que el host comienze la partida";
        }
        if(NetworkManager.IsHost && check2 == false && check1 == true)
        {
            listo.text = "Esperando al Rival";
        }
        if(NetworkManager.IsHost == false && check2 == true && check1 == false)
        {
            listo.text = "Esperando al Host";
        }
        if(check2 == false && check1 == false)
        {
            listo.text = "Se Host o Cliente";
        }
        if(cambio == true)
        {
            menu.SetActive(false);
            combate.SetActive(true);
        }
    }
}
