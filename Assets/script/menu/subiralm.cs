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
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        rango = PlayerPrefs.GetInt("rango", 1);

        if(inv.limite == 5)
        {requisito = 500;}
        if(inv.limite == 10)
        {requisito = 500;}
        if(inv.limite == 15)
        {requisito = 500;}
        if(inv.limite == 20)
        {requisito = 500;}
        if(inv.limite == 25)
        {requisito = 500;}
        if(inv.limite == 30)
        {requisito = 500;}
        if(inv.limite == 35)
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
            inv.limite += 5;
            inv.dinero -= requisito;
            PlayerPrefs.SetFloat("dinerosave",inv.dinero);
            PlayerPrefs.SetFloat("limite",inv.limite);
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
        rangot.text = ""+inv.limite;
        rangop.text = ""+(inv.limite+5);

    }
}
