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


    public Text listo;
 
        public NetworkVariable<bool> comenzar = new NetworkVariable<bool>(false);
        public NetworkVariable<bool> cambio = new NetworkVariable<bool>(false);
        public NetworkVariable<bool> check1 = new NetworkVariable<bool>(false);
        public NetworkVariable<bool> check2 = new NetworkVariable<bool>(false);

        public bool check1c;
        public bool check2c;

        public float temp;

        public intercambio1 intercambio1;

        public intercambio2 intercambio2;
        

    // Start is called before the first frame update
    public void Start()
    {
        
    }
    public void atras()
    {
        SceneManager.LoadScene("combatemenumulti");
        
    }
    public void iniciar()
    {
        if(IsOwner && check2c == true && check1c == true)
        {
            cambio.Value = true;
            comenzar.Value = true;
            temp = 0;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        check1c = check1.Value;
        check2c = check2.Value;
        if(NetworkManager.IsHost && check2c == true && check1c == true)
        {
            listo.text = "efectuar intercambio";
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
        if(temp > 3 && comenzar.Value == true)
        {   
            if(IsOwner)
            {
            inv.hp[intercambio1.o] = intercambio2.hp;
            inv.mana[intercambio1.o] = intercambio2.mana;
            inv.manarec[intercambio1.o] = intercambio2.manarec;
            inv.fuerza[intercambio1.o] = intercambio2.fuerza;
            inv.name[intercambio1.o] = intercambio2.name;
            inv.bichosmios[intercambio1.o] = intercambio2.bicho;
            inv.elemento[intercambio1.o] = intercambio2.elemento;
            inv.exp[intercambio1.o] = intercambio2.exp;
            inv.nivel[intercambio1.o] = intercambio2.nivel;
            }
            if(!IsOwner)
            {
            inv.hp[intercambio2.o] = intercambio1.hp;
            inv.mana[intercambio2.o] = intercambio1.mana;
            inv.manarec[intercambio2.o] = intercambio1.manarec;
            inv.fuerza[intercambio2.o] = intercambio1.fuerza;
            inv.name[intercambio2.o] = intercambio1.name;
            inv.bichosmios[intercambio2.o] = intercambio1.bicho;
            inv.elemento[intercambio2.o] = intercambio1.elemento;
            inv.exp[intercambio2.o] = intercambio1.exp;
            inv.nivel[intercambio2.o] = intercambio1.nivel;
            }
            SceneManager.LoadScene("combatemenumulti");


        }else{temp += 1 * Time.deltaTime;}
    }
}
