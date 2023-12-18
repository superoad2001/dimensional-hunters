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
        nivelg = (int)PlayerPrefs.GetFloat("nivelg", 1);
        o = (int)PlayerPrefs.GetFloat("selec", 0);
        rango2 = (int)PlayerPrefs.GetFloat("rangoene", 1);

        hptt.text = "vit : "+inv.hp[o];
        manat.text = "sta : "+inv.mana[o];
        manarect.text = "rec : "+inv.manarec[o].ToString("F2");
        danot.text = "fue : "+inv.fuerza[o].ToString("F2");
        elementot.text = "categoria : "+inv.elemento[o];
        bichoti.text = "raza : "+inv.bichosmios[o];
        nivelt.text = "nivel : "+inv.nivel[o];
        rango = inv.rango[o];


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
        if(rango == 48)
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
        if(rango == 48)
        {rangoexp3 = 18f;}
        if(rango == 19)
        {rangoexp3 = 19f;}
        if(rango == 20)
        {rangoexp3 = 20f;}

        if(rango == 21)
        {rangoexp3 = 21;}

        
        if(nivelg == 1)
        {obj = (int)inv.exp[o] + Random.Range(20,27) * (int)rangoexp2;
        dobj = (int)inv.dinero + Random.Range(10,20) * (int)rangoexp2;}
        if(nivelg == 2)
        {obj = (int)inv.exp[o] + Random.Range(40,65) * (int)rangoexp2;
        dobj = (int)inv.dinero +Random.Range(25,40) * (int)rangoexp2;}
        if(nivelg == 3)
        {obj = (int)inv.exp[o] + Random.Range(80,120) * (int)rangoexp2;
        dobj = (int)inv.dinero +Random.Range(50,75) * (int)rangoexp2;}
        if(nivelg == 4)
        {obj = (int)inv.exp[o] + Random.Range(150,200) * (int)rangoexp2;
        dobj = (int)inv.dinero +Random.Range(100,130) * (int)rangoexp2;}
        if(nivelg == 5)
        {obj = (int)inv.exp[o] + Random.Range(200,230) * (int)rangoexp2;
        dobj = (int)inv.dinero + Random.Range(150,190) * (int)rangoexp2;}
        if(nivelg == 6)
        {obj = (int)inv.exp[o] + Random.Range(230,250) * (int)rangoexp2;
        dobj = (int)inv.dinero + Random.Range(200,220) * (int)rangoexp2;}
        if(nivelg == 7)
        {obj = (int)inv.exp[o] + Random.Range(250,270) * (int)rangoexp2;
        dobj = (int)inv.dinero + Random.Range(230,250) * (int)rangoexp2;}
        if(nivelg == 8)
        {obj = (int)inv.exp[o] + Random.Range(270,290) * (int)rangoexp2;
        dobj = (int)inv.dinero + Random.Range(270,300) * (int)rangoexp2;}
        if(nivelg == 9)
        {obj = (int)inv.exp[o] + Random.Range(290,320) * (int)rangoexp2;
        dobj = (int)inv.dinero + Random.Range(300,350) * (int)rangoexp2;}
        if(nivelg == 10)
        {obj = (int)inv.exp[o] + Random.Range(330,390) * (int)rangoexp2;
        dobj = (int)inv.dinero + Random.Range(360,390) * (int)rangoexp2;}
        if(nivelg == 11)
        {obj = (int)inv.exp[o] + Random.Range(400,450) * (int)rangoexp2;
        dobj = (int)inv.dinero + Random.Range(400,490) * (int)rangoexp2;}
        if(nivelg == 12)
        {obj = (int)inv.exp[o] + Random.Range(470,530) * (int)rangoexp2;
        dobj = (int)inv.dinero + Random.Range(500,570) * (int)rangoexp2;}
        if(nivelg == 13)
        {obj = (int)inv.exp[o] + Random.Range(600,650) * (int)rangoexp2;
        dobj = (int)inv.dinero + Random.Range(580,680) * (int)rangoexp2;}
        if(nivelg == 14)
        {obj = (int)inv.exp[o] + Random.Range(680,740) * (int)rangoexp2;
        dobj = (int)inv.dinero + Random.Range(700,800) * (int)rangoexp2;}
        if(nivelg == 15)
        {dobj = (int)inv.dinero + Random.Range(800,999) * (int)rangoexp2;}

        

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

    public GameObject madcat2;
    public GameObject shitfloor2;
    public GameObject topo2;
    public GameObject skybird2;

    public GameObject madcat3;
    public GameObject shitfloor3;
    public GameObject topo3;
    public GameObject skybird3;

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
        SceneManager.LoadScene("seleccion");
    }
    void Update()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        
        if (inv.nivel[o] == 1 )
        {
            expv.fillAmount = inv.exp[o]/27;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {
                
                if(inv.exp[o] < obj)
                {
                    if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}
                    dinsound.loop = true;
                    inv.exp[o] += obj/4 * Time.deltaTime;
                    
                }
                inv.exp[o] = inv.exp[o];
                expv.fillAmount = inv.exp[o]/27;
            }
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
            
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }

        if(inv.exp[o] >= obj && inv.nivel[o] == 1)
        {
            sub = false;
       
            
        }
        if(inv.exp[o] >= 27 * rangoexp3 && inv.nivel[o] == 1)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];

            obj -= 27 * rangoexp3;
            subiste.text = "has subido de nivel";
            
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o] +" + 5";
            mat.text = "sta "+inv.mana[o] +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
            
        }
        if(inv.exp[o] >= obj && inv.nivel[o]== 2)
        {
            sub = false;
            
            
        }
        if(inv.exp[o] < 65 * rangoexp3 && inv.nivel[o]== 2 && permiso == true)
        {
            expv.fillAmount = inv.exp[o]/65;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/65;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 65 * rangoexp3 && inv.nivel[o]== 2 && permiso == true)
        {
            inv.exp[o] = 0;
            
            permiso = false;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];

            obj -= 65 * rangoexp3;
            subiste.text = "has subido de nivel";
            
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o] +" + 5";
            mat.text = "sta "+inv.mana[o] +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] >= obj && inv.nivel[o]== 3 && permiso == true)
        {
            sub = false;
            
        }
        if(inv.exp[o] < 120 * rangoexp3 && inv.nivel[o]== 3 && permiso == true)
        {
            expv.fillAmount = inv.exp[o]/120;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/120;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 120 * rangoexp3 && inv.nivel[o]== 3 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 120 * rangoexp3;
            subiste.text = "has subido de nivel";
            
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o] +" + 5";
            mat.text = "sta "+inv.mana[o] +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] >= obj && inv.nivel[o]== 4)
        {
            sub = false;
            
        }
        if(inv.exp[o] < 200 * rangoexp3 && inv.nivel[o]== 4  && permiso == true)
        {
            expv.fillAmount = inv.exp[o]/200;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/200;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 200 * rangoexp3 && inv.nivel[o]== 4 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 200 * rangoexp3;
            subiste.text = "has subido de nivel";
            
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o] +" + 5";
            mat.text = "sta "+inv.mana[o] +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] >= obj && inv.nivel[o]== 5)
        {
            sub = false;
            
        }
        if(inv.exp[o] < 250 * rangoexp3 && inv.nivel[o]== 5 && permiso == true)
        {
            expv.fillAmount = inv.exp[o]/250;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/250;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 250 * rangoexp3 && inv.nivel[o]== 5 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 250 * rangoexp3;
            modelos();
            bichoti.text = "raza : "+inv.bichosmios[o];
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        











        if(inv.exp[o] >= obj && inv.nivel[o]== 6 && permiso == true)
        {
            sub = false;
            
        }
        if(inv.exp[o] < 340 * rangoexp3 && inv.nivel[o]== 6 )
        {
            expv.fillAmount = inv.exp[o]/340;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/340;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 340 * rangoexp3 && inv.nivel[o]== 6 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 340 * rangoexp3;
            subiste.text = "has subido de nivel";
            

            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] >= obj && inv.nivel[o]== 7)
        {
            sub = false;
            
        }
        if(inv.exp[o] < 400 && inv.nivel[o]== 7 && permiso == true)
        {
            expv.fillAmount = inv.exp[o]/400;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/400;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 400 * rangoexp3 && inv.nivel[o]== 7 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 400 * rangoexp3;
            subiste.text = "has subido de nivel";
            
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] >= obj && inv.nivel[o]== 8)
        {
            sub = false;
            
        }
        if(inv.exp[o] <520 * rangoexp3 && inv.nivel[o]== 8 && permiso == true)
        {
            expv.fillAmount = inv.exp[o]/520;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/520;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 520 * rangoexp3 && inv.nivel[o]== 8 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 520 * rangoexp3;
            subiste.text = "has subido de nivel";
            
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] >= obj && inv.nivel[o]== 9)
        {
            sub = false;
            
        }
        if(inv.exp[o] < 600 * rangoexp3 && inv.nivel[o]== 9 && permiso == true)
        {
            expv.fillAmount = inv.exp[o]/600;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/600;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 600 * rangoexp3 && inv.nivel[o]== 9 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 600 * rangoexp3;
            subiste.text = "has subido de nivel";
            
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] >= obj && inv.nivel[o]== 10)
        {
            sub = false;
            
        }
        if(inv.exp[o] < 780 * rangoexp3 && inv.nivel[o]== 10 && permiso == true)
        {
            expv.fillAmount = inv.exp[o]/780;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/780;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 780 * rangoexp3 && inv.nivel[o]== 10 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 780 * rangoexp3;
            modelos();
            bichoti.text = "raza : "+inv.bichosmios[o];
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }















        if(inv.exp[o] < 900 * rangoexp3 && inv.nivel[o]== 11&& permiso == true)
        {
            expv.fillAmount = inv.exp[o]/900;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/900;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 900 * rangoexp3 && inv.nivel[o]== 11 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 900 * rangoexp3;
            subiste.text = "has subido de nivel";
            
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] < 1000 * rangoexp3 && inv.nivel[o]== 12 && permiso == true)
        {
            expv.fillAmount = inv.exp[o]/1000;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/1000;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 1000 * rangoexp3 && inv.nivel[o]== 12 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 1000 * rangoexp3;
            subiste.text = "has subido de nivel";
            
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] < 1260 * rangoexp3 && inv.nivel[o]== 13 && permiso == true)
        {
            expv.fillAmount = inv.exp[o]/1260;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/1260;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 1260 * rangoexp3 && inv.nivel[o]== 13 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 1260 * rangoexp3;
            subiste.text = "has subido de nivel";
            
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] < 1440 * rangoexp3 && inv.nivel[o]== 14 && permiso == true)
        {
            expv.fillAmount = inv.exp[o]/1440;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/1440;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 1440 * rangoexp3 && inv.nivel[o]== 14 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 1440 * rangoexp3;
            subiste.text = "has subido de nivel";
            
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] < 1800 * rangoexp3 && inv.nivel[o]== 15 && permiso == true)
        {
            expv.fillAmount = inv.exp[o]/1800;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            if(p1 == true)
            {if(inv.exp[o] < obj)
            {inv.exp[o] += obj/4 * Time.deltaTime; if(vez1 == false)
                    {dinsound.Play();
                    vez1 = true;}}
            expv.fillAmount = inv.exp[o]/1800;}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 1800 * rangoexp3 && inv.nivel[o]== 15 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 1800 * rangoexp3;
            subiste.text = "has subido de nivel";
            
            inv.hp[o] +=50*rangoexp;
            inv.mana[o] +=5*rangoexp;
            inv.manarec[o] +=0.05f*rangoexp;
            inv.fuerza[o] +=0.25f*rangoexp;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.nivel[o]== 16 && permiso == true)
        {
            expv.fillAmount = 1/1;
            if(p1 == false)
            {if(inv.dinero < dobj)
            {inv.dinero += dobj/2 * Time.deltaTime;}
            monedat.text = "dolares : "+inv.dinero.ToString("F2");}
            hptt.text = "vit : "+inv.hp[o];
            manat.text = "sta : "+inv.mana[o];
            manarect.text = "rec : "+inv.manarec[o].ToString("F2");
            danot.text = "fue : "+inv.fuerza[o].ToString("F2");
            elementot.text = "categoria : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] < obj )
        {
            sub = true;
            
            cont.gameObject.SetActive(false);
            
        }
        if(inv.nivel[o]== 16 && p1 == true)
        {
            dinsound.Stop();
            cont.gameObject.SetActive(true);
        }
        nivelt.text = "nivel "+ inv.nivel[o];
        if(hpp == true)
        {
            
            o = (int)PlayerPrefs.GetFloat("selec", 0);
            inv.hp[o] +=5 * rangoexp3;
            hp.gameObject.SetActive(false);
            ma.gameObject.SetActive(false);
            rec.gameObject.SetActive(false);
            fue.gameObject.SetActive(false);
            sub = false;
            permiso = true;
        }
        if(map == true)
        {
        
            o = (int)PlayerPrefs.GetFloat("selec", 0);
            inv.mana[o] +=5 * rangoexp3;
            hp.gameObject.SetActive(false);
            ma.gameObject.SetActive(false);
            rec.gameObject.SetActive(false);
            fue.gameObject.SetActive(false);
            sub = false;
            permiso = true;
        }
        if(recp == true)
        {
   
            o = (int)PlayerPrefs.GetFloat("selec", 0);
            inv.manarec[o] +=0.05f * rangoexp3;
            hp.gameObject.SetActive(false);
            ma.gameObject.SetActive(false);
            rec.gameObject.SetActive(false);
            fue.gameObject.SetActive(false);
            sub = false;
            permiso = true;
        }
        if(fuep == true)
        {
    
            o = (int)PlayerPrefs.GetFloat("selec", 0);
            inv.fuerza[o] +=0.05f * rangoexp3;
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
        
        if(inv.bichosmios[o] == "madcat")
        {
            bichom.SetActive(false);
            bichom = madcat;
        }
    
        if(inv.bichosmios[o] == "shitfloor")
        {
            bichom.SetActive(false);
            bichom = shitfloor;
            
        }
        
        if(inv.bichosmios[o] == "topo topo")
        {
            bichom.SetActive(false);
            bichom = topo;
        }
        
        if(inv.bichosmios[o] == "skybird")
        {
            bichom.SetActive(false);
            bichom = skybird;
        }






        if(inv.bichosmios[o] == "happycat")
        {
            bichom.SetActive(false);
            bichom = madcat2;
        }
    
        if(inv.bichosmios[o] == "shitplus")
        {
            bichom.SetActive(false);
            bichom = shitfloor2;
            
        }
        
        if(inv.bichosmios[o] == "toto topo")
        {
            bichom.SetActive(false);
            bichom = topo2;
        }
        
        if(inv.bichosmios[o] == "sunbird")
        {
            bichom.SetActive(false);
            bichom = skybird2;
        }



        if(inv.bichosmios[o] == "crazycat")
        {
            bichom.SetActive(false);
            bichom = madcat3;
        }
    
        if(inv.bichosmios[o] == "shitplusplus")
        {
            bichom.SetActive(false);
            bichom = shitfloor3;
            
        }
        
        if(inv.bichosmios[o] == "poro topo")
        {
            bichom.SetActive(false);
            bichom = topo3;
        }
        
        if(inv.bichosmios[o] == "moonbird")
        {
            bichom.SetActive(false);
            bichom = skybird3;
        }
        bichom.SetActive(true);
    }
}
