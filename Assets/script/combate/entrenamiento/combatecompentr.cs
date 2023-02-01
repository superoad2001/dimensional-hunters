using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class combatecompentr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool cancela = false;
    public Text uitext;
    public int lim = 3;
    // Update is called once per frame
    public void _cancela()
    {
        cancela = true;
    }
    void Update()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        heroentr heroe = UnityEngine.Object.FindObjectOfType<heroentr>();
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
        if(uitext.text == "poción vital pequeña" && lim > 0 || uitext.text == "poción de vida pequeña" && lim > 0 )
        {
            uitext.text = "objetos limite "+ lim + " PocionVit(p) " +inv.pocvp ;
            heroe.hp += 40;
        }
        if(uitext.text == "poción vital mediana" && lim > 0  ||uitext.text == "poción de vida mediana" && lim > 0 )
        {
            uitext.text = "objetos limite "+ lim + " PocionVit(m) " +inv.pocvm ;
            heroe.hp += 100;
        }
        if(uitext.text == "poción vital grande" && lim > 0  ||uitext.text == "poción de vida grande" && lim > 0 )
        {
            uitext.text = "objetos limite "+ lim + " PocionVit(g) " +inv.pocvg ;
            heroe.hp += 200;
        }
        if(uitext.text == "poción de estamina pequeña" && lim > 0 ||uitext.text == "poción de esta mina pequeña"  )
        {
            uitext.text = "objetos limite "+ lim + " PocionSta(p) " +inv.pocmp ;
            heroe.mana += 90;
        }
        if(uitext.text == "poción de estamina mediana" && lim > 0  || uitext.text == "poción de esta mina mediana"  )
        {
            uitext.text = "objetos limite "+ lim + " PocionSta(m) " +inv.pocmm ;
            heroe.mana += 130;
        }
        if(uitext.text == "poción de estamina grande" && lim > 0  || uitext.text == "poción de esta mina grande" )
        {
            uitext.text = "objetos limite "+ lim + " PocionSta(g) " +inv.pocmg ;
            heroe.mana += 200;
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
