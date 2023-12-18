using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorbicho : MonoBehaviour
{
    public Material material;
    public int hierbatipo;
    public SkinnedMeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        material = mesh.material;
        hierbatipo = PlayerPrefs.GetInt("hierbatipo", 3);
        if(hierbatipo == 1)
        {
        
        }
        if(hierbatipo == 2)
        {
            material.color = new Color(0,1,0.2158589f,1);
        }
        if(hierbatipo == 3)
        {
            material.color = new Color(1,0,0.220675f,1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
