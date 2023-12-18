using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorbicho4 : MonoBehaviour
{
    public Material material;
    public SkinnedMeshRenderer mesh;
    public float clase;
    // Start is called before the first frame update
    void Start()
    {
        clase = PlayerPrefs.GetFloat("claseene", 1);
        if(clase == 1)
        {
            
        }
        if(clase == 2)
        {
            material.color = new Color(0,1,0.2158589f,1);
        }
        if(clase == 3)
        {
            material.color = new Color(1,0,0.220675f,1);
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }

}
