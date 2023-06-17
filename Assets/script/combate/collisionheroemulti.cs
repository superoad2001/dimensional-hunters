using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class collisionheroemulti : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public heromulti heroe;
    public heromulti2 heroe2;
    // Update is called once per frame
    void Update()
    {
        if (transform.position == new Vector3(-3.83999991f,0.583000004f,5.58799982f)  && heroe.temp4 > 0.4f && NetworkManager.IsHost == true)
            {
                Debug.Log("jugador1: 3");
                heroe.activar = false;
                heroe.permiso = false;
                heroe.temp4 = 0;
                heroe.atkr.Value = 0;
                heroe.permisor.Value = heroe.permiso;
            }


    }
    public void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "enemigo" && NetworkManager.IsHost == true)
        {

            Debug.Log("jugador1: 1");
            if (heroe.activar == true)
            {

                Debug.Log("jugador1: 2");
                heroe2.hpr.Value -= heroe.ataque;
                heroe2.hp = heroe2.hpr.Value;
                heroe.activar = false;
                heroe.atkr.Value = 0;
                heroe2.danos.Play();
                

            }

        }
        if (col.gameObject.tag == "pini" && NetworkManager.IsHost == true)
        {
            heroe.ataque = 0;
            
        }

    }
    
}
