using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class collisionenemigotrain1 : MonoBehaviour
{


    public enemigotrain2 heroe;
    public enemigotrain1 enemigo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition == new Vector3(-3.83999991f,0.583000004f,5.58799982f) && enemigo.temp4 > 1)
            {
                enemigo.activar = false;
                enemigo.permiso = false;
                enemigo.temp4 = 0;
            }
    }
    public void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "enemigo")
        {
            
            if (enemigo.activar == true && heroe.defv == false)
            {
                Debug.Log("si");
                heroe.hp -= enemigo.ataque;
                enemigo.activar = false;
                heroe.danos.Play();
                int ataqued = (int)enemigo.ataque;

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(enemigo.ev1.transform.position, "-"+ataqued.ToString(),heroe.textDatadano);

                enemigo.ataque = 0;
                enemigo.AddReward(20f);
                heroe.AddReward(-20f);
                

            }
            if (enemigo.activar == false && enemigo.def == true)
            {
                enemigo.AddReward(10f);
            }
        }
        if (col.gameObject.tag == "pini" && enemigo.temp4 > 1)
        {
            enemigo.ataque = 0;
            
        }

    }
}
