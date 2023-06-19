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



    
        


    }

    // Update is called once per frame
    void Update()
    {

        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(atras == true)
        {SceneManager.LoadScene("seleccion");}

    

        if(tienda == 1)
        {       
                puesto1.text = "pocion de salud (p)";
                puesto2.text = "pocion de stamina (p)";
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
                ptext1.text = (int)inv.pocvp+"                 10";
                ptext2.text = (int)inv.pocmp+"                 5";
                ptext3.text = "";
                ptext4.text = "";
                ptext5.text = "";
                ptext6.text = "";

                if(bichoselec == true && temp > 0.3f)
                {
                    if (i == 0 && inv.dinero >= 10 && inv.pocvp < 9)
                    {
                        inv.pocvp++;
                        inv.dinero -= 10;
                        mensaje.text = "buena compra";
                        PlayerPrefs.SetFloat("dinerosave",inv.dinero);
                        PlayerPrefs.SetFloat("pocvp",inv.pocvp);
                        sibot.Play();
                    }
                    else if(i == 0 && inv.dinero < 10 && inv.pocvp < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 0 && inv.dinero >= 10 && inv.pocvp >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.dinero >= 5 && inv.pocmp < 9)
                    {
                        inv.pocmp++;
                        inv.dinero -= 5;
                        mensaje.text = "buena compra";
                        PlayerPrefs.SetFloat("dinerosave",inv.dinero);
                        PlayerPrefs.SetFloat("pocmp",inv.pocmp);
                        sibot.Play();
                    }
                    else if(i == 1 && inv.dinero < 5 && inv.pocmp < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.dinero >= 5 && inv.pocmp >= 9)
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
                puesto1.text = "pocion de salud (m)";
                puesto2.text = "pocion de stamina (m)";
                puesto3.text = "hierba comun plateada";
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
                ptext1.text = (int)inv.pocvm+"                 50";
                ptext2.text = (int)inv.pocmm+"                 25";
                ptext3.text = (int)inv.tipohierba[10]+"                 50";
                ptext4.text = "";
                ptext5.text = "";
                ptext6.text = "";

                if(bichoselec == true && temp > 0.3f)
                {



                    if (i == 0 && inv.dinero >= 50 && inv.pocvm < 9)
                    {
                        inv.pocvm++;
                        inv.dinero -= 50;
                        mensaje.text = "buena compra";
                        PlayerPrefs.SetFloat("dinerosave",inv.dinero);
                        PlayerPrefs.SetFloat("pocvm",inv.pocvm);
                        sibot.Play();
                    }
                    else if(i == 0 && inv.dinero < 50 && inv.pocvm < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 0 && inv.dinero >= 50 && inv.pocvm >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }


                    else if (i == 1 && inv.dinero >= 25 && inv.pocmm < 9)
                    {
                        inv.pocmm++;
                        inv.dinero -= 25;
                        mensaje.text = "buena compra";
                        PlayerPrefs.SetFloat("dinerosave",inv.dinero);
                        PlayerPrefs.SetFloat("pocmm",inv.pocmm);
                        sibot.Play();
                    }
                    else if(i == 1 && inv.dinero < 25 && inv.pocmm < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.dinero >= 25 && inv.pocmm >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }



                    else if (i == 2 && inv.dinero >= 50 && inv.tipohierba[10] < 9)
                    {
                        inv.tipohierba[10]++;
                        inv.dinero -= 50;
                        mensaje.text = "buena compra";
                        PlayerPrefs.SetFloat("dinerosave",inv.dinero);
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 2 && inv.dinero < 50 && inv.tipohierba[10] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 2 && inv.dinero >= 50 && inv.tipohierba[10] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }
                    
                
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
                puesto1.text = "pocion de salud (g)";
                puesto2.text = "pocion de stamina (g)";
                puesto3.text = "hierba comun dorada";
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
                ptext1.text = (int)inv.pocvg+"                 100";
                ptext2.text = (int)inv.pocmg+"                 50";
                ptext3.text = (int)inv.tipohierba[20]+"                 100";
                ptext4.text = "";
                ptext5.text = "";
                ptext6.text = "";

                if(bichoselec == true && temp > 0.3f)
                {
                    

                    if (i == 0 && inv.dinero >= 100 && inv.pocvg < 9)
                    {
                        inv.pocvg++;
                        inv.dinero -= 100;
                        mensaje.text = "buena compra";
                        PlayerPrefs.SetFloat("dinerosave",inv.dinero);
                        PlayerPrefs.SetFloat("pocvg",inv.pocvg);
                        sibot.Play();
                    }
                    else if(i == 0 && inv.dinero < 100 && inv.pocvg < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 0 && inv.dinero >= 100 && inv.pocvg >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.dinero >= 50 && inv.pocmg < 9)
                    {
                        inv.pocmg++;
                        inv.dinero -= 50;
                        mensaje.text = "buena compra";
                        PlayerPrefs.SetFloat("dinerosave",inv.dinero);
                        PlayerPrefs.SetFloat("pocmg",inv.pocmg);
                        sibot.Play();
                    }
                    else if(i == 1 && inv.dinero < 50 && inv.pocmg < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.dinero >= 50 && inv.pocmg >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }
                    else if (i == 2 && inv.dinero >= 100 && inv.tipohierba[20] < 9)
                    {
                        inv.tipohierba[20]++;
                        inv.dinero -= 100;
                        mensaje.text = "buena compra";
                        PlayerPrefs.SetFloat("dinerosave",inv.dinero);
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 2 && inv.dinero < 100 && inv.tipohierba[20] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 2 && inv.dinero >= 100 && inv.tipohierba[20] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    
                    
                
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
