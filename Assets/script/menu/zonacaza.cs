using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class zonacaza : MonoBehaviour
{
    public AudioSource no;
    public int i = 0;
    public bool izqb;
    public bool derb;
    public int alt = 1;
    public Text hiert;
    public List<string> hierb = new List<string>();
    public Text omegatext;
    public int tutorial5;
    public void atras()
    {
        SceneManager.LoadScene("seleccion");
    }
    public void der()
    {
        derb = true;
    }
    public void izq()
    {
        izqb = true;
    }
    public void _alt()
    {
        if(alt == 1)
        {
            alt = 2;
            i += 10;
        }
        else if(alt == 2)
        {
            alt = 3;
            i += 10;
        }
        else if(alt == 3)
        {
            alt = 1;
            i -= 20;
        }
    }
    public void omega()
    {
    SceneManager.LoadScene("cazasomega");
    }
    void Start()
    {

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        hierb.Add( "hierba comun");
        hierb.Add( "hierba gris");
        hierb.Add( "hierba verde");
        hierb.Add( "hierba amarilla");
        hierb.Add( "hierba azul");
        hierb.Add( "hierba roja");
        hierb.Add( "hierba morada");
        hierb.Add( "hierba naranja");
        hierb.Add( "hierba negra");
        hierb.Add( "hierba blanca");

        hierb.Add( "hierba comun plateada");
        hierb.Add( "hierba gris plateada");
        hierb.Add( "hierba verde plateada");
        hierb.Add( "hierba amarilla plateada");
        hierb.Add( "hierba azul plateada");
        hierb.Add( "hierba roja plateada");
        hierb.Add( "hierba morada plateada");
        hierb.Add( "hierba naranja plateada");
        hierb.Add( "hierba negra plateada");
        hierb.Add( "hierba blanca plateada");

        hierb.Add( "hierba comun dorada");
        hierb.Add( "hierba gris dorada");
        hierb.Add( "hierba verde dorada");
        hierb.Add( "hierba amarilla dorada");
        hierb.Add( "hierba azul dorada");
        hierb.Add( "hierba roja dorada");
        hierb.Add( "hierba morada dorada");
        hierb.Add( "hierba naranja dorada");
        hierb.Add( "hierba negra dorada");
        hierb.Add( "hierba blanca dorada");



        
    }

    // Update is called once per frame
    void Update()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if (alt == 1)
        {
            if (derb == true && i < 9)
            {
                i++;
            }
            if (izqb == true && i > 0)
            {
                i--;
            }
        }
        if (alt == 2)
        {
            if (derb == true && i < 19)
            {
                i++;
            }
            if (izqb == true && i > 10)
            {
                i--;
            }
        }
        if (alt == 3)
        {
            if (derb == true && i < 29)
            {
                i++;
            }
            if (izqb == true && i > 20)
            {
                i--;
            }
        }
        
        if (i == 0)
        {hiert.text = hierb[i];}
        else
        {hiert.text = hierb[i] +" X "+ inv.datosserial.tipohierba[i] ;}
        izqb = false;
        derb = false;
    }
    public void cazar()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(i == 0)
        {
            SceneManager.LoadScene("cazar");
            inv.datosserial.hierbau = 1 ;
            inv.guardar();
        }
        else if(i == 1 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 1 ;
            inv.guardar();
            SceneManager.LoadScene("cazar2");
        }
        else if(i == 2 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 1 ;
            inv.guardar();
            SceneManager.LoadScene("cazar3");
        }
        else if(i == 3 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 1 ;
            inv.guardar();
            SceneManager.LoadScene("cazar4");
        }
        else if(i == 4 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 1 ;
            inv.guardar();
            SceneManager.LoadScene("cazar5");
        }
        else if(i == 5 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 1 ;
            inv.guardar();
            SceneManager.LoadScene("cazar6");
        }
        else if(i == 6 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 1 ;
            inv.guardar();
            SceneManager.LoadScene("cazar7");
        }
        else if(i == 7 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 1 ;
            inv.guardar();
            SceneManager.LoadScene("cazar8");
        }
        else if(i == 8 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 1 ;
            inv.guardar();
            SceneManager.LoadScene("cazar9");
        }
        else if(i == 9 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 1 ;
            inv.guardar();
            SceneManager.LoadScene("cazar10");
        }
        else if(i == 10 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 2;
            inv.guardar();
            SceneManager.LoadScene("cazar");
        }
        else if(i == 11 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 2;
            inv.guardar();
            SceneManager.LoadScene("cazar2");
        }
        else if(i == 12 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 2;
            inv.guardar();
            SceneManager.LoadScene("cazar3");
        }
        else if(i == 13 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 2;
            inv.guardar();
            SceneManager.LoadScene("cazar4");
        }
        else if(i == 14 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 2;
            inv.guardar();
            SceneManager.LoadScene("cazar5");
        }
        else if(i == 15 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 2;
            inv.guardar();
            SceneManager.LoadScene("cazar6");
        }
        else if(i == 16 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 2;
            inv.guardar();
            SceneManager.LoadScene("cazar7");
        }
        else if(i == 17 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 2;
            inv.guardar();
            SceneManager.LoadScene("cazar8");
        }
        else if(i == 18 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 2;
            inv.guardar();
            SceneManager.LoadScene("cazar9");
        }
        else if(i == 19 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 2;
            inv.guardar();
            SceneManager.LoadScene("cazar10");
        }
        else if(i == 20 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 3;
            inv.guardar();
            SceneManager.LoadScene("cazar");
        }
        else if(i == 21 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 3;
            inv.guardar();
            SceneManager.LoadScene("cazar2");
        }
        else if(i == 22 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 3;
            inv.guardar();
            SceneManager.LoadScene("cazar3");
        }
        else if(i == 23 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 3;
            inv.guardar();
            SceneManager.LoadScene("cazar4");
        }
        else if(i == 24 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 3;
            inv.guardar();
            SceneManager.LoadScene("cazar5");
        }
        else if(i == 25 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 3;
            inv.guardar();
            SceneManager.LoadScene("cazar6");
        }
        else if(i == 26 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 3;
            inv.guardar();
            SceneManager.LoadScene("cazar7");
        }
        else if(i == 27 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 3;
            inv.guardar();
            SceneManager.LoadScene("cazar8");
        }
        else if(i == 28 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 3;
            inv.guardar();
            SceneManager.LoadScene("cazar9");
        }
        else if(i == 29 && inv.datosserial.tipohierba[i] > 0)
        {
            inv.datosserial.tipohierba[i]--;
            inv._agregar2();
            inv.datosserial.hierbau = 3;
            inv.guardar();
            SceneManager.LoadScene("cazar10");
        }
        else{no.Play();}
    }
}
