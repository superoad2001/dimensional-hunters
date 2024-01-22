using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class inventariomenu : MonoBehaviour
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

    public int rango;

    // Start is called before the first frame update

     public void _atras()
    {
        atras = true;
    }
    public void _izqmod()
    {
        izqmod = true;
    }
     public void _dermod()
    {
        dermod = true;
    }








    void Start()
    {

        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        rango = inv.datosserial.rangoplay;

    }

    // Update is called once per frame
    void Update()
    {

        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(atras == true)
        {SceneManager.LoadScene("seleccion2");}



        uitext.text = "heroes "+inv.datosserial.indexmax+"/"+inv.datosserial.limite;
    

        if(tienda == 1)
        {       
                puesto1.text = "rango de caza";
                puesto2.text = "almacenamiento";
                puesto3.text = "heroes";
                puesto4.text = "";
                puesto5.text = "";
                puesto6.text = "";
                din.text = "dolares : "+inv.datosserial.dinero.ToString("F0");
                ptext1.text = ""+rango;
                ptext2.text = ""+inv.datosserial.limite;
                ptext3.text = ""+inv.datosserial.indexmax;
                ptext4.text = "";
                ptext5.text = "";
                ptext6.text = "";

        }
        if(tienda == 2)
        {       
                puesto1.text = "hierba comun";
                puesto2.text = "hierba comun plateada";
                puesto3.text = "hierba comun dorada";
                puesto4.text = "hierba gris";
                puesto5.text = "hierba gris plateada";
                puesto6.text = "hierba gris dorada";
                din.text = "dolares : "+""+inv.datosserial.dinero.ToString("F0");
               
                ptext1.text = ""+(float)inv.datosserial.tipohierba[0];
                ptext2.text = ""+(float)inv.datosserial.tipohierba[10];
                ptext3.text = ""+(float)inv.datosserial.tipohierba[20];
                ptext4.text = ""+(float)inv.datosserial.tipohierba[1];
                ptext5.text = ""+(float)inv.datosserial.tipohierba[11];
                ptext6.text = ""+(float)inv.datosserial.tipohierba[21];

                
        }
        if(tienda == 3)
        {       
                puesto1.text = "hierba verde";
                puesto2.text = "hierba verde plateada";
                puesto3.text = "hierba verde dorada";
                puesto4.text = "hierba amarilla";
                puesto5.text = "hierba amarilla plateada";
                puesto6.text = "hierba amarilla dorada";
                din.text = "dolares : "+""+inv.datosserial.dinero.ToString("F0");
               
                ptext1.text = ""+(float)inv.datosserial.tipohierba[2];
                ptext2.text = ""+(float)inv.datosserial.tipohierba[12];
                ptext3.text = ""+(float)inv.datosserial.tipohierba[22];
                ptext4.text = ""+(float)inv.datosserial.tipohierba[3];
                ptext5.text = ""+(float)inv.datosserial.tipohierba[13];
                ptext6.text = ""+(float)inv.datosserial.tipohierba[23];

                
        }
        if(tienda == 4)
        {       
                puesto1.text = "hierba azul";
                puesto2.text = "hierba azul plateada";
                puesto3.text = "hierba azul dorada";
                puesto4.text = "hierba roja";
                puesto5.text = "hierba roja plateada";
                puesto6.text = "hierba roja dorada";
                din.text = "dolares : "+""+inv.datosserial.dinero.ToString("F0");
               
                ptext1.text = ""+(float)inv.datosserial.tipohierba[4];
                ptext2.text = ""+(float)inv.datosserial.tipohierba[14];
                ptext3.text = ""+(float)inv.datosserial.tipohierba[24];
                ptext4.text = ""+(float)inv.datosserial.tipohierba[5];
                ptext5.text = ""+(float)inv.datosserial.tipohierba[15];
                ptext6.text = ""+(float)inv.datosserial.tipohierba[25];

                
        }
        if(tienda == 5)
        {       
                puesto1.text = "hierba morada";
                puesto2.text = "hierba morada plateada";
                puesto3.text = "hierba morada dorada";
                puesto4.text = "hierba naranja";
                puesto5.text = "hierba naranja plateada";
                puesto6.text = "hierba naranja dorada";
                din.text = "dolares : "+""+inv.datosserial.dinero.ToString("F0");
               
                ptext1.text = ""+(float)inv.datosserial.tipohierba[6];
                ptext2.text = ""+(float)inv.datosserial.tipohierba[16];
                ptext3.text = ""+(float)inv.datosserial.tipohierba[26];
                ptext4.text = ""+(float)inv.datosserial.tipohierba[7];
                ptext5.text = ""+(float)inv.datosserial.tipohierba[17];
                ptext6.text = ""+(float)inv.datosserial.tipohierba[27];

                
        }
        if(tienda == 6)
        {       
                puesto1.text = "hierba negra";
                puesto2.text = "hierba negra plateada";
                puesto3.text = "hierba negra dorada";
                puesto4.text = "hierba blanca";
                puesto5.text = "hierba blanca plateada";
                puesto6.text = "hierba blanca dorada";
                din.text = "dolares : "+""+inv.datosserial.dinero.ToString("F0");
               
                ptext1.text = ""+(float)inv.datosserial.tipohierba[8];
                ptext2.text = ""+(float)inv.datosserial.tipohierba[18];
                ptext3.text = ""+(float)inv.datosserial.tipohierba[28];
                ptext4.text = ""+(float)inv.datosserial.tipohierba[9];
                ptext5.text = ""+(float)inv.datosserial.tipohierba[19];
                ptext6.text = ""+(float)inv.datosserial.tipohierba[29];

                
        }
        if(tienda == 7)
        {       
                puesto1.text = "hierba omega";
                puesto2.text = "licencia bicho1";
                puesto3.text = "licencia bicho2";
                puesto4.text = "licencia bicho3";
                puesto5.text = "licencia bicho4";
                puesto6.text = "";
                din.text = "dolares : "+""+inv.datosserial.dinero.ToString("F0");
               
                ptext1.text = ""+inv.datosserial.hierbaomega;
                ptext2.text = ""+inv.datosserial.licencia[0];
                ptext3.text = ""+inv.datosserial.licencia[1];
                ptext4.text = ""+inv.datosserial.licencia[2];
                ptext5.text = ""+inv.datosserial.licencia[3];
                ptext6.text = "";

                
        }
         if(tienda == 8)
        {       
                puesto1.text = "licencia bicho6";
                puesto2.text = "licencia bicho7";
                puesto3.text = "licencia bicho8";
                puesto4.text = "licencia bicho9";
                puesto5.text = "licencia bicho10";
                puesto6.text = "licencia bicho11";
                din.text = "dolares : "+""+inv.datosserial.dinero.ToString("F0");
               
                ptext1.text = ""+inv.datosserial.licencia[5];
                ptext2.text = ""+inv.datosserial.licencia[6];
                ptext3.text = ""+inv.datosserial.licencia[7];
                ptext4.text = ""+inv.datosserial.licencia[8];
                ptext5.text = ""+inv.datosserial.licencia[9];
                ptext6.text = ""+inv.datosserial.licencia[10];

                
        }
        if(dermod == true)
        {
            if(tienda < 7)
            {
                tienda++;
            }
        }
        else if(izqmod == true)
        {
            if(tienda > 1)
            {
                tienda--;
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
