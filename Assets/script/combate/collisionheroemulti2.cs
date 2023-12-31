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
    public int client;

    // Update is called once per frame
    void Update()
    {
        client = PlayerPrefs.GetInt("clientid",0);
        if (transform.localPosition == new Vector3(-3.8599999F,0.583000004F,5.58799982F)  && heroe.temp4 > 0.4f && client == 2)
            {
                heroe.activar = false;
                heroe.permiso = false;
                heroe.temp4 = 0;
                heroe.permisoServerRpc(false);
                heroe.atkServerRpc(0);
                heroe.ataque = 0;
                
            }


    }
    public void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "Player" && client == 2)
        {
            Debug.Log("jugador2: 1");
            if (heroe.activar == true)
            {
                Debug.Log("jugador2: 2");
                heroe2.golpeServerRpc(heroe.ataque);
                heroe.atkServerRpc(0);
                heroe2.hp = heroe2.hpr.Value;
                heroe.activar = false;
                heroe2.danos.Play();
                heroe.ataque = 0;
                

            }
        }
        if (col.gameObject.tag == "pine" && client == 2)
        {
            heroe.permisoServerRpc(false);
            heroe.atkServerRpc(0);
            heroe.ataque = 0;
            
        }

    }
    


}
