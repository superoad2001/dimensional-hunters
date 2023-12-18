using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tiendamenu : MonoBehaviour
{
    public int tienda = 1;


    
    public bool bichoselec;

    public Text puesto1;
    public Text puesto2;
    public Text puesto3;
    public Text puesto4;
    public Text puesto5;
    public Text puesto6;

   



    public bool der;
    public bool izq;
    public bool dermod;
    public bool izqmod;
    public bool si;
    public bool no;

    public bool salir;
    public bool atras;
    public bool borrar2;

    public int i = 0;

    public bool actc;
    public AudioSource nobot;
    public AudioSource sibot;


   public float temp;

    public Text din;
    public Text uitext;
    public Text mensaje;

    public Text ptext1;
    public Text ptext2;
    public Text ptext3;
    public Text ptext4;
    public Text ptext5;
    public Text ptext6;


    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;

    public GameObject sel1;
    public GameObject sel2;
    public GameObject sel3;
    public GameObject sel4;
    public GameObject sel5;
    public GameObject sel6;

    public int rango;
    public float rangoexp;

    // Start is called before the first frame update

    public void _cajon()
    {
        actc = true;
    }
     public void _selec()
    {
        bichoselec = true;
    }
     public void _atras()
    {
        atras = true;
    }
     public void _si()
    {
        si = true;
    }
    public void _no()
    {
        no = true;
    }
    public void _izq()
    {
        izq = true;
    }
     public void _der()
    {
        der = true;
    }
    public void _izqmod()
    {
        izqmod = true;
    }
     public void _dermod()
    {
        dermod = true;
    }
    public void _borrar()
    {
        borrar2 = true;
    }








    void Start()
    {
        rango = PlayerPrefs.GetInt("rango", 1);


        if(rango == 1)
        {rangoexp = 1;}
        if(rango == 2)
        {rangoexp = 1.50f;}
        if(rango == 3)
        {rangoexp = 2f;}
        if(rango == 4)
        {rangoexp = 2.50f;}
        if(rango == 5)
        {rangoexp = 3f;}

        if(rango == 6)
        {rangoexp = 3.25f;}
        if(rango == 7)
        {rangoexp = 3.75f;}
        if(rango == 8)
        {rangoexp = 4.25f;}
        if(rango == 9)
        {rangoexp = 4.75f;}
        if(rango == 10)
        {rangoexp = 5.25f;}

        if(rango == 11)
        {rangoexp = 5.5f;}
        if(rango == 12)
        {rangoexp = 6f;}
        if(rango == 13)
        {rangoexp = 6.50f;}
        if(rango == 14)
        {rangoexp = 7f;}
        if(rango == 15)
        {rangoexp = 7.50f;}

        if(rango == 16)
        {rangoexp = 7.75f;}
        if(rango == 17)
        {rangoexp = 8.25f;}
        if(rango == 48)
        {rangoexp = 8.75f;}
        if(rango == 19)
        {rangoexp = 9.25f;}
        if(rango == 20)
        {rangoexp = 9.75f;}

        if(rango == 21)
        {rangoexp = 10;}
    
        


    }

    // Update is called once per frame
    void Update()
    {

        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(atras == true)
        {SceneManager.LoadScene("seleccion");}

    

        if(tienda == 1)
        {       
                puesto1.text = "hierba comun plateada";
                puesto2.text = "hierba comun dorada";
                puesto3.text = "";
                puesto4.text = "";
                puesto5.text = "";
                puesto6.text = "";
                din.text = "dolares : "+(int)inv.dinero;
                if (i == 0)
                {uitext.text = text1.text;
                sel1.SetActive(true);
                sel2.SetActive(false);
                sel3.SetActive(false);
                sel4.SetActive(false);
                sel5.SetActive(false);
                sel6.SetActive(false);
                
                }
                if (i == 1)
                {uitext.text = text2.text;
                sel1.SetActive(false);
                sel2.SetActive(true);
                sel3.SetActive(false);
                sel4.SetActive(false);
                sel5.SetActive(false);
                sel6.SetActive(false);}
                if (i == 2)
                {uitext.text = text3.text;
                sel1.SetActive(false);
                sel2.SetActive(false);
                sel3.SetActive(true);
                sel4.SetActive(false);
                sel5.SetActive(false);
                sel6.SetActive(false);}
                if (i == 3)
                {uitext.text = text4.text;
                sel1.SetActive(false);
                sel2.SetActive(false);
                sel3.SetActive(false);
                sel4.SetActive(true);
                sel5.SetActive(false);
                sel6.SetActive(false);}
                if (i == 4)
                {uitext.text = text5.text;
                sel1.SetActive(false);
                sel2.SetActive(false);
                sel3.SetActive(false);
                sel4.SetActive(false);
                sel5.SetActive(true);
                sel6.SetActive(false);}
                if (i == 5)
                {uitext.text = text6.text;
                sel1.SetActive(false);
                sel2.SetActive(false);
                sel3.SetActive(false);
                sel4.SetActive(false);
                sel5.SetActive(false);
                sel6.SetActive(true);}
                ptext1.text = (int)inv.tipohierba[10]+"                 "+((int)50 * rangoexp);
                ptext2.text = (int)inv.tipohierba[20]+"                 "+((int)100 * rangoexp);
                ptext3.text = "";
                ptext4.text = "";
                ptext5.text = "";
                ptext6.text = "";

                if(bichoselec == true && temp > 0.3f)
                {
                    if (i == 0 && inv.dinero >= ((int)50 * rangoexp) && inv.tipohierba[10] < 9)
                    {
                        inv.tipohierba[10]++;
                        inv.dinero -= ((int)50 * rangoexp);
                        mensaje.text = "buena compra";
                        PlayerPrefs.SetFloat("dinerosave",inv.dinero);
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 0 && inv.dinero < ((int)50 * rangoexp) && inv.tipohierba[10] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 0 && inv.dinero >= ((int)50 * rangoexp) && inv.tipohierba[10] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.dinero >= ((int)100 * rangoexp) && inv.tipohierba[20] < 9)
                    {
                        inv.tipohierba[20]++;
                        inv.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        PlayerPrefs.SetFloat("dinerosave",inv.dinero);
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.dinero < ((int)100 * rangoexp) && inv.tipohierba[20] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.dinero >= ((int)100 * rangoexp) && inv.tipohierba[20] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    
                
                }
                if(der == true && i < 1)
                {
                    i++;
                }
                if(izq == true && i > -1)
                {
                    i--;
                }
        }
        if(tienda == 2)
        {       
                puesto1.text = "";
                puesto2.text = "";
                puesto3.text = "";
                puesto4.text = "";
                puesto5.text = "";
                puesto6.text = "";
                din.text = "dolares : "+(int)inv.dinero;
                if (i == 0)
                {uitext.text = text1.text;
                sel1.SetActive(true);
                sel2.SetActive(false);
                sel3.SetActive(false);
                sel4.SetActive(false);
                sel5.SetActive(false);
                sel6.SetActive(false);
                
                }
                if (i == 1)
                {uitext.text = text2.text;
                sel1.SetActive(false);
                sel2.SetActive(true);
                sel3.SetActive(false);
                sel4.SetActive(false);
                sel5.SetActive(false);
                sel6.SetActive(false);}
                if (i == 2)
                {uitext.text = text3.text;
                sel1.SetActive(false);
                sel2.SetActive(false);
                sel3.SetActive(true);
                sel4.SetActive(false);
                sel5.SetActive(false);
                sel6.SetActive(false);}
                if (i == 3)
                {uitext.text = text4.text;
                sel1.SetActive(false);
                sel2.SetActive(false);
                sel3.SetActive(false);
                sel4.SetActive(true);
                sel5.SetActive(false);
                sel6.SetActive(false);}
                if (i == 4)
                {uitext.text = text5.text;
                sel1.SetActive(false);
                sel2.SetActive(false);
                sel3.SetActive(false);
                sel4.SetActive(false);
                sel5.SetActive(true);
                sel6.SetActive(false);}
                if (i == 5)
                {uitext.text = text6.text;
                sel1.SetActive(false);
                sel2.SetActive(false);
                sel3.SetActive(false);
                sel4.SetActive(false);
                sel5.SetActive(false);
                sel6.SetActive(true);}
                ptext1.text = "";
                ptext2.text = "";
                ptext3.text = "";
                ptext4.text = "";
                ptext5.text = "";
                ptext6.text = "";

                if(bichoselec == true && temp > 0.3f)
                {

                    
                
                }
                if(der == true && i < 2)
                {
                    i++;
                }
                if(izq == true && i > -1)
                {
                    i--;
                }
        }
        if(tienda == 3)
        {       
                puesto1.text = "";
                puesto2.text = "";
                puesto3.text = "";
                puesto4.text = "";
                puesto5.text = "";
                puesto6.text = "";
                din.text = "dolares : "+(int)inv.dinero;
                if (i == 0)
                {uitext.text = text1.text;
                sel1.SetActive(true);
                sel2.SetActive(false);
                sel3.SetActive(false);
                sel4.SetActive(false);
                sel5.SetActive(false);
                sel6.SetActive(false);
                
                }
                if (i == 1)
                {uitext.text = text2.text;
                sel1.SetActive(false);
                sel2.SetActive(true);
                sel3.SetActive(false);
                sel4.SetActive(false);
                sel5.SetActive(false);
                sel6.SetActive(false);}
                if (i == 2)
                {uitext.text = text3.text;
                sel1.SetActive(false);
                sel2.SetActive(false);
                sel3.SetActive(true);
                sel4.SetActive(false);
                sel5.SetActive(false);
                sel6.SetActive(false);}
                if (i == 3)
                {uitext.text = text4.text;
                sel1.SetActive(false);
                sel2.SetActive(false);
                sel3.SetActive(false);
                sel4.SetActive(true);
                sel5.SetActive(false);
                sel6.SetActive(false);}
                if (i == 4)
                {uitext.text = text5.text;
                sel1.SetActive(false);
                sel2.SetActive(false);
                sel3.SetActive(false);
                sel4.SetActive(false);
                sel5.SetActive(true);
                sel6.SetActive(false);}
                if (i == 5)
                {uitext.text = text6.text;
                sel1.SetActive(false);
                sel2.SetActive(false);
                sel3.SetActive(false);
                sel4.SetActive(false);
                sel5.SetActive(false);
                sel6.SetActive(true);}
                ptext1.text = "";
                ptext2.text = "";
                ptext3.text = "";
                ptext4.text = "";
                ptext5.text = "";
                ptext6.text = "";

                if(bichoselec == true && temp > 0.3f)
                {

                
                }
                if(der == true && i < 2)
                {
                    i++;
                }
                if(izq == true && i > -1)
                {
                    i--;
                }
        }
        if(dermod == true)
        {
            if(tienda < 3)
            {
                tienda++;
                i = 0;
            }
        }
        else if(izqmod == true)
        {
            if(tienda > 1)
            {
                tienda--;
                i = 0;
            }
        }
        izqmod = false;
        dermod = false;
        
        
        
    
    
        if (temp < 15)
        {temp += 1 * Time.deltaTime;}
        bichoselec = false;
        izq = false;
        der = false;
        salir = false;
        atras = false;
        si = false;
        no = false;
        borrar2 = false;

    }
 
}
