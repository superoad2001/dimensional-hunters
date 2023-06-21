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
        if(uitext.text == "poción vital pequeña" && lim > 0 && inv.pocvp > 0|| uitext.text == "poción de vida pequeña" && lim > 0 && inv.pocvp > 0)
        {
            
            inv.pocvp--;
            heroe.hp += 40;
            lim--;
            uitext.text = "objetos limite"+ lim + " PocionVit(p) " +inv.pocvp ;
        }
        if(uitext.text == "poción vital mediana" && lim > 0 && inv.pocvm > 0 ||uitext.text == "poción de vida mediana" && lim > 0 && inv.pocvm > 0)
        {
            
            inv.pocvm--;
            heroe.hp += 100;
            lim--;
            uitext.text = "objetos limite "+ lim + " PocionVit(m) " +inv.pocvm ;
        }
        if(uitext.text == "poción vital grande" && lim > 0 && inv.pocvg > 0 ||uitext.text == "poción de vida grande" && lim > 0 && inv.pocvg > 0 )
        {
            
            inv.pocvg--;
            heroe.hp += 200;
            lim--;
            uitext.text = "objetos limite "+ lim + " PocionVit(g) " +inv.pocvg ;
        }
        if(uitext.text == "poción de estamina pequeña" && lim > 0 && inv.pocmp > 0 || uitext.text == "poción de esta mina pequeña" && lim > 0 && inv.pocmp > 0 )
        {
            inv.pocmp--;
            heroe.mana += 90;
            lim--;
            uitext.text = "objetos limite "+ lim + " PocionSta(p) " +inv.pocmp ;
        }
        if(uitext.text == "poción de estamina mediana" && lim > 0 && inv.pocmm > 0 || uitext.text == "poción de esta mina mediana" && lim > 0 && inv.pocmm > 0 )
        {
            
            inv.pocmm--;
            heroe.mana += 130;
            lim--;
            uitext.text = "objetos limite "+ lim + " PocionSta(m) " +inv.pocmm ;
        }
        if(uitext.text == "poción de estamina grande" && lim > 0 && inv.pocmg > 0 || uitext.text == "poción de esta mina grande"  && lim > 0 && inv.pocmg > 0)
        {
            
            inv.pocmg--;
            heroe.mana += 200;
            lim--;
            uitext.text = "objetos limite "+ lim + " PocionSta(g) " +inv.pocmg ;
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
