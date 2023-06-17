using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;


public class networkui2 : NetworkBehaviour
{


    public Text input;
    public Text codigo;
    public managermulti2 manamulti;

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
        UnityTransport.Address = Random.Range(10000,99999).ToString();
        NetworkManager.Singleton.StartHost();
        codigo.text = "CODIGO DE SALA:"+ UnityTransport.Address;
        activar = true;
        manamulti.check1.Value = true;
        }
    }
    public void startclient()
    {
        if(activar == false && input.text != "")
        {
        UnityTransport.ServerListenAddress = input.text;
        NetworkManager.Singleton.StartClient();
        activar = true;
        manamulti.check2c = true;
        }
    }


    public void apagar()
    {
        activar = false;
        codigo.text = "";
        if(IsOwner == true)
        {manamulti.check1.Value = false;
        manamulti.check2.Value = false;}
        NetworkManager.Singleton.Shutdown();
        manamulti.check1c = false;
        manamulti.check2c = false;

        
    }

}
