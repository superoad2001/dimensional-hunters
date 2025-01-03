using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using System.Net;
using System.Net.Sockets;
using Unity.Netcode.Transports.UTP;
using System.Net.NetworkInformation;


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
            manamulti.check1c = manamulti.check1.Value;
            manamulti.checkServerRpc(true,manamulti.check2.Value);
        }
        if(client  == 2 && manamulti.comenzar.Value == false && NetworkManager.Singleton.IsConnectedClient)
        {
            
            manamulti.check2c = manamulti.check2.Value;
            manamulti.checkServerRpc(manamulti.check1.Value,true);
            
        }
        if(client == 0)
        {
            manamulti.check1c = false;
            manamulti.check2c = false;
        }
    }
    public void starthost()
    {
        if(activar == false)
        {
        GetLocalIPv4();
        NetworkManager.Singleton.StartHost();
        activar = true;
        manamulti.check1c = true;
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
        manamulti.check2c = true;
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        inv.datosserial.client = 2;
        inv.guardar();
        }
    }


    public void apagar()
    {
        activar = false;
        heroe.carga = false;
        heroe2.carga = false;
        codigo.text = "";
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        inv.datosserial.client = 0;
        inv.guardar();
        if(client == 1)
        {
            manamulti.check1c = false;
            manamulti.check2c = false;
        }
        if(client == 2)
        {
            manamulti.check1c = false;
            manamulti.check2c = false;
        }
        NetworkManager.Singleton.Shutdown();


        
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
    public string[] GetLocalIPv4(NetworkInterfaceType interfaceType = NetworkInterfaceType.Ethernet)
    {
        var ipAddrList = new List<string>();
            //IPv4
            foreach (var netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netInterface.NetworkInterfaceType == interfaceType && netInterface.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (var ip in netInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            codigo.text = "IP: "+ ip.Address.ToString();
                            ipAddress = ip.Address.ToString();
                            SetIpAddress();
                        }
                    }
                }
 
            }
            if (ipAddrList.Count <= 0)
            {
                Debug.Log("NO IPv4 ADDRESS DETECTED, now I should try getting the phone's data's IP address");
            }
            return ipAddrList.ToArray();
    }

}
