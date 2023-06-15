using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class collisionheroemulti2 : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public heromulti2 heroe;
    public heromulti heroe2;
    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition == new Vector3(-3.8599999f,0.583000004f,5.58799982f)  && heroe.temp4 > 1)
            {
                heroe.permiso = false;
                heroe.temp4 = 0;
            }


    }
    public void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "enemigo" && IsOwner == false)
        {
            
            if (heroe.activar == true)
            {
                Debug.Log("no");
                golpeServerRpc(heroe.ataque);
                heroe.activar = false;
                heroe2.danos.Play();
                

            }
        }
        if (col.gameObject.tag == "pine" && IsOwner == false)
        {
            heroe.ataque = 0;
            
        }

    }
    [ServerRpc(RequireOwnership = false)]
    public void golpeServerRpc(float atk)
    {
        heroe2.hpr.Value -= atk;
    }
}
