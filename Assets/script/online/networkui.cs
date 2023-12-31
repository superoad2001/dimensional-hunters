using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using System.Net;
using System.Net.Sockets;
using Unity.Netcode.Transports.UTP;


public class networkui : NetworkBehaviour
{


    public heromulti heroe;
    public heromulti2 heroe2;
    public Text input;
    public Text input1;
    public Text input2;
    public Text input3;
    public Text codigo;
    public managermulti manamulti;
    public int client;

    public Unity.Netcode.Transports.UTP.UnityTransport.ConnectionAddressData UnityTransport;

    public bool activar = false;
    private bool pcAssigned;

    [SerializeField] string ipAddress;

    [SerializeField] UnityTransport transport;

    
    // Start is called before the first frame update
    void Start()
    {
        codigo.text = "";
        ipAddress = "0.0.0.0";
		SetIpAddress(); // Set the Ip to the above address
		pcAssigned = false;
    }
    // Update is called once per frame
    
    void Update()
    {
        if(IsOwner)
        {
        if(NetworkManager.Singleton.ConnectedClients.Count == 2)
        {
            manamulti.checkServerRpc(manamulti.check1.Value,true);
        }
        }
        if(IsOwner){
        Debug.Log("clientes: "+NetworkManager.Singleton.ConnectedClients.Count);}
    }
    public void starthost()
    {
        if(activar == false)
        {
        NetworkManager.Singleton.StartHost();
        GetLocalIPAddress();
        activar = true;
        manamulti.checkServerRpc(true,manamulti.check1.Value);
        PlayerPrefs.SetInt("clientid",1);
        }
        
    }
    public void startclient()
    {
        if(activar == false && input.text != ""  && input1.text != ""  && input2.text != ""  && input3.text != "")
        {
        ipAddress = input.text+"."+input1.text+"."+input2.text+"."+input3.text;
		SetIpAddress();
        NetworkManager.Singleton.StartClient();
        activar = true;
        PlayerPrefs.SetInt("clientid",2);
        }
    }


    public void apagar()
    {
        activar = false;
        heroe.carga = false;
        heroe2.carga = false;
        codigo.text = "";
        manamulti.checkServerRpc(false,false);
        NetworkManager.Singleton.Shutdown();
        PlayerPrefs.SetInt("clientid",0);

        
    }
    public string GetLocalIPAddress() {
		var host = Dns.GetHostEntry(Dns.GetHostName());
		foreach (var ip in host.AddressList) {
			if (ip.AddressFamily == AddressFamily.InterNetwork) {
				codigo.text = "IP: "+ ip.ToString();
				ipAddress = ip.ToString();
				return ip.ToString();
			}
		}
		throw new System.Exception("No network adapters with an IPv4 address in the system!");
	}
    public void SetIpAddress() {
		transport = NetworkManager.Singleton.GetComponent<UnityTransport>();
		transport.ConnectionData.Address = ipAddress;
	}

}
