using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class obtenermenu : MonoBehaviour
{
    public bool cajon = true;
    public bool nobich = false;
    public bool cajoncomb = false;
    public bool inventario1 = false;
    
    public bool bichoselec;

    public string name ;
    public float hp ;
    public float mana ;
    public float manarec ;
    public float fuerza ;
    public string elemento ;
    public float nivel ;
    public string raza ;

    //el hp para los terrenales
    //la mana para los viscosos
    //la fuerza para los de tipo fuerza
    //el gasto de mana para los aereos

    public string[] namebarcelona;
    public List<string> catalogo= new List<string>();
    public List<string> bichosmios = new List<string>();
    public float indexmax;


    public float[] hpbarcelona;
    public float[] manabarcelona;
    public float[] manarecbarcelona;
    public float[] fuerzabarcelona;
    public string[] elementobarcelona;
    public float[] nivelbarcelona;
    public List<string> bichosbarcelona = new List<string>();

    public string[] ciuda;

    public List<string> bichos = new List<string>();

    public float hps;
    public float manas;
    public float manarecs;
    public float fuerzas;

    public int index;
    public string com;
    public bool actbarcelona;
    public bool actnobichos;
    public bool actnombre;
    public bool actc;
    public bool acta;

    public bool cajonbarcelona;

    public bool der;
    public bool izq;
    public bool si;
    public bool no;

    public bool salir;
    public bool atras;
    public bool borrar;
    public bool borrar2;
    public bool borrarpre;
    public bool borrarpre1;
    public bool nombre2;
    public bool nombre;
    public bool borrar1;

    public bool nobichos;

    public GameObject elemento_;
    public GameObject elemt;
    public GameObject ciu;
    public GameObject nombre3;
    public GameObject borr;
    public GameObject bichno;

    public Text bicho;
    public Text bicho1;
    public Text bichot2;
    public float temp = 0;


    public Text hpt;
    public Text mat;
    public Text rect;
    public Text nivelt;
    public Text danot;
    public Text bichoti;
    public Text elementot;

    public Text hpt2;
    public Text mat2;
    public Text rect2;
    public Text nivelt2;
    public Text danot2;
    public Text bichoti2;
    public Text elementot2;




    public Text ciudatext;
    public Text lib;
    public Text namere;

    public Text uitext;

    public Text who;

    public GameObject bichom;
    

    public GameObject madcat;
    public GameObject shitfloor;
    public GameObject topo;
    public GameObject skybird;

    public GameObject madcat2;
    public GameObject shitfloor2;
    public GameObject topo2;
    public GameObject skybird2;

    public GameObject madcat3;
    public GameObject shitfloor3;
    public GameObject topo3;
    public GameObject skybird3;



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
    public void _borrar()
    {
        borrar2 = true;
    }








    void Start()
    {



        
        


        catalogo.Add( "skybird");
        catalogo.Add("topo topo");
        catalogo.Add("shitfloor");
        catalogo.Add("madcat");

        
        hp = PlayerPrefs.GetFloat("hpr", 10000);
        mana = PlayerPrefs.GetFloat("manar", 10000);
        manarec = PlayerPrefs.GetFloat("manarecr",1);
        fuerza = PlayerPrefs.GetFloat("fuerzar",1);
        elemento =  PlayerPrefs.GetString("tipor", "terreno");
        nivel = PlayerPrefs.GetFloat("nivelr", 1);
        raza = PlayerPrefs.GetString("razar", "madcat");
        name = raza;

        modelos0();
        


    }
    public int i = 1; 

    // Update is called once per frame
    void Update()
    {

        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(inventario1 == true && atras == true)
        {SceneManager.LoadScene("seleccion");}
     
        if (nombre == true)
        {
            inventario1 = false;
            elemento_.gameObject.SetActive(false);
            ciu.gameObject.SetActive(false);

            bicho = bicho1;

            nombre3.gameObject.SetActive(true);

            borr.gameObject.SetActive(false);

            bichno.gameObject.SetActive(false);
            cajon = false;
            actc = false;


            nombre2 = true;
            nombre = false;
            borrarpre = false;
            borrarpre1 = false;
            borrar = false;
            borrar1 = false;

            uitext.text = raza;
            
            
            
        }
       
        if (actc == true)
        {

            elemento_.gameObject.SetActive(true);



            ciu.gameObject.SetActive(false);



            nombre3.gameObject.SetActive(false);
            bicho = bicho1;
            borr.gameObject.SetActive(false);
            bichno.gameObject.SetActive(false);
            cajon = true;
            actc = false;
            nombre2 = false;
            nombre = false;
            borrarpre = false;
            borrarpre1 = false;
            borrar = false;
            borrar1 = false;
            
            
            
            
        }

        if (borrarpre1 == true)
        {

            elemento_.gameObject.SetActive(false);




            ciu.gameObject.SetActive(true);
            borr.gameObject.SetActive(false);


            nombre3.gameObject.SetActive(false);


            bichno.gameObject.SetActive(false);
            cajon = false;
            actc = false;
            nombre2 = false;
            nombre = false;
            bicho = bicho1;
            borrarpre = true;
            borrarpre1 = false;
            borrar = false;
            borrar1 = false;
            
            
            
            
        }
        if (borrar == true)
        {
            Debug.Log(1);
            elemento_.gameObject.SetActive(false);
            borr.gameObject.SetActive(true);


            ciu.gameObject.SetActive(false);

            bicho = bicho1;

            nombre3.gameObject.SetActive(false);


            bichno.gameObject.SetActive(false);
            cajon = false;
            actc = false;
            nombre2 = false;
            nombre = false;

            borrarpre = false;
            borrarpre1 = false;

            borrar = false;
            borrar1 = true;
            
            
            
        }
        if (actnobichos == true)
        {
            inventario1 = false;
            elemento_.gameObject.SetActive(false);
            nombre3.gameObject.SetActive(false);
            ciu.gameObject.SetActive(false);
            bichno.gameObject.SetActive(true);
            borr.gameObject.SetActive(false);
            bicho = bicho1;
            cajon = false;
            actc = false;
            nobich = true;
            actnobichos = false;
            
            
            
        }





        if(cajon == true)
        {
                

                bichoti.text ="RAZA "+ raza;
                hpt.text = "VIT :"+(int)hp;
                mat.text = "STAMINA :"+(int)mana;
                rect.text = "REC :"+manarec.ToString("F2");
                danot.text = "FUE :"+fuerza.ToString("F2");
                elementot.text = "ELEM : "+ elemento;
                nivelt.text = "NIVEL : "+nivel;
                
                if(bichoselec == true && temp > 0.3f)
                {
                   if(inv.name.Count >= inv.limite)
                   {
                        borrarpre1 = true;
                   }
                   else
                   {
                        nombre = true;
                   }
                
                }
                if(atras == true && temp > 0.3f)
                {
                   
                    SceneManager.LoadScene("seleccion");
                }
        }
        if(nombre2 == true)
        {
                
               
                
                modelos0();
                if(bichoselec == true && temp > 0.3f && uitext.text != "" )
                {
                    name = uitext.text;
                    inv.name.Add(name);
                    inv.hp.Add(hp);
                    inv.mana.Add(mana);
                    inv.manarec.Add(manarec);
                    inv.fuerza.Add(fuerza);
                    inv.elemento.Add(elemento);
                    inv.nivel.Add(nivel);
                    inv.bichosmios.Add(raza);
                   for(int i = 0;i < inv.name.Count ; i++)
                    {
                        PlayerPrefs.SetString("namesave"+i ,inv.name[i]);
                        
                    }
                    for(int i = 0;i< inv.hp.Count ; i++)
                    {
                        PlayerPrefs.SetFloat("hpsave"+i,(int)inv.hp[i]);
                    }
                    for(int i = 0;i< inv.mana.Count ; i++)
                    {
                        PlayerPrefs.SetFloat("manasave"+i,(int)inv.mana[i]);
                    }
                    for(int i = 0;i< inv.manarec.Count ; i++)
                    {
                        PlayerPrefs.SetFloat("manarecsave"+i,inv.manarec[i]);
                    }
                    for(int i = 0;i< inv.fuerza.Count ; i++)
                    {
                        PlayerPrefs.SetFloat("fuerzasave"+i,inv.fuerza[i]);
                    }
                    for(int i = 0;i< inv.nivel.Count ; i++)
                    {
                        PlayerPrefs.SetFloat("nivelsave"+i,inv.nivel[i]);
                    }
                    for(int i = 0;i< inv.elemento.Count ; i++)
                    {
                        PlayerPrefs.SetString("elementosave"+i,inv.elemento[i]);
                    }
                    for(int i = 0;i< inv.bichosmios.Count ; i++)
                    {
                        PlayerPrefs.SetString("bichosmiossave"+i,inv.bichosmios[i]);
                    }
                    inv.indexmax = inv.name.Count;
                    PlayerPrefs.SetFloat("index",inv.indexmax);
                    SceneManager.LoadScene("seleccion");
                }
        }
        if(borrarpre == true)
        {
                
               
                namere.text = name;
                modelos0();
                if(si == true)
                {
                    borrar = true;
                    
                }
                if(no == true )
                {
                    actc = true;
                }
        }
        if(borrar1 == true)
        {
                
                
                bichos = inv.bichosmios;
                indexmax = bichos.Count;
                
                bichot2.text = inv.name[i];
                bichoti2.text ="RAZA "+ bichos[i];
                hpt2.text = "VIT :"+ inv.hp[i].ToString("F2");
                mat2.text = "STAMINA :"+inv.mana[i].ToString("F2");
                rect2.text = "REC :"+inv.manarec[i].ToString("F2");
                danot2.text = "FUE :"+inv.fuerza[i].ToString("F2");
                elementot2.text = "ELEM : "+inv.elemento[i];
                nivelt2.text = "NIVEL : "+inv.nivel[i];
                who.text = "TUS HEROES";
                modelos();
                if(borrar2 == true && temp > 0.3f)
                {
                    actnobichos = true;
                
                }
            if (izq == true && i > 0 && temp > 0.3f)
            {
                i--;
                temp = 0;
            }
            if (der == true && i < indexmax - 1 && temp > 0.3f)
            {
                i++;
                temp = 0;
            }
            if(atras == true)
            {actc = true;}
            
        }
        if(nobich == true)
        {

            lib.text = "DESEAS LIBERAR A "+inv.name[i];
            if(si == true)
            {
                inv.o = i;
                inv._borrar();
                i--;
                actc = true;
            }
            if(no == true)
            {
                actc = true;
            }
            
        }
        
    
    
        if (temp < 15)
        {temp += 1 * Time.deltaTime;}
        bichoselec = false;
        if(uitext.text.Length > 10)
        {uitext.text = com;}
        com = uitext.text;
        izq = false;
        der = false;
        salir = false;
        atras = false;
        si = false;
        no = false;
        borrar2 = false;

    }
    public void modelos0()
    {
         if(raza == "madcat")
        {
            bichom.SetActive(false);
            bichom = madcat;
        }
    
        if(raza == "shitfloor")
        {
            bichom.SetActive(false);
            bichom = shitfloor;
            
        }
        
        if(raza == "topo topo")
        {
            bichom.SetActive(false);
            bichom = topo;
        }
        
        if(raza == "skybird")
        {
            bichom.SetActive(false);
            bichom = skybird;
        }






        if(raza == "happycat")
        {
            bichom.SetActive(false);
            bichom = madcat2;
        }
    
        if(raza == "shitplus")
        {
            bichom.SetActive(false);
            bichom = shitfloor2;
            
        }
        
        if(raza == "toto topo")
        {
            bichom.SetActive(false);
            bichom = topo2;
        }
        
        if(raza == "sunbird")
        {
            bichom.SetActive(false);
            bichom = skybird2;
        }



        if(raza == "crazycat")
        {
            bichom.SetActive(false);
            bichom = madcat3;
        }
    
        if(raza == "shitplusplus")
        {
            bichom.SetActive(false);
            bichom = shitfloor3;
            
        }
        
        if(raza == "poro topo")
        {
            bichom.SetActive(false);
            bichom = topo3;
        }
        
        if(raza == "moonbird")
        {
            bichom.SetActive(false);
            bichom = skybird3;
        }
        bichom.SetActive(true);
    }
    public void modelos()
    {
         if(bichos[i] == "madcat")
        {
            bichom.SetActive(false);
            bichom = madcat;
        }
    
        if(bichos[i] == "shitfloor")
        {
            bichom.SetActive(false);
            bichom = shitfloor;
            
        }
        
        if(bichos[i] == "topo topo")
        {
            bichom.SetActive(false);
            bichom = topo;
        }
        
        if(bichos[i] == "skybird")
        {
            bichom.SetActive(false);
            bichom = skybird;
        }






        if(bichos[i] == "happycat")
        {
            bichom.SetActive(false);
            bichom = madcat2;
        }
    
        if(bichos[i] == "shitplus")
        {
            bichom.SetActive(false);
            bichom = shitfloor2;
            
        }
        
        if(bichos[i] == "toto topo")
        {
            bichom.SetActive(false);
            bichom = topo2;
        }
        
        if(bichos[i] == "sunbird")
        {
            bichom.SetActive(false);
            bichom = skybird2;
        }



        if(bichos[i] == "crazycat")
        {
            bichom.SetActive(false);
            bichom = madcat3;
        }
    
        if(bichos[i] == "shitplusplus")
        {
            bichom.SetActive(false);
            bichom = shitfloor3;
            
        }
        
        if(bichos[i] == "poro topo")
        {
            bichom.SetActive(false);
            bichom = topo3;
        }
        
        if(bichos[i] == "moonbird")
        {
            bichom.SetActive(false);
            bichom = skybird3;
        }
        bichom.SetActive(true);
    }
}
