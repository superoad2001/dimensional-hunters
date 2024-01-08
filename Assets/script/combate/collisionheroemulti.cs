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
        
        if (transform.position == new Vector3(-3.83999991f,0.583000004f,5.58799982f)  && heroe.temp4 > 0.4f && client == 1)
            {
                Debug.Log("jugador1: 3");
                heroe.activar = false;
                heroe.permiso = false;
                heroe.temp4 = 0;
                heroe.ataque = 0;
                heroe.parar();
            }


    }
    public void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "enemigo")
        {

            Debug.Log("jugador1: 1");
            if (heroe.activar == true && client == 1)
            {

                Debug.Log("jugador1: 2");
                heroe2.golpe(heroe.ataque);
                heroe2.hp = heroe2.hpr.Value;
                heroe.activar = false;
                heroe2.danos.Play();

                int ataqued = (int)heroe.ataque;
                heroe2.ps.Stop();
                heroe2.ps.Clear();
                heroe2.danot.text = "-"+ataqued.ToString();
                heroe2.danot.color = new Color32(255,70,43,255);
                heroe2.ps.Play();
                heroe2.mostrarr.Value = 1;
                heroe.ataque = 0;
                heroe.parar2();
                

            }

        }
        if (col.gameObject.tag == "pini" && client == 1)
        {
            heroe.ataque = 0;
            heroe.parar();
            
        }

    }
    
}
