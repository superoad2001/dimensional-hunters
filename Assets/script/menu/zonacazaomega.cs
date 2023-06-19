using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class zonacazaomega : MonoBehaviour
{
    public int i = 0;
    public bool izqb;
    public bool derb;
    public Text hiert;
    public Text hiert2;
    public Text hiert3;
    public List<string> bicho = new List<string>();
    public AudioSource no;
    public void atras()
    {
        SceneManager.LoadScene("zonadecaza");
    }
    public void der()
    {
        derb = true;
    }
    public void izq()
    {
        izqb = true;
    }
    void Start()
    {
        bicho.Add( "bicho bloqueado n1");
        bicho.Add( "bicho bloqueado n2");
        bicho.Add( "bicho bloqueado n3");
        bicho.Add( "bicho bloqueado n4");

        
    }

    // Update is called once per frame
    void Update()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();

        if (derb == true && i < 3)
        {
            i++;
        }
        if (izqb == true && i > 0)
        {
            i--;
        }
    
        

        hiert.text = bicho[i] ;
        hiert2.text = "hierba omega X "+ inv.hierbaomega ;
        hiert3.text = "licencia de caza " + inv.licencia[i] ;
        izqb = false;
        derb = false;
    }
    public void cazar()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(i == 0 && inv.hierbaomega > 0 && inv.licencia[i] == "permitida")
        {
            inv.hierbaomega--;
            inv._agregar2();
            SceneManager.LoadScene("bicho1");
        }
        else if(i == 1 && inv.hierbaomega > 0 && inv.licencia[i] == "permitida")
        {
            inv.hierbaomega--;
            inv._agregar2();
            SceneManager.LoadScene("bicho2");
        }
        else if(i == 2 && inv.hierbaomega > 0 && inv.licencia[i] == "permitida")
        {
            inv.hierbaomega--;
            inv._agregar2();
            SceneManager.LoadScene("bicho3");
        }
        else if(i == 3 && inv.hierbaomega > 0 && inv.licencia[i] == "permitida")
        {
            inv.hierbaomega--;
            inv._agregar2();
            SceneManager.LoadScene("bicho4");
        }
        else{no.Play();}
    }
}
