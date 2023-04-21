using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class findecombat : MonoBehaviour
{
    public int obj;
    public int dobj;
    public bool p1;
    public int jefe1;
    // Start is called before the first frame update
    void Start()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        jefe1 = PlayerPrefs.GetInt("jefe1",0);
        if(jefe1 == 1)
        {
            PlayerPrefs.SetInt("tutorial3",1);
        }
        nivelg = (int)PlayerPrefs.GetFloat("nivelss", 0);
        if(nivelg == 1)
        {obj = (int)inv.exp[o] + Random.Range(20,27);
        dobj = (int)inv.dinero + Random.Range(10,20);}
        if(nivelg == 2)
        {obj = (int)inv.exp[o] + Random.Range(40,65);
        dobj = (int)inv.dinero +Random.Range(25,40);}
        if(nivelg == 3)
        {obj = (int)inv.exp[o] + Random.Range(80,120);
        dobj = (int)inv.dinero +Random.Range(50,75);}
        if(nivelg == 4)
        {obj = (int)inv.exp[o] + Random.Range(150,200);
        dobj = (int)inv.dinero +Random.Range(100,130);}
        if(nivelg == 5)
        {obj = (int)inv.exp[o] + Random.Range(200,230);
        dobj = (int)inv.dinero + Random.Range(150,190);}
        if(nivelg == 6)
        {obj = (int)inv.exp[o] + Random.Range(230,250);
        dobj = (int)inv.dinero + Random.Range(200,220);}
        if(nivelg == 7)
        {obj = (int)inv.exp[o] + Random.Range(250,270);
        dobj = (int)inv.dinero + Random.Range(230,250);}
        if(nivelg == 8)
        {obj = (int)inv.exp[o] + Random.Range(270,290);
        dobj = (int)inv.dinero + Random.Range(270,300);}
        if(nivelg == 9)
        {obj = (int)inv.exp[o] + Random.Range(290,320);
        dobj = (int)inv.dinero + Random.Range(300,350);}
        if(nivelg == 10)
        {obj = (int)inv.exp[o] + Random.Range(330,390);
        dobj = (int)inv.dinero + Random.Range(360,390);}
        if(nivelg == 11)
        {obj = (int)inv.exp[o] + Random.Range(400,450);
        dobj = (int)inv.dinero + Random.Range(400,490);}
        if(nivelg == 12)
        {obj = (int)inv.exp[o] + Random.Range(470,530);
        dobj = (int)inv.dinero + Random.Range(500,570);}
        if(nivelg == 13)
        {obj = (int)inv.exp[o] + Random.Range(600,650);
        dobj = (int)inv.dinero + Random.Range(580,680);}
        if(nivelg == 14)
        {obj = (int)inv.exp[o] + Random.Range(680,740);
        dobj = (int)inv.dinero + Random.Range(700,800);}
        if(nivelg == 15)
        {dobj = (int)inv.dinero + Random.Range(800,999);}

        o = (int)PlayerPrefs.GetFloat("selec", 0);
        nivelg = (int)PlayerPrefs.GetFloat("nivelss", 0);
        


        hptt.text = "vit : "+inv.hp[o];
        manat.text = "sta : "+inv.mana[o];
        manarect.text = "rec : "+inv.manarec[o].ToString("F2");
        danot.text = "fue : "+inv.fuerza[o].ToString("F2");
        elementot.text = "elemento : "+inv.elemento[o];
        bichoti.text = "raza : "+inv.bichosmios[o];
        nivelt.text = "nivel : "+inv.nivel[o];

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
            elementot.text = "elemento : "+inv.elemento[o];
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
        if(inv.exp[o] >= 27 && inv.nivel[o] == 1)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];

            obj -= 27;
            subiste.text = "has subido de nivel";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=5;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=5;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.05f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.05f;
            }
            inv.hp[o] +=5;
            inv.mana[o] +=5;
            inv.manarec[o] +=0.05f;
            inv.fuerza[o] +=0.05f;
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
        if(inv.exp[o] < 65 && inv.nivel[o]== 2 && permiso == true)
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 65 && inv.nivel[o]== 2 && permiso == true)
        {
            inv.exp[o] = 0;
            
            permiso = false;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];

            obj -= 65;
            subiste.text = "has subido de nivel";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=5;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=5;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.05f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.05f;
            }
            inv.hp[o] +=5;
            inv.mana[o] +=5;
            inv.manarec[o] +=0.05f;
            inv.fuerza[o] +=0.05f;
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
        if(inv.exp[o] < 120 && inv.nivel[o]== 3 && permiso == true)
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 120 && inv.nivel[o]== 3 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 120;
            subiste.text = "has subido de nivel";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=5;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=5;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.05f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.05f;
            }
            inv.hp[o] +=5;
            inv.mana[o] +=5;
            inv.manarec[o] +=0.05f;
            inv.fuerza[o] +=0.05f;
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
        if(inv.exp[o] < 200 && inv.nivel[o]== 4  && permiso == true)
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 200 && inv.nivel[o]== 4 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 200;
            subiste.text = "has subido de nivel";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=5;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=5;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.05f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.05f;
            }
            inv.hp[o] +=5;
            inv.mana[o] +=5;
            inv.manarec[o] +=0.05f;
            inv.fuerza[o] +=0.05f;
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
        if(inv.exp[o] < 250 && inv.nivel[o]== 5 && permiso == true)
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 250 && inv.nivel[o]== 5 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 250;
            subiste.text = "has evolucionado";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=10;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=10;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.1f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.1f;
            }
            evo2();
            modelos();
            bichoti.text = "raza : "+inv.bichosmios[o];
            inv.hp[o] +=20;
            inv.mana[o] +=20;
            inv.manarec[o] +=0.1f;
            inv.fuerza[o] +=0.1f;
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
        if(inv.exp[o] < 340 && inv.nivel[o]== 6 )
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 340 && inv.nivel[o]== 6 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 340;
            subiste.text = "has subido de nivel";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=5;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=5;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.05f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.05f;
            }

            inv.hp[o] +=5;
            inv.mana[o] +=5;
            inv.manarec[o] +=0.05f;
            inv.fuerza[o] +=0.05f;
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 400 && inv.nivel[o]== 7 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 400;
            subiste.text = "has subido de nivel";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=5;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=5;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.05f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.05f;
            }
            inv.hp[o] +=5;
            inv.mana[o] +=5;
            inv.manarec[o] +=0.05f;
            inv.fuerza[o] +=0.05f;
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
        if(inv.exp[o] <520 && inv.nivel[o]== 8 && permiso == true)
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 520 && inv.nivel[o]== 8 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 520;
            subiste.text = "has subido de nivel";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=5;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=5;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.05f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.05f;
            }
            inv.hp[o] +=5;
            inv.mana[o] +=5;
            inv.manarec[o] +=0.05f;
            inv.fuerza[o] +=0.05f;
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
        if(inv.exp[o] < 600 && inv.nivel[o]== 9 && permiso == true)
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 600 && inv.nivel[o]== 9 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 600;
            subiste.text = "has subido de nivel";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=5;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=5;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.05f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.05f;
            }
            inv.hp[o] +=5;
            inv.mana[o] +=5;
            inv.manarec[o] +=0.05f;
            inv.fuerza[o] +=0.05f;
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
        if(inv.exp[o] < 780 && inv.nivel[o]== 10 && permiso == true)
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 780 && inv.nivel[o]== 10 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 780;
            subiste.text = "has evolucionado";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=10;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=10;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.1f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.1f;
            }
            evo3();
            modelos();
            bichoti.text = "raza : "+inv.bichosmios[o];
            inv.hp[o] +=20;
            inv.mana[o] +=20;
            inv.manarec[o] +=0.1f;
            inv.fuerza[o] +=0.1f;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }















        if(inv.exp[o] < 900 && inv.nivel[o]== 11&& permiso == true)
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 900 && inv.nivel[o]== 11 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 900;
            subiste.text = "has subido de nivel";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=5;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=5;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.05f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.05f;
            }
            inv.hp[o] +=5;
            inv.mana[o] +=5;
            inv.manarec[o] +=0.05f;
            inv.fuerza[o] +=0.05f;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] < 1000 && inv.nivel[o]== 12 && permiso == true)
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 1000 && inv.nivel[o]== 12 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 1000;
            subiste.text = "has subido de nivel";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=5;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=5;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.05f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.05f;
            }
            inv.hp[o] +=5;
            inv.mana[o] +=5;
            inv.manarec[o] +=0.05f;
            inv.fuerza[o] +=0.05f;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] < 1260 && inv.nivel[o]== 13 && permiso == true)
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 1260 && inv.nivel[o]== 13 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 1260;
            subiste.text = "has subido de nivel";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=5;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=5;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.05f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.05f;
            }
            inv.hp[o] +=5;
            inv.mana[o] +=5;
            inv.manarec[o] +=0.05f;
            inv.fuerza[o] +=0.05f;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] < 1440 && inv.nivel[o]== 14 && permiso == true)
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 1440 && inv.nivel[o]== 14 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 1440;
            subiste.text = "has subido de nivel";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=5;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=5;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.05f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.05f;
            }
            inv.hp[o] +=5;
            inv.mana[o] +=5;
            inv.manarec[o] +=0.05f;
            inv.fuerza[o] +=0.05f;
            hp.gameObject.SetActive(true);
            ma.gameObject.SetActive(true);
            rec.gameObject.SetActive(true);
            fue.gameObject.SetActive(true);
            hpt.text = "vit "+inv.hp[o].ToString("F2") +" + 5";
            mat.text = "sta "+inv.mana[o].ToString("F2") +" + 5";
            rect.text = "rec "+inv.manarec[o].ToString("F2") +" + 0,05";
            fuet.text = "fue "+inv.fuerza[o].ToString("F2") +" + 0,05";
            
            
        }
        if(inv.exp[o] < 1800 && inv.nivel[o]== 15 && permiso == true)
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
            elementot.text = "elemento : "+inv.elemento[o];
            bichoti.text = "raza : "+inv.bichosmios[o];
            nivelt.text = "nivel : "+inv.nivel[o];
            subiste.text = "";
        }
        if(inv.dinero >= dobj)
        {
            p1 = true;
        }
        if(inv.exp[o] >= 1800 && inv.nivel[o]== 15 && permiso == true)
        {
            
            permiso = false;
            inv.exp[o] = 0;
            inv.nivel[o]++;
            nivelt.text = "nivel : "+inv.nivel[o];
            obj -= 1800;
            subiste.text = "has subido de nivel";
            if(inv.bichosmios[o] == "terreno")
            {
                inv.hp[o] +=5;
            }
            if(inv.bichosmios[o] == "viscoso")
            {
                inv.mana[o] +=5;
            }
            if(inv.bichosmios[o] == "fuerte")
            {
                inv.fuerza[o] +=0.05f;
            }
            if(inv.bichosmios[o] == "aereo")
            {
                inv.manarec[o] +=0.05f;
            }
            inv.hp[o] +=5;
            inv.mana[o] +=5;
            inv.manarec[o] +=0.05f;
            inv.fuerza[o] +=0.05f;
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
            elementot.text = "elemento : "+inv.elemento[o];
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
            inv.hp[o] +=5;
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
            inv.mana[o] +=5;
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
            inv.manarec[o] +=0.05f;
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
            inv.fuerza[o] +=0.05f;
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
    public void evo2()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(inv.bichosmios[o] == "madcat")
        {
            inv.bichosmios[o] = "happycat";
        }
        if(inv.bichosmios[o] == "shitfloor")
        {
            inv.bichosmios[o] = "shitplus";
        }
        if(inv.bichosmios[o] == "topo topo")
        {
            inv.bichosmios[o] = "toto topo";
        }
        if(inv.bichosmios[o] == "skybird")
        {
            inv.bichosmios[o] = "sunbird";
        }
  
    }
    public void evo3()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(inv.bichosmios[o] == "happycat")
        {
            inv.bichosmios[o] = "crazycat";
        }
        if(inv.bichosmios[o] == "shitplus")
        {
            inv.bichosmios[o] = "shitplusplus";
        }
        if(inv.bichosmios[o] == "toto topo")
        {
            inv.bichosmios[o] = "poro topo";
        }
        if(inv.bichosmios[o] == "sunbird")
        {
            inv.bichosmios[o] = "moonbird";
        }

    }
}
