using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;


public class networkui : NetworkBehaviour
{


    public heromulti heroe;
    public heromulti2 heroe2;
    public Text input;
    public Text codigo;
    public managermulti manamulti;

    public Unity.Netcode.Transports.UTP.UnityTransport.ConnectionAddressData UnityTransport;

    public bool activar = false;

    
    // Start is called before the first frame update
    void Start()
    {
        codigo.text = "";
    }
    // Update is called once per frame
    
    void Update()
    {
        if(IsOwner)
        {
        if(NetworkManager.Singleton.ConnectedClients.Count == 2)
        {
            manamulti.check2.Value = true;
        }
        }
        if(IsOwner){
        Debug.Log("clientes: "+NetworkManager.Singleton.ConnectedClients.Count);}
    }
    public void starthost()
    {
        if(activar == false)
        {
        int en = Random.Range(1000,9999);
        UnityTransport.Address = "C"+en.ToString();
        NetworkManager.Singleton.StartHost();
        codigo.text = "CODIGO DE SALA:"+ UnityTransport.Address;
        activar = true;
        heroe.carga = false;
        manamulti.check1.Value = true;
        }
    }
    public void startclient()
    {
        if(activar == false && input.text != "")
        {
        UnityTransport.ServerListenAddress = "C"+input.text;
        NetworkManager.Singleton.StartClient();
        activar = true;
        heroe2.carga = false;
        manamulti.check2c = true;
        }
    }


    public void apagar()
    {
        activar = false;
        heroe.carga = false;
        heroe2.carga = false;
        codigo.text = "";
        if(IsOwner == true)
        {manamulti.check1.Value = false;
        manamulti.check2.Value = false;}
        NetworkManager.Singleton.Shutdown();
        manamulti.check1c = false;
        manamulti.check2c = false;

        
    }

}
