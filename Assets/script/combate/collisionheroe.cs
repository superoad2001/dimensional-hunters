using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class collisionheroe : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hero heroe = UnityEngine.Object.FindObjectOfType<hero>();
        if (transform.position == new Vector3(-3.83999991f,0.583000004f,5.58799982f)  && heroe.temp4 > 1)
            {
                heroe.activar = false;
                heroe.permiso = false;
                heroe.temp4 = 0;
            }

    }
    public void OnTriggerEnter(Collider col)
    {
        hero heroe = UnityEngine.Object.FindObjectOfType<hero>();
        
        if (col.gameObject.tag == "enemigo")
        {
            
            if (heroe.activar == true)
            {
                Debug.Log("no");
            
                enemigo enemigo = UnityEngine.Object.FindObjectOfType<enemigo>();
                enemigo.hp -= heroe.ataque;
                heroe.activar = false;
                enemigo.danos.Play();
                int ataqued = (int)heroe.ataque;

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(enemigo.ev1.transform.position, "-"+ataqued.ToString(),enemigo.textDatadano);  

                heroe.ataque = 0;
                

            }
        }
        if (col.gameObject.tag == "pini")
        {
            heroe.ataque = 0;
            heroe.permiso = false;
            
        }

    }
}
