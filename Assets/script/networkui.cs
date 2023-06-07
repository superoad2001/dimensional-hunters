using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class networkui : NetworkBehaviour
{


    public heromulti heroe;
    public heromulti2 heroe2;
    
    public Text codigo;
    public managermulti manamulti;
    // Start is called before the first frame update
    void Start()
    {
        codigo.text = "";
    }
    public ulong clientId;
    // Update is called once per frame
    void Update()
    {
        
        heroe.carga = false;
        heroe2.carga = false;
        if(!IsOwner)
        {
            clientId = OwnerClientId;
            if(clientId > 0)
            {
                NetworkManager.Singleton.Shutdown();
                manamulti.check2 = false;
                heroe2.carga = false;
            }
        }
        Debug.Log(clientId);
    }
    public void starthost()
    {
        
        NetworkManager.Singleton.StartHost();
        if(!NetworkManager.IsHost)return;
        manamulti.check1 = true;
        heroe.carga = false;
        codigo.text = "CODIGO DE SALA: XXXXXXX";
    }
    public void startclient()
    {
        NetworkManager.Singleton.StartClient();
        if(NetworkManager.IsHost)return;
        manamulti.check2 = true;
        heroe2.carga = false;
        
        
    }
    public void apagar()
    {
        NetworkManager.Singleton.Shutdown();
        heroe.carga = false;
        heroe2.carga = false;
        if(NetworkManager.IsHost)
        {manamulti.check1 = false;}
        if(!NetworkManager.IsHost)
        {manamulti.check2 = false;}
        codigo.text = "";
        
    }
}
