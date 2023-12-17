using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorbicho7 : MonoBehaviour
{
    public Material material;
    public SkinnedMeshRenderer mesh;
    public float clase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void colorb()
    {   

        heromulti2 hero = UnityEngine.Object.FindObjectOfType<heromulti2>();
        clase = hero.clase;
        if(clase == 1)
        {
            material.color = Color.white;
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

}
