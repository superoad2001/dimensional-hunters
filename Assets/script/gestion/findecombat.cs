using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class findecombat : MonoBehaviour
{
    public float obj;
    public int dobj;
    public bool p1;
    public int jefe1;
    public float rango;
    public float rango2;
    public float rangoexp;
    public float rangoexp2;
    public float rangoexp3;
    // Start is called before the first frame update
    void Start()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        nivelg = (int)inv.datosserial.nivelene;
        o = (int)inv.datosserial.varsel1;
        rango2 = (int)inv.datosserial.rangoene;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        hptt.text = "vit : "+inv.datosserial.hp[o];
        manat.text = "sta : "+inv.datosserial.mana[o];
        manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
        danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
        elementot.text = "categoria : "+inv.datosserial.elemento[o];
        bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
        nivelt.text = "nivel : "+inv.datosserial.nivel[o];
        rango = inv.datosserial.rango[o];


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

        if(rango2 == 1)
        {rangoexp2 = 1;}
        if(rango2 == 2)
        {rangoexp2 = 1.50f;}
        if(rango2 == 3)
        {rangoexp2 = 2f;}
        if(rango2 == 4)
        {rangoexp2 = 2.50f;}
        if(rango2 == 5)
        {rangoexp2 = 3f;}

        if(rango2 == 6)
        {rangoexp2 = 3.25f;}
        if(rango2 == 7)
        {rangoexp2 = 3.75f;}
        if(rango2 == 8)
        {rangoexp2 = 4.25f;}
        if(rango2 == 9)
        {rangoexp2 = 4.75f;}
        if(rango2 == 10)
        {rangoexp2 = 5.25f;}

        if(rango2 == 11)
        {rangoexp2 = 5.5f;}
        if(rango2 == 12)
        {rangoexp2 = 6f;}
        if(rango2 == 13)
        {rangoexp2 = 6.50f;}
        if(rango2 == 14)
        {rangoexp2 = 7f;}
        if(rango2 == 15)
        {rangoexp2 = 7.50f;}

        if(rango2 == 16)
        {rangoexp2 = 7.75f;}
        if(rango2 == 17)
        {rangoexp2 = 8.25f;}
        if(rango2 == 48)
        {rangoexp2 = 8.75f;}
        if(rango2 == 19)
        {rangoexp2 = 9.25f;}
        if(rango2 == 20)
        {rangoexp2 = 9.75f;}

        if(rango2 == 21)
        {rangoexp2 = 10;}

        if(rango == 1)
        {rangoexp3 = 1;}
        if(rango == 2)
        {rangoexp3 = 2f;}
        if(rango == 3)
        {rangoexp3 = 3f;}
        if(rango == 4)
        {rangoexp3 = 4f;}
        if(rango == 5)
        {rangoexp3 = 5f;}

        if(rango == 6)
        {rangoexp3 = 6f;}
        if(rango == 7)
        {rangoexp3 = 7f;}
        if(rango == 8)
        {rangoexp3 = 8f;}
        if(rango == 9)
        {rangoexp3 = 9f;}
        if(rango == 10)
        {rangoexp3 = 10f;}

        if(rango == 11)
        {rangoexp3 = 11f;}
        if(rango == 12)
        {rangoexp3 = 12f;}
        if(rango == 13)
        {rangoexp3 = 13f;}
        if(rango == 14)
        {rangoexp3 = 14f;}
        if(rango == 15)
        {rangoexp3 = 15f;}

        if(rango == 16)
        {rangoexp3 = 16f;}
        if(rango == 17)
        {rangoexp3 = 17f;}
        if(rango == 18)
        {rangoexp3 = 18f;}
        if(rango == 19)
        {rangoexp3 = 19f;}
        if(rango == 20)
        {rangoexp3 = 20f;}

        if(rango == 21)
        {rangoexp3 = 21;}

        
        if(nivelg == 1)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(20,27) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero + Random.Range(10,20) * (int)rangoexp2;}
        if(nivelg == 2)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(40,65) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero +Random.Range(25,40) * (int)rangoexp2;}
        if(nivelg == 3)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(80,120) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero +Random.Range(50,75) * (int)rangoexp2;}
        if(nivelg == 4)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(150,200) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero +Random.Range(100,130) * (int)rangoexp2;}
        if(nivelg == 5)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(200,230) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero + Random.Range(150,190) * (int)rangoexp2;}
        if(nivelg == 6)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(230,250) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero + Random.Range(200,220) * (int)rangoexp2;}
        if(nivelg == 7)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(250,270) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero + Random.Range(230,250) * (int)rangoexp2;}
        if(nivelg == 8)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(270,290) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero + Random.Range(270,300) * (int)rangoexp2;}
        if(nivelg == 9)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(290,320) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero + Random.Range(300,350) * (int)rangoexp2;}
        if(nivelg == 10)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(330,390) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero + Random.Range(360,390) * (int)rangoexp2;}
        if(nivelg == 11)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(400,450) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero + Random.Range(400,490) * (int)rangoexp2;}
        if(nivelg == 12)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(470,530) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero + Random.Range(500,570) * (int)rangoexp2;}
        if(nivelg == 13)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(600,650) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero + Random.Range(580,680) * (int)rangoexp2;}
        if(nivelg == 14)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(680,740) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero + Random.Range(700,800) * (int)rangoexp2;}
        if(nivelg == 15)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(780,840) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero + Random.Range(800,999) * (int)rangoexp2;}
        if(nivelg == 16)
        {obj = (int)inv.datosserial.exp[o] + Random.Range(860,999) * (int)rangoexp2;
        dobj = (int)inv.datosserial.dinero + Random.Range(1000,1200) * (int)rangoexp2;}
        

        

        modelos();

        
    }
    public int o;
    
    public Image expv;
    public Text subiste;

    public Text monedat;

    public int nivelg;

    public GameObject hp;
    public GameObject ma;
    public GameObject rec;
    public GameObject fue;

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

    public AudioSource fueson;
    public AudioSource rapson;
    public AudioSource fulson;
    public AudioSource defson;
    public AudioSource turboson;

    public GameObject cont;

    public bool hpp;
    public bool map;
    public bool recp;
    public bool fuep;


    public Text hpt;
    public Text mat;
    public Text rect;
    public Text fuet;

    public Text hptt;
    public Text manat;
    public Text manarect;
    public Text nivelt;
    public Text danot;
    public Text bichoti;
    public Text elementot;
    public Text nivel;
    public bool sub;

    public AudioSource dinsound;
    public bool permiso;
    public bool vez1;
    // Update is called once per frame
    public void _hp()
    {
        hpp = true;
        vez1 = false;
    }
    public void _ma()
    {
        map = true;
        vez1 = false;
    }
    public void _rec()
    {
        recp = true;
        vez1 = false;
    }
    public void _fue()
    {
        fuep = true;
        vez1 = false;
    }
    public void _cont()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        inv._agregar2();
        if(inv.datosserial.modotorneo == true)
        {
            if(inv.datosserial.torneopuesto >= 2)
            {
                inv.datosserial.modotorneo = false;
                inv.guardar();
                SceneManager.LoadScene("obtener");
            }
            else
            {
            inv.datosserial.torneopuesto++;
            inv.guardar();
            SceneManager.LoadScene("combate");
            }
        }
        else
        {SceneManager.LoadScene("seleccion");}
    }
    void Update()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        
        if (inv.datosserial.nivel[o] == 1 )
        {
            expv.fillAmount = inv.datosserial.exp[o]/27;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {
                
                if(inv.datosserial.exp[o] < obj)
                {
                    if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}
                    dinsound.loop = true;
                    inv.datosserial.exp[o] += obj/4 * Time.deltaTime;
                    
                }
                inv.datosserial.exp[o] = inv.datosserial.exp[o];
                expv.fillAmount = inv.datosserial.exp[o]/27;
            }
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
            
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }

        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o] == 1)
        {
            sub = false;
       
            
        }
        if(inv.datosserial.exp[o] >= 27 * rangoexp && inv.datosserial.nivel[o] == 1)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];

            obj -= 27 * rangoexp;
            subiste.text = "has subido de nivel";
            
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
            
        }
        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 2)
        {
            sub = false;
            
            
        }
        if(inv.datosserial.exp[o] < 65 * rangoexp && inv.datosserial.nivel[o]== 2 && permiso == true)
        {
            expv.fillAmount = inv.datosserial.exp[o]/65;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/65;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 65 * rangoexp && inv.datosserial.nivel[o]== 2 && permiso == true)
        {
            inv.datosserial.exp[o] = 0;
            
            permiso = false;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];

            obj -= 65 * rangoexp;
            subiste.text = "has subido de nivel";
            
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }
        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 3 && permiso == true)
        {
            sub = false;
            
        }
        if(inv.datosserial.exp[o] < 120 * rangoexp && inv.datosserial.nivel[o]== 3 && permiso == true)
        {
            expv.fillAmount = inv.datosserial.exp[o]/120;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/120;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 120 * rangoexp && inv.datosserial.nivel[o]== 3 && permiso == true)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            obj -= 120 * rangoexp;
            subiste.text = "has subido de nivel";
            
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }
        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 4)
        {
            sub = false;
            
        }
        if(inv.datosserial.exp[o] < 200 * rangoexp && inv.datosserial.nivel[o]== 4  && permiso == true)
        {
            expv.fillAmount = inv.datosserial.exp[o]/200;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/200;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 200 * rangoexp && inv.datosserial.nivel[o]== 4 && permiso == true)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            obj -= 200 * rangoexp;
            subiste.text = "has subido de nivel";
            
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }
        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 5)
        {
            sub = false;
            
        }
        if(inv.datosserial.exp[o] < 250 * rangoexp && inv.datosserial.nivel[o]== 5 && permiso == true)
        {
            expv.fillAmount = inv.datosserial.exp[o]/250;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/250;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 250 * rangoexp && inv.datosserial.nivel[o]== 5 && permiso == true)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            obj -= 250 * rangoexp;
            modelos();
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }
        











        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 6 && permiso == true)
        {
            sub = false;
            
        }
        if(inv.datosserial.exp[o] < 340 * rangoexp && inv.datosserial.nivel[o]== 6 )
        {
            expv.fillAmount = inv.datosserial.exp[o]/340;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/340;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 340 * rangoexp && inv.datosserial.nivel[o]== 6 && permiso == true)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            obj -= 340 * rangoexp;
            subiste.text = "has subido de nivel";
            

            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }
        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 7)
        {
            sub = false;
            
        }
        if(inv.datosserial.exp[o] < 400 && inv.datosserial.nivel[o]== 7 && permiso == true)
        {
            expv.fillAmount = inv.datosserial.exp[o]/400;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/400;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 400 * rangoexp && inv.datosserial.nivel[o]== 7 && permiso == true)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            obj -= 400 * rangoexp;
            subiste.text = "has subido de nivel";
            
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }
        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 8)
        {
            sub = false;
            
        }
        if(inv.datosserial.exp[o] <520 * rangoexp && inv.datosserial.nivel[o]== 8 && permiso == true)
        {
            expv.fillAmount = inv.datosserial.exp[o]/520;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/520;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 520 * rangoexp && inv.datosserial.nivel[o]== 8 && permiso == true)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            obj -= 520 * rangoexp;
            subiste.text = "has subido de nivel";
            
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }
        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 9)
        {
            sub = false;
            
        }
        if(inv.datosserial.exp[o] < 600 * rangoexp && inv.datosserial.nivel[o]== 9 && permiso == true)
        {
            expv.fillAmount = inv.datosserial.exp[o]/600;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/600;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 600 * rangoexp && inv.datosserial.nivel[o]== 9 && permiso == true)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            obj -= 600 * rangoexp;
            subiste.text = "has subido de nivel";
            
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }
        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 10)
        {
            sub = false;
            
        }
        if(inv.datosserial.exp[o] < 780 * rangoexp && inv.datosserial.nivel[o]== 10 && permiso == true)
        {
            expv.fillAmount = inv.datosserial.exp[o]/780;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/780;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 780 * rangoexp && inv.datosserial.nivel[o]== 10 && permiso == true)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            obj -= 780 * rangoexp;
            modelos();
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }














        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 11)
        {
            sub = false;
            
        }
        if(inv.datosserial.exp[o] < 900 * rangoexp && inv.datosserial.nivel[o]== 11&& permiso == true)
        {
            expv.fillAmount = inv.datosserial.exp[o]/900;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/900;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 900 * rangoexp && inv.datosserial.nivel[o]== 11 && permiso == true)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            obj -= 900 * rangoexp;
            subiste.text = "has subido de nivel";
            
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }
        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 12)
        {
            sub = false;
            
        }
        if(inv.datosserial.exp[o] < 1000 * rangoexp && inv.datosserial.nivel[o]== 12 && permiso == true)
        {
            expv.fillAmount = inv.datosserial.exp[o]/1000;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/1000;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 1000 * rangoexp && inv.datosserial.nivel[o]== 12 && permiso == true)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            obj -= 1000 * rangoexp;
            subiste.text = "has subido de nivel";
            
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }
        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 13)
        {
            sub = false;
            
        }
        if(inv.datosserial.exp[o] < 1260 * rangoexp && inv.datosserial.nivel[o]== 13 && permiso == true)
        {
            expv.fillAmount = inv.datosserial.exp[o]/1260;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/1260;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 1260 * rangoexp && inv.datosserial.nivel[o]== 13 && permiso == true)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            obj -= 1260 * rangoexp;
            subiste.text = "has subido de nivel";
            
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }
        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 14)
        {
            sub = false;
            
        }
        if(inv.datosserial.exp[o] < 1440 * rangoexp && inv.datosserial.nivel[o]== 14 && permiso == true)
        {
            expv.fillAmount = inv.datosserial.exp[o]/1440;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/1440;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 1440 * rangoexp && inv.datosserial.nivel[o]== 14 && permiso == true)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            obj -= 1440 * rangoexp;
            subiste.text = "has subido de nivel";
            
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o] +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o] +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }
        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 15)
        {
            sub = false;
            
        }
        if(inv.datosserial.exp[o] < 1800 * rangoexp && inv.datosserial.nivel[o]== 15 && permiso == true)
        {
            expv.fillAmount = inv.datosserial.exp[o]/1800;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.datosserial.exp[o] < obj)
            {inv.datosserial.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.datosserial.exp[o]/1800;}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] >= 1800 * rangoexp && inv.datosserial.nivel[o]== 15 && permiso == true)
        {
            
            permiso = false;
            inv.datosserial.exp[o] = 0;
            inv.datosserial.nivel[o]++;
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            obj -= 1800 * rangoexp;
            subiste.text = "has subido de nivel";
            
            inv.datosserial.hp[o] +=50*rangoexp;
            inv.datosserial.mana[o] +=5*rangoexp;
            inv.datosserial.manarec[o] +=0.05f*rangoexp;
            inv.datosserial.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.datosserial.hp[o].ToString("F2") +" + 20";
            mat.text = "sta "+inv.datosserial.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.datosserial.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.datosserial.fuerza[o].ToString("F2") +" + 0,10";
            
            
        }
        if(inv.datosserial.exp[o] >= obj && inv.datosserial.nivel[o]== 16)
        {
            sub = false;
            
        }
        if(inv.datosserial.nivel[o]== 16 && permiso == true)
        {
            expv.fillAmount = 1/1;
            if(p1 == false)
            {if(inv.datosserial.dinero < dobj)
            {inv.datosserial.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.datosserial.dinero.ToString("F2");}
            hptt.text = "vit : "+inv.datosserial.hp[o];
            manat.text = "sta : "+inv.datosserial.mana[o];
            manarect.text = "rec : "+inv.datosserial.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.datosserial.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.datosserial.elemento[o];
            bichoti.text = "raza : "+inv.datosserial.bichosmios[o];
            nivelt.text = "nivel : "+inv.datosserial.nivel[o];
            subiste.text = "";
        }
        if(inv.datosserial.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.datosserial.exp[o] < obj )
        {
            sub = true;
            
            cont.gameObject.SetActive(false);
            
        }
        if(inv.datosserial.nivel[o]== 16 && p1 == true)
        {
            dinsound.Stop();
            cont.gameObject.SetActive(true);
        }
        nivelt.text = "nivel "+ inv.datosserial.nivel[o];
        if(hpp == true)
        {
            
            o = (int)inv.datosserial.varsel1;
            inv.datosserial.hp[o] +=20 * rangoexp;
            hp.gameObject.SetActive(false);
            ma.gameObject.SetActive(false);
            rec.gameObject.SetActive(false);
            fue.gameObject.SetActive(false);
            sub = false;
            permiso = true;
        }
        if(map == true)
        {
        
            o = (int)inv.datosserial.varsel1;
            inv.datosserial.mana[o] +=5 * rangoexp;
            hp.gameObject.SetActive(false);
            ma.gameObject.SetActive(false);
            rec.gameObject.SetActive(false);
            fue.gameObject.SetActive(false);
            sub = false;
            permiso = true;
        }
        if(recp == true)
        {
   
            o = (int)inv.datosserial.varsel1;
            inv.datosserial.manarec[o] +=0.05f * rangoexp;
            hp.gameObject.SetActive(false);
            ma.gameObject.SetActive(false);
            rec.gameObject.SetActive(false);
            fue.gameObject.SetActive(false);
            sub = false;
            permiso = true;
        }
        if(fuep == true)
        {
    
            o = (int)inv.datosserial.varsel1;
            inv.datosserial.fuerza[o] +=0.10f * rangoexp;
            hp.gameObject.SetActive(false);
            ma.gameObject.SetActive(false);
            rec.gameObject.SetActive(false);
            fue.gameObject.SetActive(false);
            sub = false;
            permiso = true;
        }
        hpp = false;
        map = false;
        recp = false;
        fuep = false;
        if(sub == false)
        {
            dinsound.Stop();
            cont.gameObject.SetActive(true);
        }
        
    }
    public void modelos()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        
        if(inv.datosserial.bichosmios[o] == "madcat")
        {
            bichom.SetActive(false);
            bichom = madcat;
        }
    
        if(inv.datosserial.bichosmios[o] == "shitfloor")
        {
            bichom.SetActive(false);
            bichom = shitfloor;
            
        }
        
        if(inv.datosserial.bichosmios[o] == "topo topo")
        {
            bichom.SetActive(false);
            bichom = topo;
        }
        
        if(inv.datosserial.bichosmios[o] == "skybird")
        {
            bichom.SetActive(false);
            bichom = skybird;
        }

        if(inv.datosserial.bichosmios[o] == "aghostin")
        {
            bichom.SetActive(false);
            bichom = ghost;
        }
        if(inv.datosserial.bichosmios[o] == "algosaurio")
        {
            bichom.SetActive(false);
            bichom = algosaurio;
        }
        if(inv.datosserial.bichosmios[o] == "bigfat")
        {
            bichom.SetActive(false);
            bichom = bigfat;
        }
        if(inv.datosserial.bichosmios[o] == "cazafantasmas")
        {
            bichom.SetActive(false);
            bichom = cazafantasmas;
        }
        //3
        if(inv.datosserial.bichosmios[o] == "darkknight")
        {
            bichom.SetActive(false);
            bichom = darkknight;
        }
        if(inv.datosserial.bichosmios[o] == "antidog")
        {
            bichom.SetActive(false);
            bichom = skybird;
        }
        if(inv.datosserial.bichosmios[o] == "cyberpinguino")
        {
            bichom.SetActive(false);
            bichom = pinguino;
        }
        if(inv.datosserial.bichosmios[o] == "craneovil")
        {
            bichom.SetActive(false);
            bichom = craneovil;
        }
        //4
        if(inv.datosserial.bichosmios[o] == "dogtable")
        {
            bichom.SetActive(false);
            bichom = dogtable;
        }
        if(inv.datosserial.bichosmios[o] == "beestosa")
        {
            bichom.SetActive(false);
            bichom = bee;
        }
        if(inv.datosserial.bichosmios[o] == "elephant")
        {
            bichom.SetActive(false);
            bichom = elephant;
        }
        if(inv.datosserial.bichosmios[o] == "flyera")
        {
            bichom.SetActive(false);
            bichom = flyera;
        }
        //5
        if(inv.datosserial.bichosmios[o] == "friend")
        {
            bichom.SetActive(false);
            bichom = friend;
        }
        if(inv.datosserial.bichosmios[o] == "gunman")
        {
            bichom.SetActive(false);
            bichom = gunman;
        }
        if(inv.datosserial.bichosmios[o] == "flanerio")
        {
            bichom.SetActive(false);
            bichom = flanerio;
        }
        if(inv.datosserial.bichosmios[o] == "fenix")
        {
            bichom.SetActive(false);
            bichom = fenix;
        }

        //1
        if(inv.datosserial.bichosmios[o] == "kingdragon")
        {
            bichom.SetActive(false);
            bichom = kingdragon;
        }
        if(inv.datosserial.bichosmios[o] == "heavydevil")
        {
            bichom.SetActive(false);
            bichom = heavydevil;
        }
        if(inv.datosserial.bichosmios[o] == "kraken")
        {
            bichom.SetActive(false);
            bichom = kraken;
        }
        if(inv.datosserial.bichosmios[o] == "lizardo")
        {
            bichom.SetActive(false);
            bichom = lizardo;
        }
         //2
        if(inv.datosserial.bichosmios[o] == "livedish")
        {
            bichom.SetActive(false);
            bichom = livedish;
        }
        if(inv.datosserial.bichosmios[o] == "pesadilla")
        {
            bichom.SetActive(false);
            bichom = pesadilla;
        }
        if(inv.datosserial.bichosmios[o] == "mirror")
        {
            bichom.SetActive(false);
            bichom = mirror;
        }
        if(inv.datosserial.bichosmios[o] == "rabmon")
        {
            bichom.SetActive(false);
            bichom = rabmon;
        }
        //3
        if(inv.datosserial.bichosmios[o] == "ant")
        {
            bichom.SetActive(false);
            bichom = ant;
        }
        if(inv.datosserial.bichosmios[o] == "kingslug")
        {
            bichom.SetActive(false);
            bichom = kingdragon;
        }
        if(inv.datosserial.bichosmios[o] == "rosedragon")
        {
            bichom.SetActive(false);
            bichom = rosedragon;
        }
        if(inv.datosserial.bichosmios[o] == "sharkman")
        {
            bichom.SetActive(false);
            bichom = sharkman;
        }
        //4
        if(inv.datosserial.bichosmios[o] == "pollovion")
        {
            bichom.SetActive(false);
            bichom = pollovion;
        }
        if(inv.datosserial.bichosmios[o] == "trepillo")
        {
            bichom.SetActive(false);
            bichom = trepillo;
        }
        if(inv.datosserial.bichosmios[o] == "roboerto")
        {
            bichom.SetActive(false);
            bichom = roboerto;
        }
        if(inv.datosserial.bichosmios[o] == "tufo")
        {
            bichom.SetActive(false);
            bichom = tufo;
        }
        //5
        if(inv.datosserial.bichosmios[o] == "trashrat")
        {
            bichom.SetActive(false);
            bichom = trashrat;
        }
        if(inv.datosserial.bichosmios[o] == "spider")
        {
            bichom.SetActive(false);
            bichom = spider;
        }
        if(inv.datosserial.bichosmios[o] == "vivodado")
        {
            bichom.SetActive(false);
            bichom = vivodado;
        }
        if(inv.datosserial.bichosmios[o] == "dragonron")
        {
            bichom.SetActive(false);
            bichom = dragonron;
        }
        bichom.SetActive(true);
    }
}
