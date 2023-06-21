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
        if (transform.localPosition == new Vector3(-3.8599999F,0.583000004F,5.58799982F)  && heroe.temp4 > 0.4f && NetworkManager.IsHost == false)
            {
                heroe.activar = false;
                heroe.permiso = false;
                heroe.temp4 = 0;
                int atk = 0;
                heroe.permisoServerRpc(false);
                heroe.atkServerRpc(atk);
                
            }


    }
    public void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "Player" && NetworkManager.IsHost == false)
        {
            Debug.Log("jugador2: 1");
            if (heroe.activar == true)
            {
                float atke = heroe.ataque;
                int atk = 0;
                Debug.Log("jugador2: 2");
                heroe2.golpeServerRpc(atke);
                heroe.atkServerRpc(atk);
                heroe2.hp = heroe2.hpr.Value;
                heroe.activar = false;
                heroe2.danos.Play();
                

            }
        }
        if (col.gameObject.tag == "pine" && NetworkManager.IsHost == false)
        {
            heroe.permisoServerRpc(false);
            heroe.atkServerRpc(0);
            heroe.ataque = 0;
            
        }

    }
    


}
