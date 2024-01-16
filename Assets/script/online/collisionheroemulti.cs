using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class collisionheroemulti : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public heromulti heroe;
    public heromulti2 heroe2;
    public int client;

    // Update is called once per frame
    void Update()
    {
        client = PlayerPrefs.GetInt("clientid",0);
        
        if (transform.position == new Vector3(-3.83999991f,0.583000004f,5.58799982f)  && heroe.temp4 > 0.4f && client == 1 && heroe.managermulti.comenzar.Value == true)
            {
                heroe.activar = false;
                heroe.permiso = false;
                heroe.temp4 = 0;
                heroe.ataque = 0;
                heroe.permisor.Value = false;
                heroe.atkr.Value = 0;
            }


    }
    public void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "enemigo")
        {

            if (heroe.activar == true && client == 1)
            {
                heroe2.golpeServerRpc(heroe.ataque);
                heroe.atkServerRpc(0);
                heroe2.hp = heroe2.hpr.Value;
                heroe.activar = false;
                heroe2.danos.Play();

                int ataqued = (int)heroe.ataquem.Value;
                
                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(heroe2.ev1.transform.position, "-"+ataqued.ToString(),heroe2.textDatadano);  

                heroe2.mostrarr.Value = 1;
                heroe.ataque = 0;
                

            }

        }
        if (col.gameObject.tag == "pini" && client == 1 && heroe.temp4 > 1f)
        {
            heroe.ataque = 0;
            heroe.permisor.Value = false;
            heroe.atkServerRpc(0);
        }

    }
    
}
