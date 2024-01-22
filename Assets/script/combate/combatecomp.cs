using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class combatecomp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool cancela = false;
    public Text uitext;
    public int lim = 3;

    public Text obj;
    // Update is called once per frame
    public void _cancela()
    {
        cancela = true;
    }
    void Update()
    {
        obj.text = lim.ToString();
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        hero heroe = UnityEngine.Object.FindObjectOfType<hero>();
        if(uitext.text == "ataque rápidos" ||uitext.text == "ataques rápido")
        {
            heroe._rapido();
            heroe.botno.Stop();
        }
        if(uitext.text == "ataque fuerte")
        {
            heroe._fuerte();
            heroe.botno.Stop();
        }
        if(uitext.text == "ataque fulminador")
        {
            heroe._rapfue();
            heroe.botno.Stop();
        }
        if(uitext.text == "defiéndete"||uitext.text == "defiende")
        {
            heroe._def();
            heroe.botno.Stop();
        }
        if(uitext.text == "")
        {
            heroe._notdef();
        }
        if(uitext.text == "turbo")
        {
            heroe._turbo();
        }
        if (cancela == true)
        {
            uitext.text = "";
        }
        cancela = false;
    }
    
}
