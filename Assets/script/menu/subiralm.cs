using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class subiralm : MonoBehaviour
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
    public Text rangop;
    public int requisito;

    public Text requsitot;
    public Text dinerot;
    public AudioSource nobot;
    public AudioSource sibot;
    public bool noventa = false;
    // Start is called before the first frame update
    void Start()
    {
        

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        recexp();
        

    }

    public void _atras2()
    {
        SceneManager.LoadScene("seleccion2");
    }
    public void _subir()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(inv.datosserial.dinero >= requisito && noventa == false)
        {
            sibot.Play();
            inv.datosserial.limite += 5;
            inv.datosserial.dinero -= requisito;
            inv.datosserial.rangoplay++;
            inv.guardar();
            recexp();
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

        if(noventa == true)
        {
            requsitot.text = "has alcanzado el nivel maximo de almacenamiento";
            rangop.text = ""+(inv.datosserial.limite);
        }
        else
        {
            requsitot.text = "necesitas "+requisito+" dolares";
            rangop.text = ""+(inv.datosserial.limite+5);
        }
        dinerot.text = "tus dolares: "+inv.datosserial.dinero;
        rangot.text = ""+inv.datosserial.limite;

    }
    public void recexp()
    {

        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        rango = inv.datosserial.rangoplay;
        if(inv.datosserial.limite == 5)
        {requisito = 500;}
        if(inv.datosserial.limite == 10)
        {requisito = 800;}
        if(inv.datosserial.limite == 15)
        {requisito = 1000;}
        if(inv.datosserial.limite == 20)
        {requisito = 5000;}
        if(inv.datosserial.limite == 25)
        {requisito = 10000;}
        if(inv.datosserial.limite == 30)
        {requisito = 15000;}
        if(inv.datosserial.limite == 35)
        {requisito = 20000;}
        if(inv.datosserial.limite == 40)
        {requisito = 30000;}
        if(inv.datosserial.limite == 45)
        {requisito = 40000;}
        if(inv.datosserial.limite == 50)
        {noventa = true;}
    }
}
