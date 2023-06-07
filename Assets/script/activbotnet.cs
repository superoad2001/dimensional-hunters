using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class activbotnet : NetworkBehaviour
{

    public GameObject jugador1;
    public GameObject jugador2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(NetworkObject.OwnerClientId);
        if(!NetworkManager.IsHost)
        {
            jugador2.SetActive(true);
            jugador1.SetActive(false);
        }
        if(NetworkManager.IsHost)
        {
            jugador1.SetActive(true);
            jugador2.SetActive(false);
        }
    }
}
