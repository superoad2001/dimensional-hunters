using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionheroeentr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        heroentr heroe = UnityEngine.Object.FindObjectOfType<heroentr>();
        if (transform.position == new Vector3(-3.83999991f,0.583000004f,5.58799982f)  && heroe.temp4 > 1)
            {
                heroe.permiso = false;
                heroe.temp4 = 0;
            }

    }
    public void OnTriggerEnter(Collider col)
    {
        heroentr heroe = UnityEngine.Object.FindObjectOfType<heroentr>();
        
        if (col.gameObject.tag == "enemigo")
        {
            
            if (heroe.activar == true)
            {
                Debug.Log("no");
            
                heroe.activar = false;
                

            }
        }
        if (col.gameObject.tag == "pini")
        {
            heroe.ataque = 0;
            heroe.permiso = false;
            
        }

    }
}
