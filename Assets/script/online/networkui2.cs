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

    public int client;

    [SerializeField] string ipAddress;

    [SerializeField] UnityTransport transport;

    
    // Start is called before the first frame update
    void Start()
    {
        codigo.text = "";
        ipAddress = "0.0.0.0";
		SetIpAddress(); // Set the Ip to the above address
		pcAssigned = false;
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        inv.datosserial.client = 0;
        inv.guardar();
    }
    // Update is called once per frame
    
    void Update()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        client = inv.datosserial.client;
        if(client  == 1 && manamulti.comenzar.Value == false)
        {
            if(NetworkManager.Singleton.ConnectedClients.Count == 1)
            {
                manamulti.checkServerRpc(manamulti.check1.Value,false);
            }
            manamulti.check1i = manamulti.check1.Value;
            manamulti.checkServerRpc(true,manamulti.check2.Value);
        }
        if(client  == 2 && manamulti.comenzar.Value == false)
        {

            manamulti.check2i = manamulti.check2.Value;
            manamulti.checkServerRpc(manamulti.check1.Value,true);
        }
        if(client == 0)
        {
            manamulti.check1i = false;
            manamulti.check2i = false;
        }
    }
    public void starthost()
    {
        if(activar == false)
        {
        GetLocalIPAddress();
        NetworkManager.Singleton.StartHost();
        activar = true;
        manamulti.check1.Value = true;
        manamulti.checkServerRpc(true,manamulti.check2.Value);
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        inv.datosserial.client = 1;
        inv.guardar();

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
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        inv.datosserial.client = 2;
        inv.guardar();
        }
    }


    public void apagar()
    {
        activar = false;
        codigo.text = "";
        if(client == 1)
        {
            manamulti.check1i = false;
            manamulti.check2i = false;
        }
        if(client == 2)
        {
            manamulti.check1i = false;
            manamulti.check2i = false;
        }
        NetworkManager.Singleton.Shutdown();
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        inv.datosserial.client = 0;
        inv.guardar();

        
    }

    public string GetLocalIPAddress() {
		var host = Dns.GetHostEntry(Dns.GetHostName());
		foreach (var ip in host.AddressList) {
			if (ip.AddressFamily == AddressFamily.InterNetwork) {
				codigo.text = "IP: "+ ip.ToString();
				ipAddress = ip.ToString();
                SetIpAddress();
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
