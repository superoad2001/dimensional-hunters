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
    public float clase ;
    public string raza ;
    public float rangor ;

    public Text nameenviar ;

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
    public float[] clasebarcelona;
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

    public GameObject ghost;
    public GameObject algosaurio;
    public GameObject bigfat;
    public GameObject cazafantasmas;

    public GameObject darkknight;
    public GameObject antidog;
    public GameObject pinguino;
    public GameObject craneovil;

    public GameObject dogtable;
    public GameObject bee;
    public GameObject elephant;
    public GameObject flyera;

    public GameObject friend;
    public GameObject gunman;
    public GameObject flanerio;
    public GameObject fenix;





    public GameObject kingdragon;
    public GameObject heavydevil;
    public GameObject kraken;
    public GameObject lizardo;

    public GameObject livedish;
    public GameObject pesadilla;
    public GameObject mirror;
    public GameObject rabmon;

    public GameObject ant;
    public GameObject kingslug;
    public GameObject rosedragon;
    public GameObject sharkman;

    public GameObject pollovion;
    public GameObject trepillo;
    public GameObject roboerto;
    public GameObject tufo;

    public GameObject trashrat;
    public GameObject spider;
    public GameObject vivodado;
    public GameObject dragonron;



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

        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();

        
        


        
        hp = inv.datosserial.hps;
        mana = inv.datosserial.manas;
        manarec = inv.datosserial.manarecs;
        fuerza = inv.datosserial.fuerzas;
        elemento =  inv.datosserial.elementos;
        nivel = inv.datosserial.nivels;
        clase = inv.datosserial.clases;
        raza = inv.datosserial.razas;
        rangor = inv.datosserial.rangors;
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
                elementot.text = "CAT : "+ elemento;
                nivelt.text = "NIVEL : "+nivel;
                
                if(bichoselec == true && temp > 0.3f)
                {
                   if(inv.datosserial.name.Count >= inv.datosserial.limite)
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
                    inv.datosserial.name.Add(name);
                    inv.datosserial.hp.Add(hp);
                    inv.datosserial.mana.Add(mana);
                    inv.datosserial.manarec.Add(manarec);
                    inv.datosserial.fuerza.Add(fuerza);
                    inv.datosserial.elemento.Add(elemento);
                    inv.datosserial.nivel.Add(nivel);
                    inv.datosserial.rango.Add(rangor);
                    inv.datosserial.bichosmios.Add(raza);
                    inv.datosserial.indexmax = inv.datosserial.name.Count;
                    inv.guardar();
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
                
                
                bichos = inv.datosserial.bichosmios;
                indexmax = bichos.Count;
                
                bichot2.text = inv.datosserial.name[i];
                bichoti2.text ="RAZA "+ bichos[i];
                hpt2.text = "VIT :"+ inv.datosserial.hp[i].ToString("F2");
                mat2.text = "STAMINA :"+inv.datosserial.mana[i].ToString("F2");
                rect2.text = "REC :"+inv.datosserial.manarec[i].ToString("F2");
                danot2.text = "FUE :"+inv.datosserial.fuerza[i].ToString("F2");
                elementot2.text = "CAT : "+inv.datosserial.elemento[i];
                nivelt2.text = "NIVEL : "+inv.datosserial.nivel[i];
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

            lib.text = "DESEAS LIBERAR A "+inv.datosserial.name[i];
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
    public void enviar()
    {
        uitext.text = nameenviar.text;
    }
    public void modelos0()
    {
        //1
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

         //2
        if(raza == "aghostin")
        {
            bichom.SetActive(false);
            bichom = ghost;
        }
        if(raza == "algosaurio")
        {
            bichom.SetActive(false);
            bichom = algosaurio;
        }
        if(raza == "bigfat")
        {
            bichom.SetActive(false);
            bichom = bigfat;
        }
        if(raza == "cazafantasmas")
        {
            bichom.SetActive(false);
            bichom = cazafantasmas;
        }
        //3
        if(raza == "darkknight")
        {
            bichom.SetActive(false);
            bichom = darkknight;
        }
        if(raza == "antidog")
        {
            bichom.SetActive(false);
            bichom = skybird;
        }
        if(raza == "cyberpinguino")
        {
            bichom.SetActive(false);
            bichom = pinguino;
        }
        if(raza == "craneovil")
        {
            bichom.SetActive(false);
            bichom = craneovil;
        }
        //4
        if(raza == "dogtable")
        {
            bichom.SetActive(false);
            bichom = dogtable;
        }
        if(raza == "beestosa")
        {
            bichom.SetActive(false);
            bichom = bee;
        }
        if(raza == "elephant")
        {
            bichom.SetActive(false);
            bichom = elephant;
        }
        if(raza == "flyera")
        {
            bichom.SetActive(false);
            bichom = flyera;
        }
        //5
        if(raza == "friend")
        {
            bichom.SetActive(false);
            bichom = friend;
        }
        if(raza == "gunman")
        {
            bichom.SetActive(false);
            bichom = gunman;
        }
        if(raza == "flanerio")
        {
            bichom.SetActive(false);
            bichom = flanerio;
        }
        if(raza == "fenix")
        {
            bichom.SetActive(false);
            bichom = fenix;
        }

        //1
        if(raza == "kingdragon")
        {
            bichom.SetActive(false);
            bichom = kingdragon;
        }
        if(raza == "heavydevil")
        {
            bichom.SetActive(false);
            bichom = heavydevil;
        }
        if(raza == "kraken")
        {
            bichom.SetActive(false);
            bichom = kraken;
        }
        if(raza == "lizardo")
        {
            bichom.SetActive(false);
            bichom = lizardo;
        }
         //2
        if(raza == "livedish")
        {
            bichom.SetActive(false);
            bichom = livedish;
        }
        if(raza == "pesadilla")
        {
            bichom.SetActive(false);
            bichom = pesadilla;
        }
        if(raza == "mirror")
        {
            bichom.SetActive(false);
            bichom = mirror;
        }
        if(raza == "rabmon")
        {
            bichom.SetActive(false);
            bichom = rabmon;
        }
        //3
        if(raza == "ant")
        {
            bichom.SetActive(false);
            bichom = ant;
        }
        if(raza == "kingslug")
        {
            bichom.SetActive(false);
            bichom = kingdragon;
        }
        if(raza == "rosedragon")
        {
            bichom.SetActive(false);
            bichom = rosedragon;
        }
        if(raza == "sharkman")
        {
            bichom.SetActive(false);
            bichom = sharkman;
        }
        //4
        if(raza == "pollovion")
        {
            bichom.SetActive(false);
            bichom = pollovion;
        }
        if(raza == "trepillo")
        {
            bichom.SetActive(false);
            bichom = trepillo;
        }
        if(raza == "roboerto")
        {
            bichom.SetActive(false);
            bichom = roboerto;
        }
        if(raza == "tufo")
        {
            bichom.SetActive(false);
            bichom = tufo;
        }
        //5
        if(raza == "trashrat")
        {
            bichom.SetActive(false);
            bichom = trashrat;
        }
        if(raza == "spider")
        {
            bichom.SetActive(false);
            bichom = spider;
        }
        if(raza == "vivodado")
        {
            bichom.SetActive(false);
            bichom = vivodado;
        }
        if(raza == "dragonron")
        {
            bichom.SetActive(false);
            bichom = dragonron;
        }

        bichom.SetActive(true);
    }
    public void modelos()
    {
        //1
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

        if(bichos[i] == "aghostin")
        {
            bichom.SetActive(false);
            bichom = ghost;
        }
        if(bichos[i] == "algosaurio")
        {
            bichom.SetActive(false);
            bichom = algosaurio;
        }
        if(bichos[i] == "bigfat")
        {
            bichom.SetActive(false);
            bichom = bigfat;
        }
        if(bichos[i] == "cazafantasmas")
        {
            bichom.SetActive(false);
            bichom = cazafantasmas;
        }
        //3
        if(bichos[i] == "darkknight")
        {
            bichom.SetActive(false);
            bichom = darkknight;
        }
        if(bichos[i] == "antidog")
        {
            bichom.SetActive(false);
            bichom = skybird;
        }
        if(bichos[i] == "cyberpinguino")
        {
            bichom.SetActive(false);
            bichom = pinguino;
        }
        if(bichos[i] == "craneovil")
        {
            bichom.SetActive(false);
            bichom = craneovil;
        }
        //4
        if(bichos[i] == "dogtable")
        {
            bichom.SetActive(false);
            bichom = dogtable;
        }
        if(bichos[i] == "beestosa")
        {
            bichom.SetActive(false);
            bichom = bee;
        }
        if(bichos[i] == "elephant")
        {
            bichom.SetActive(false);
            bichom = elephant;
        }
        if(bichos[i] == "flyera")
        {
            bichom.SetActive(false);
            bichom = flyera;
        }
        //5
        if(bichos[i] == "friend")
        {
            bichom.SetActive(false);
            bichom = friend;
        }
        if(bichos[i] == "gunman")
        {
            bichom.SetActive(false);
            bichom = gunman;
        }
        if(bichos[i] == "flanerio")
        {
            bichom.SetActive(false);
            bichom = flanerio;
        }
        if(bichos[i] == "fenix")
        {
            bichom.SetActive(false);
            bichom = fenix;
        }

        //1
        if(bichos[i] == "kingdragon")
        {
            bichom.SetActive(false);
            bichom = kingdragon;
        }
        if(bichos[i] == "heavydevil")
        {
            bichom.SetActive(false);
            bichom = heavydevil;
        }
        if(bichos[i] == "kraken")
        {
            bichom.SetActive(false);
            bichom = kraken;
        }
        if(bichos[i] == "lizardo")
        {
            bichom.SetActive(false);
            bichom = lizardo;
        }
         //2
        if(bichos[i] == "livedish")
        {
            bichom.SetActive(false);
            bichom = livedish;
        }
        if(bichos[i] == "pesadilla")
        {
            bichom.SetActive(false);
            bichom = pesadilla;
        }
        if(bichos[i] == "mirror")
        {
            bichom.SetActive(false);
            bichom = mirror;
        }
        if(bichos[i] == "rabmon")
        {
            bichom.SetActive(false);
            bichom = rabmon;
        }
        //3
        if(bichos[i] == "ant")
        {
            bichom.SetActive(false);
            bichom = ant;
        }
        if(bichos[i] == "kingslug")
        {
            bichom.SetActive(false);
            bichom = kingdragon;
        }
        if(bichos[i] == "rosedragon")
        {
            bichom.SetActive(false);
            bichom = rosedragon;
        }
        if(bichos[i] == "sharkman")
        {
            bichom.SetActive(false);
            bichom = sharkman;
        }
        //4
        if(bichos[i] == "pollovion")
        {
            bichom.SetActive(false);
            bichom = pollovion;
        }
        if(bichos[i] == "trepillo")
        {
            bichom.SetActive(false);
            bichom = trepillo;
        }
        if(bichos[i] == "roboerto")
        {
            bichom.SetActive(false);
            bichom = roboerto;
        }
        if(bichos[i] == "tufo")
        {
            bichom.SetActive(false);
            bichom = tufo;
        }
        //5
        if(bichos[i] == "trashrat")
        {
            bichom.SetActive(false);
            bichom = trashrat;
        }
        if(bichos[i] == "spider")
        {
            bichom.SetActive(false);
            bichom = spider;
        }
        if(bichos[i] == "vivodado")
        {
            bichom.SetActive(false);
            bichom = vivodado;
        }
        if(bichos[i] == "dragonron")
        {
            bichom.SetActive(false);
            bichom = dragonron;
        }


        bichom.SetActive(true);
    }
}
