using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class subirrangos : MonoBehaviour
{
    public int rango;

    public bool cazar = false;
    public bool combate = false;
    public bool atras = false;
    public int tutorial1;
    public int tutorial3;
    public int vez1;
    public int jefe1;
    public Text rangot;
    public int requisito;

    public Text requsitot;
    public Text dinerot;
    public AudioSource nobot;
    public AudioSource sibot;
    public bool noventa = false;
    // Start is called before the first frame update
    void Start()
    {
        rango = PlayerPrefs.GetInt("rango", 1);

        if(rango == 1)
        {requisito = 500;}
        if(rango == 2)
        {requisito = 500;}
        if(rango == 3)
        {requisito = 500;}
        if(rango == 4)
        {requisito = 500;}
        if(rango == 5)
        {requisito = 500;}

        if(rango == 6)
        {requisito = 500;}
        if(rango == 7)
        {requisito = 500;}
        if(rango == 8)
        {requisito = 500;}
        if(rango == 9)
        {requisito = 500;}
        if(rango == 10)
        {requisito = 500;}

        if(rango == 11)
        {requisito = 500;}
        if(rango == 12)
        {requisito = 500;}
        if(rango == 13)
        {requisito = 500;}
        if(rango == 14)
        {requisito = 500;}
        if(rango == 15)
        {requisito = 500;}

        if(rango == 16)
        {requisito = 500;}
        if(rango == 17)
        {requisito = 500;}
        if(rango == 48)
        {requisito = 500;}
        if(rango == 19)
        {requisito = 500;}
        if(rango == 20)
        {requisito = 500;}

        if(rango == 21)
        {noventa = true;}
    }

    public void _atras2()
    {
        SceneManager.LoadScene("seleccion2");
    }
    public void _subir()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(inv.dinero >= requisito && noventa == false)
        {
            sibot.Play();
            rango++;
            inv.dinero -= requisito;
            PlayerPrefs.SetFloat("dinerosave",inv.dinero);
            PlayerPrefs.SetInt("rango",rango);
        }
        else
        {
            nobot.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        requsitot.text = "necesitas "+requisito+" dolares";
        dinerot.text = "tus dolares: "+inv.dinero;
        rangot.text = ""+rango;

    }
}