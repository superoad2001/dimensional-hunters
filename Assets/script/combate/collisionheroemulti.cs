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
        if (transform.position == new Vector3(-3.83999991f,0.583000004f,5.58799982f)  && heroe.temp4 > 1)
            {
                heroe.permiso = false;
                heroe.temp4 = 0;
            }


    }
    public void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "enemigo" && IsOwner)
        {
            
            if (heroe.activar == true)
            {
                Debug.Log("no");
            
                heroe2.hpr.Value -= heroe.ataque;
                heroe.activar = false;
                heroe2.danos.Play();
                

            }
        }
        if (col.gameObject.tag == "pini" && IsOwner)
        {
            heroe.ataque = 0;
            
        }

    }
}
