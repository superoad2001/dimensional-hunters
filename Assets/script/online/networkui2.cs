using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using System.Net;
using System.Net.Sockets;


public class networkui2 : NetworkBehaviour
{


    public Text input;
    public Text input1;
    public Text input2;
    public Text input3;
    public Text codigo;
    public managermulti2 manamulti;


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
		InvokeRepeating("assignPlayerController", 0.1f, 0.1f);
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

        NetworkManager.Singleton.StartHost();
        GetLocalIPAddress();
        activar = true;
        manamulti.check1.Value = true;
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
        manamulti.check2i = true;
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
        manamulti.check1i = false;
        manamulti.check2i = false;

        
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
