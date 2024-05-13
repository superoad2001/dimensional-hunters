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
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        rango = inv.datosserial.rangoplay;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

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
        if(rango == 18)
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
        {SceneManager.LoadScene("seleccion2");}

    

        if(tienda == 1)
        {       
                puesto1.text = "hierba comun plateada";
                puesto2.text = "hierba comun dorada";
                puesto3.text = "hierba gris";
                puesto4.text = "hierba gris plateada";
                puesto5.text = "hierba gris dorada";
                puesto6.text = "";
                din.text = "dolares : "+(int)inv.datosserial.dinero;
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
                ptext1.text = (int)inv.datosserial.tipohierba[10]+"                 "+((int)50 * rangoexp);
                ptext2.text = (int)inv.datosserial.tipohierba[20]+"                 "+((int)100 * rangoexp);
                ptext3.text = (int)inv.datosserial.tipohierba[1]+"                 "+((int)100 * rangoexp);
                ptext4.text = (int)inv.datosserial.tipohierba[11]+"                 "+((int)100 * rangoexp);
                ptext5.text = (int)inv.datosserial.tipohierba[21]+"                 "+((int)100 * rangoexp);
                ptext6.text = "";

                if(bichoselec == true && temp > 0.3f)
                {
                    if (i == 0 && inv.datosserial.dinero >= ((int)50 * rangoexp) && inv.datosserial.tipohierba[10] < 9)
                    {
                        inv.datosserial.tipohierba[10]++;
                        inv.datosserial.dinero -= ((int)50 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 0 && inv.datosserial.dinero < ((int)50 * rangoexp) && inv.datosserial.tipohierba[10] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 0 && inv.datosserial.dinero >= ((int)50 * rangoexp) && inv.datosserial.tipohierba[10] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[20] < 9)
                    {
                        inv.datosserial.tipohierba[20]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[20] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[20] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[1] < 9)
                    {
                        inv.datosserial.tipohierba[1]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[1] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[1] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[11] < 9)
                    {
                        inv.datosserial.tipohierba[11]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[11] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[11] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[21] < 9)
                    {
                        inv.datosserial.tipohierba[21]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[21] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[21] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }


                    
                
                }
                if(der == true && i < 5)
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
                puesto1.text = "hierba verde";
                puesto2.text = "hierba verde plateada";
                puesto3.text = "hierba verde dorada";
                puesto4.text = "hierba amarilla";
                puesto5.text = "hierba amarilla  plateada";
                puesto6.text = "hierba amarilla dorada";
                din.text = "dolares : "+(int)inv.datosserial.dinero;
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
                ptext1.text = (int)inv.datosserial.tipohierba[2]+"                 "+((int)100 * rangoexp);
                ptext2.text = (int)inv.datosserial.tipohierba[12]+"                 "+((int)100 * rangoexp);
                ptext3.text = (int)inv.datosserial.tipohierba[22]+"                 "+((int)100 * rangoexp);
                ptext4.text = (int)inv.datosserial.tipohierba[3]+"                 "+((int)100 * rangoexp);
                ptext5.text = (int)inv.datosserial.tipohierba[13]+"                 "+((int)100 * rangoexp);
                ptext6.text = (int)inv.datosserial.tipohierba[23]+"                 "+((int)100 * rangoexp);

                if(bichoselec == true && temp > 0.3f)
                {

                    if (i == 0 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[2] < 9)
                    {
                        inv.datosserial.tipohierba[2]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 0 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[2] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 0 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[2] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[12] < 9)
                    {
                        inv.datosserial.tipohierba[12]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[12] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[12] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[22] < 9)
                    {
                        inv.datosserial.tipohierba[22]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[22] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[22] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[3] < 9)
                    {
                        inv.datosserial.tipohierba[3]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[3] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[3] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[13] < 9)
                    {
                        inv.datosserial.tipohierba[13]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[13] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[13] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }
                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[23] < 9)
                    {
                        inv.datosserial.tipohierba[23]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[23] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[23] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }
                
                }
                if(der == true && i < 6)
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
                puesto1.text = "hierba azul";
                puesto2.text = "hierba azul plateada";
                puesto3.text = "hierba azul dorada";
                puesto4.text = "hierba roja";
                puesto5.text = "hierba roja plateada";
                puesto6.text = "hierba roja dorada";
                din.text = "dolares : "+(int)inv.datosserial.dinero;
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
                ptext1.text = (int)inv.datosserial.tipohierba[4]+"                 "+((int)100 * rangoexp);
                ptext2.text = (int)inv.datosserial.tipohierba[14]+"                 "+((int)100 * rangoexp);
                ptext3.text = (int)inv.datosserial.tipohierba[24]+"                 "+((int)100 * rangoexp);
                ptext4.text = (int)inv.datosserial.tipohierba[5]+"                 "+((int)100 * rangoexp);
                ptext5.text = (int)inv.datosserial.tipohierba[15]+"                 "+((int)100 * rangoexp);
                ptext6.text = (int)inv.datosserial.tipohierba[25]+"                 "+((int)100 * rangoexp);

                if(bichoselec == true && temp > 0.3f)
                {
                    if (i == 0 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[4] < 9)
                    {
                        inv.datosserial.tipohierba[4]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 0 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[4] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 0 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[4] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[14] < 9)
                    {
                        inv.datosserial.tipohierba[14]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[14] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[14] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[24] < 9)
                    {
                        inv.datosserial.tipohierba[24]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[24] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[24] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[5] < 9)
                    {
                        inv.datosserial.tipohierba[5]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[5] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[5] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[15] < 9)
                    {
                        inv.datosserial.tipohierba[15]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[15] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[15] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }
                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[25] < 9)
                    {
                        inv.datosserial.tipohierba[25]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[25] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[25] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }
                
                }
                if(der == true && i < 6)
                {
                    i++;
                }
                if(izq == true && i > -1)
                {
                    i--;
                }
        }
        if(tienda == 4)
        {       
                puesto1.text = "hierba morada";
                puesto2.text = "hierba morada plateada";
                puesto3.text = "hierba morada dorada";
                puesto4.text = "hierba naranja";
                puesto5.text = "hierba naranja plateada";
                puesto6.text = "hierba naranja dorada";
                din.text = "dolares : "+(int)inv.datosserial.dinero;
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
                ptext1.text = (int)inv.datosserial.tipohierba[6]+"                 "+((int)100 * rangoexp);
                ptext2.text = (int)inv.datosserial.tipohierba[16]+"                 "+((int)100 * rangoexp);
                ptext3.text = (int)inv.datosserial.tipohierba[26]+"                 "+((int)100 * rangoexp);
                ptext4.text = (int)inv.datosserial.tipohierba[7]+"                 "+((int)100 * rangoexp);
                ptext5.text = (int)inv.datosserial.tipohierba[17]+"                 "+((int)100 * rangoexp);
                ptext6.text = (int)inv.datosserial.tipohierba[27]+"                 "+((int)100 * rangoexp);

                if(bichoselec == true && temp > 0.3f)
                {
                    if (i == 0 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[6] < 9)
                    {
                        inv.datosserial.tipohierba[6]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 0 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[6] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 0 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[6] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[16] < 9)
                    {
                        inv.datosserial.tipohierba[16]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[16] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[16] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[26] < 9)
                    {
                        inv.datosserial.tipohierba[26]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[26] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[26] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[7] < 9)
                    {
                        inv.datosserial.tipohierba[7]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[7] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[7] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[17] < 9)
                    {
                        inv.datosserial.tipohierba[17]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[17] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[17] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }
                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[27] < 9)
                    {
                        inv.datosserial.tipohierba[27]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[27] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[27] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }
                
                }
                if(der == true && i < 6)
                {
                    i++;
                }
                if(izq == true && i > -1)
                {
                    i--;
                }
        }
        if(tienda == 5)
        {       
                puesto1.text = "hierba negra";
                puesto2.text = "hierba negra plateada";
                puesto3.text = "hierba negra dorada";
                puesto4.text = "hierba blanca";
                puesto5.text = "hierba blanca plateada";
                puesto6.text = "hierba blanca dorada";
                din.text = "dolares : "+(int)inv.datosserial.dinero;
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
                ptext1.text = (int)inv.datosserial.tipohierba[8]+"                 "+((int)100 * rangoexp);
                ptext2.text = (int)inv.datosserial.tipohierba[18]+"                 "+((int)100 * rangoexp);
                ptext3.text = (int)inv.datosserial.tipohierba[28]+"                 "+((int)100 * rangoexp);
                ptext4.text = (int)inv.datosserial.tipohierba[9]+"                 "+((int)100 * rangoexp);
                ptext5.text = (int)inv.datosserial.tipohierba[19]+"                 "+((int)100 * rangoexp);
                ptext6.text = (int)inv.datosserial.tipohierba[29]+"                 "+((int)100 * rangoexp);

                if(bichoselec == true && temp > 0.3f)
                {
                    if (i == 0 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[8] < 9)
                    {
                        inv.datosserial.tipohierba[8]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 0 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[8] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 0 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[8] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[18] < 9)
                    {
                        inv.datosserial.tipohierba[18]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[18] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[18] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[28] < 9)
                    {
                        inv.datosserial.tipohierba[28]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[28] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[28] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[9] < 9)
                    {
                        inv.datosserial.tipohierba[9]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[9] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[9] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }

                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[13] < 9)
                    {
                        inv.datosserial.tipohierba[13]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[13] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[13] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }
                    else if (i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[23] < 9)
                    {
                        inv.datosserial.tipohierba[23]++;
                        inv.datosserial.dinero -= ((int)100 * rangoexp);
                        mensaje.text = "buena compra";
                        inv.guardar();
                        inv._agregar2();
                        sibot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero < ((int)100 * rangoexp) && inv.datosserial.tipohierba[23] < 9)
                    {
                        mensaje.text = "no tienes saldo sufieciente";
                        nobot.Play();
                    }
                    else if(i == 1 && inv.datosserial.dinero >= ((int)100 * rangoexp) && inv.datosserial.tipohierba[23] >= 9)
                    {
                        mensaje.text = "tienes el limite de este objeto";
                        nobot.Play();
                    }
                
                }
                if(der == true && i < 6)
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
            if(tienda < 5)
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
