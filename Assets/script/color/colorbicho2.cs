using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorbicho2 : MonoBehaviour
{
    public Material material;
    public int hierbatipo;
    public SkinnedMeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {

        material = mesh.material;
        hierbatipo = PlayerPrefs.GetInt("hierbatipo", 3);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void colorbbarcelona()
    {
        combatemenu menu = UnityEngine.Object.FindObjectOfType<combatemenu>();
        if(menu.clasebarcelona[menu.i] == 1)
        {
            
        }
        if(menu.clasebarcelona[menu.i] == 2)
        {
            material.color = new Color(0,1,0.2158589f,1);
        }
        if(menu.clasebarcelona[menu.i] == 3)
        {
            material.color = new Color(1,0,0.220675f,1);
        }
    }
    public void colorbcajon()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        combatemenu menu = UnityEngine.Object.FindObjectOfType<combatemenu>();
        if(inv.clase[menu.i] == 1)
        {
            
        }
        if(inv.clase[menu.i] == 2)
        {
            material.color = new Color(0,1,0.2158589f,1);
        }
        if(inv.clase[menu.i] == 3)
        {
            material.color = new Color(1,0,0.220675f,1);
        }
    }
}