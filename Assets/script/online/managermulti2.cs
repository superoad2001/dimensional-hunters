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
        client = PlayerPrefs.GetInt("clientid",0);
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
        client = PlayerPrefs.GetInt("clientid",0);
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
        {   client = PlayerPrefs.GetInt("clientid",0);
            if(client == 1)
            {
            PlayerPrefs.SetString("namesave"+intercambio1.o ,intercambio2.hname);
            PlayerPrefs.SetFloat("hpsave"+intercambio1.o,intercambio2.hp);
            PlayerPrefs.SetFloat("manasave"+intercambio1.o,intercambio2.mana);
            PlayerPrefs.SetFloat("manarecsave"+intercambio1.o,intercambio2.manarec);
            PlayerPrefs.SetFloat("fuerzasave"+intercambio1.o,intercambio2.fuerza);
            PlayerPrefs.SetFloat("nivelsave"+intercambio1.o,intercambio2.nivel);
            PlayerPrefs.SetString("elementosave"+intercambio1.o,intercambio2.elemento);
            PlayerPrefs.SetString("bichosmiossave"+intercambio1.o,intercambio2.bicho);
            PlayerPrefs.SetFloat("expsave"+intercambio1.o,intercambio2.exp);
            }
            if(client == 2)
            {

            PlayerPrefs.SetString("namesave"+intercambio2.o ,intercambio1.hname);
            PlayerPrefs.SetFloat("hpsave"+intercambio2.o,intercambio1.hp);
            PlayerPrefs.SetFloat("manasave"+intercambio2.o,intercambio1.mana);
            PlayerPrefs.SetFloat("manarecsave"+intercambio2.o,intercambio1.manarec);
            PlayerPrefs.SetFloat("fuerzasave"+intercambio2.o,intercambio1.fuerza);
            PlayerPrefs.SetFloat("nivelsave"+intercambio2.o,intercambio1.nivel);
            PlayerPrefs.SetString("elementosave"+intercambio2.o,intercambio1.elemento);
            PlayerPrefs.SetString("bichosmiossave"+intercambio2.o,intercambio1.bicho);
            PlayerPrefs.SetFloat("expsave"+intercambio2.o,intercambio1.exp);
            }
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
