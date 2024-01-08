using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionenemigo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemigo enemigo = UnityEngine.Object.FindObjectOfType<enemigo>();
        if (transform.localPosition == new Vector3(-3.8599999f,0.583000004f,5.58799982f) && enemigo.temp4 > 1)
            {
                enemigo.activar = false;
                enemigo.permiso = false;
                enemigo.temp4 = 0;
            }
    }
    public void OnTriggerEnter(Collider col)
    {
        enemigo enemigo = UnityEngine.Object.FindObjectOfType<enemigo>();
        
        if (col.gameObject.tag == "Player")
        {
            
            if (enemigo.activar == true)
            {
                Debug.Log("si");
                hero heroe = UnityEngine.Object.FindObjectOfType<hero>();
                heroe.hp -= enemigo.ataque;
                enemigo.activar = false;
                heroe.danos.Play();
                int ataqued = (int)enemigo.ataque;
                heroe.danot.text = "-"+ataqued.ToString();
                heroe.ps.Stop();
                heroe.ps.Clear();
                heroe.danot.color = new Color32(255,70,43,255);
                heroe.ps.Play();
                enemigo.ataque = 0;
                

            }
        }
        if (col.gameObject.tag == "pini")
        {
            enemigo.ataque = 0;
            
        }

    }
}
