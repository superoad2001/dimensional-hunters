using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerargame : MonoBehaviour
{
    public string plat;
    public GameObject arcore;
    public GameObject game3d;
    public GameObject game3dtact;

    public GameObject boton1;
    public GameObject boton2;
    public GameObject boton3;
    public GameObject boton4;
    public GameObject boton5;
    public GameObject boton6;

    public GameObject boton7;
    public GameObject boton8;
    public GameObject boton9;
    public GameObject boton10;
    // Start is called before the first frame update
    void Start()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();

        plat = inv.datosserial.plat;

        if(plat == "game3dt" || plat == "arcore")
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if(plat == "game3d")
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }




        
        if(plat == "arcore")
        {
            arcore.SetActive(true);
            game3d.SetActive(false);
            game3dtact.SetActive(false);
        }
        if(plat == "game3d")
        {
            arcore.SetActive(false);
            game3d.SetActive(true);
            game3dtact.SetActive(false);
            if(boton6 != null)
            {boton6.SetActive(false);}
            Cursor.visible = false;
        	Cursor.lockState = CursorLockMode.Locked;
        }
        if(plat == "game3dt")
        {
            arcore.SetActive(false);
            game3d.SetActive(true);
            game3dtact.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
