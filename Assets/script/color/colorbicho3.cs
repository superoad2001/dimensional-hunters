using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorbicho3 : MonoBehaviour
{
    public Material material;
    public SkinnedMeshRenderer mesh;
    public float clase;
    // Start is called before the first frame update
    void Start()
    {

        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        clase = inv.datosserial.clases;
        if(clase == 1)
        {
            
        }
        if(clase == 2)
        {
            for ( int childIndex = 0; childIndex < gameObject.transform.childCount; childIndex++)
            {
                Transform child = gameObject.transform.GetChild(childIndex);			

                if(child.gameObject.GetComponent<SkinnedMeshRenderer>() != null){child.gameObject.GetComponent<SkinnedMeshRenderer>().material.color = new Color(0,1,0.2158589f,1);}
            }
        }
        if(clase == 3)
        {
            for ( int childIndex = 0; childIndex < gameObject.transform.childCount; childIndex++)
            {
                Transform child = gameObject.transform.GetChild(childIndex);			

                if(child.gameObject.GetComponent<SkinnedMeshRenderer>() != null){child.gameObject.GetComponent<SkinnedMeshRenderer>().material.color = new Color(1,0,0.220675f,1);}
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

}
