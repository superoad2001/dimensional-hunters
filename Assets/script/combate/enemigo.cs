using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemigo : MonoBehaviour
{

    public bool turbo = false;
    public bool rapido = false;
    public bool fuerte = false;
    public bool rapfue = false;
    public bool def = false;
    public bool defusar;
    public bool botebool = false;

    public string name;
    public string bicho;
    public float hp;
    public float mana;
    public float manarec;
    public float fuerza;
    public float nivel;

    public Collider ev1c;
    public Collider ev2c;
    public Collider ev3c;

    public int limite = 3;

    public AudioSource rapsound;
    public AudioSource fuesound;
    public AudioSource rapfuesound;
    public AudioSource turbosound;

    public AudioSource rapsoundcat;
    public AudioSource fuesoundcat;
    public AudioSource rapfuesoundcat;
    public AudioSource turbosoundcat;

    
    public RuntimeAnimatorController madcatanim1;
    public RuntimeAnimatorController shitanim1;
    public RuntimeAnimatorController topoanim1;
    public RuntimeAnimatorController skybirdanim1;

    public Animator baseanim;
    public Animator baseanim2;
    public Animator baseanim3;


    public float temp;
    public float temp1;
    public float temp4;
    public float temp3;
    public float ventaja = 0;
    public float atb = 100;
    public float turbobar = 0;


    public Text atbbar;
    public Text mehp;
    public Text memana;
    public Text mename;

    public AudioSource bote;

    public Collider prot;
    public Collider prot2;
    public Collider prot3;

    public GameObject escudo;

    public int hpmax;
    public int manamax;


    public int dano;

    public AudioSource danos;

    public AudioSource dano0;
    public AudioSource dano1;
    public AudioSource dano2;

    public AudioSource dano1cat;
    public AudioSource dano2cat;

    public GameObject ev1;
    public GameObject ev2;
    public GameObject ev3;

    public GameObject madcat1;
    public GameObject shitfloor;
    public GameObject topo;
    public GameObject skybird;

    public GameObject madcat12;
    public GameObject shitfloor2;
    public GameObject topo2;
    public GameObject skybird2;

    public GameObject madcat13;
    public GameObject shitfloor3;
    public GameObject topo3;
    public GameObject skybird3;

    public AudioSource fueson;
    public AudioSource rapson;
    public AudioSource fulson;
    public AudioSource defson;
    public AudioSource turboson;

    




    public float floattoint;

    public float ataque;
    public bool activar;
    public bool permiso;

    public string inteligencia = "inteligencia1";

    public int decision = 0;
    public int decision2 = 0;
    public int decision3 = 0;
    // Start is called before the first frame update
    void Start()
    {

        decision3 = Random.Range(25,35);

        hp = PlayerPrefs.GetFloat("hpene", 100);
        mana = PlayerPrefs.GetFloat("manaene", 100);
        manarec = PlayerPrefs.GetFloat("manarecene", 1);
        fuerza = PlayerPrefs.GetFloat("fuerzaene", 1);
        name = (string)PlayerPrefs.GetString("nameene", "misigno");
        bicho = (string)PlayerPrefs.GetString("bichosene", "madcat");
        nivel = PlayerPrefs.GetFloat("nivelg", 1);
        
        

       

        hpmax = (int)hp;
        manamax = (int)mana;
         if(bicho == "madcat")
        {
            
            madcat1.SetActive(true);
            ev1.SetActive(true);
            madcat1.name = "madcat (1)";
            baseanim.runtimeAnimatorController = madcatanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "shitfloor")
        {
            shitfloor.SetActive(true);
            ev1.SetActive(true);
            shitfloor.name = "shitfloor";
            
            baseanim.runtimeAnimatorController = shitanim1;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "topo topo")
        {
            topo.SetActive(true);
            ev1.SetActive(true);
            topo.name = "topo";
            
            baseanim.runtimeAnimatorController = topoanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "skybird")
        {
            skybird.SetActive(true);
            ev1.SetActive(true);
            skybird.name = "skybird";
            
            baseanim.runtimeAnimatorController = skybirdanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }








        if(bicho == "happycat")
        {
            
            madcat12.SetActive(true);
            ev2.SetActive(true);
            madcat1.name = "madcat (1)";
            
            baseanim.runtimeAnimatorController = madcatanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "shitplus")
        {
            shitfloor2.SetActive(true);
            ev2.SetActive(true);
            shitfloor.name = "shitfloor";
            
            baseanim.runtimeAnimatorController = shitanim1;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "toto topo")
        {
            topo2.SetActive(true);
            ev2.SetActive(true);
            topo.name = "topo";
            
            baseanim.runtimeAnimatorController = topoanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "sunbird")
        {
            skybird2.SetActive(true);
            ev2.SetActive(true);
            skybird.name = "skybird";
            
            baseanim.runtimeAnimatorController = skybirdanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }




        if(bicho == "crazycat")
        {
            
            madcat13.SetActive(true);
            ev3.SetActive(true);
            madcat1.name = "madcat (1)";
            
            baseanim.runtimeAnimatorController = madcatanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
        if(bicho == "shitplusplus")
        {
            shitfloor3.SetActive(true);
            ev3.SetActive(true);
            shitfloor.name = "shitfloor";
            
            baseanim.runtimeAnimatorController = shitanim1;

            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "poro topo")
        {
            topo3.SetActive(true);
            ev3.SetActive(true);
            topo.name = "topo";
            
            baseanim.runtimeAnimatorController = topoanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
        if(bicho == "moonbird")
        {
            skybird3.SetActive(true);
            ev3.SetActive(true);
            skybird.name = "skybird";
            
            baseanim.runtimeAnimatorController = skybirdanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
        }
    }

    // Update is called once per frame
    void Update()
    {
        managerdecombate manager = UnityEngine.Object.FindObjectOfType<managerdecombate>();
        if (manager.comienzo == true)
        {
            
            if (dano == 0)
            {
                danos = dano0;
            }
            if (dano == 1)
            {
                danos = dano1;
            }
            if (dano == 2)
            {
                danos = dano2;
            }
            if (ventaja < 15)
            {ventaja += 1 * Time.deltaTime;}
            hero heroe = UnityEngine.Object.FindObjectOfType<hero>();
            if (inteligencia == "inteligencia1" && hp > 0 && ventaja > 2)
            {




                if(mana < 1)
                {   
                    if (temp > 0)
                    {decision = 0;}
                    if (decision == 0)
                    {
                        temp = -10;
                        decision = 10;
                    }
                    if(decision == 10){}

                }
                if(hp > 0 && hp <= 25 && mana > 0 && mana <= 30)
                {   
                    if (temp > 1)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){}
                    if(decision == 2){}
                    if(decision == 3){def = true;defson.Play();}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                    
                }
                if(hp > 0 && hp <= 25 && mana > 30 && mana <= 50)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,4);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){def = true;defson.Play();}
                    if(decision == 3){fuerte = true;}
                    if(decision == 4){fuerte = true;}
                    
                    
                }
                if(hp > 0 && hp <= 25 && mana > 50 && mana <= 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,4);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){}
                    if(decision == 3){rapido = true;}
                    if(decision == 4){rapido = true;}
                    
                    
                }
                if(hp > 0 && hp <= 25 && mana > 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,4);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){rapfue = true;}
                    
                    
                }
                if(hp > 0 && hp <= 50 && mana > 0 && mana <= 30)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){}
                    if(decision == 2){}
                    if(decision == 3){rapido = true;}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                    
                }
                if(hp > 25 && hp <= 50 && mana > 30 && mana <= 50)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){fuerte = true;}
                    if(decision == 3){}
                    if(decision == 4){}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                }
                if(hp > 25 && hp <= 50 && mana > 50 && mana <= 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){}
                    if(decision == 3){}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                }
                if(hp > 25 && hp <= 50 && mana > 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,4);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){rapfue = true;}
                    
                    
                }

                if(hp > 50 && hp <= 100 && mana > 0 && mana <= 30)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){}
                    if(decision == 2){}
                    if(decision == 3){}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                    
                }
                if(hp > 50 && hp <= 100 && mana > 30 && mana <= 50)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                }
                if(hp > 50 && hp <= 100 && mana > 50 && mana <= 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,4);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){fuerte = true;}
                    if(decision == 3){fuerte = true;}
                    if(decision == 4){fuerte = true;}
                    
                    
                }
                if(hp > 50 && hp <= 100 && mana > 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){def = true;defson.Play();}
                    if(decision == 2){fuerte = true;}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapfue = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapfue = true;}
                    
                    
                }
                if(hp > 100 && hp <= 200 && mana > 0 && mana <= 30)
                {   
                    if (temp > 10)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){}
                    if(decision == 2){fuerte = true;}
                    if(decision == 3){rapido = true;}
                    if(decision == 4){fuerte = true;}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                    
                }
                if(hp > 100 && hp <= 200 && mana > 30 && mana <= 50)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,6);
                    }
                    if(decision == 1){}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){fuerte = true;}
                    if(decision == 4){rapido = true;}
                    if(decision == 5){fuerte = true;}
                    if(decision == 6){rapido = true;}
                    
                    
                }
                if(hp > 100 && hp <= 200 && mana > 50 && mana <= 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = 1;
                    }
                    if(decision == 1){fuerte = true;}
                    
                    
                    
                }
                if(hp > 100 && hp <= 200 && mana > 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(1,4);
                    }
                    
                    if(decision == 1){fuerte = true;}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){rapfue = true;}
                    if(decision == 4){rapfue = true;}
                    
                    
                    
                }
                if(hp > 200 && mana > 0 && mana <= 30)
                {   
                    if (temp > 10)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,7);
                    }
                    if(decision == 1){}
                    if(decision == 2){}
                    if(decision == 3){}
                    if(decision == 4){}
                    if(decision == 5){rapido = true;}
                    if(decision == 6){fuerte = true;}
                    if(decision == 7){rapido = true;}
                    
                    
                    
                }
                if(hp > 200 &&  mana > 30 && mana <= 50)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,6);
                    }
                    if(decision == 1){}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){}
                    if(decision == 4){rapfue = true;}
                    if(decision == 5){fuerte = true;}
                    if(decision == 6){rapido = true;}
                    if(decision == 3){rapfue = true;}
                    if(decision == 3){rapfue = true;}
                    
                    
                }
                if(hp > 200 &&  mana > 50 && mana <= 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        Random.Range(1,2);
                    }
                    if(decision == 1){fuerte = true;}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){rapfue = true;}
                    
                    
                }
                if(hp > 200 && mana > 60)
                {   
                    if (temp > 2)
                    {decision = 0;temp = 0;def = false;}
                    if (decision == 0)
                    {
                        decision = Random.Range(2,2);
                    }
                    if(decision == 1){fuerte = true;}
                    if(decision == 2){rapfue = true;}
                    if(decision == 3){fuerte = true;}
                    if(decision == 4){rapfue = true;}
                    if(decision == 5){fuerte = true;}
                    if(decision == 6){rapfue = true;}
                    
                    
                }
                if (turbobar == 100)
                {
                    decision = 0;
                    turbo = true;
                }
                

            }
            if(nivel == 2 || nivel == 3)
            {
                if(limite  > 0)
                {
                    decision2 = Random.Range(1,3);
                    if (temp3 > decision3)
                    {   
                        if(decision2 == 1)
                        {
                            temp3 = 0;
                            hp += 40;
                            limite--;
                            decision2 = 0;
                            decision3 = Random.Range(25,30);
                        }
                        if(decision2 == 2)
                        {
                            temp3 = 0;
                            heroe.mana += 90;
                            limite--;
                            decision2 = 0;
                            decision3 = Random.Range(25,30);
                        }
                    }
                }
            }
            if(nivel == 4 || nivel == 5)
            {
                if(limite  > 0)
                {
                    decision2 = Random.Range(1,5);
                    if (temp3 > decision3)
                    {   
                        if(decision2 == 1)
                        {
                            temp3 = 0;
                            hp += 100;
                            limite--;
                            decision2 = 0;
                            decision3 = Random.Range(25,30);
                        }
                        if(decision2 == 2)
                        {
                            temp3 = 0;
                            heroe.mana += 130;
                            limite--;
                            decision2 = 0;
                            decision3 = Random.Range(25,30);
                        }
                    }
                }
            }
            if(nivel == 6 || nivel == 7)
            {
                if(limite  > 0)
                {
                    decision2 = Random.Range(1,5);
                    if (temp3 > decision3)
                    {   
                        if(decision2 == 1)
                        {
                            temp3 = 0;
                            hp += 200;
                            limite--;
                            decision2 = 0;
                            decision3 = Random.Range(25,30);
                        }
                        if(decision2 == 2)
                        {
                            temp3 = 0;
                            heroe.mana += 200;
                            limite--;
                            decision2 = 0;
                            decision3 = Random.Range(25,30);
                        }
                    }
                }
            }
            
















            if (rapido == true && atb == 100 && mana >= 20 && permiso == false && heroe.permiso == false)
            {
                mana -= 20;
                ataque = Random.Range(10,16) * fuerza;
                activar = true;
                permiso = true;
                turbobar += 10;
                atb = 0;
                rapson.Play();
                rapsound.Play();
                baseanim.SetBool("atkvel", true);
                baseanim2.SetBool("atkvel", true);
                baseanim3.SetBool("atkvel", true);
                dano = Random.Range(0,3);
            }
            else if (fuerte == true && atb == 100 && mana >= 30 && permiso == false  && heroe.permiso == false)
            {
                mana -= 30;
                ataque = Random.Range(16,20) * fuerza;
                activar = true;
                permiso = true;
                turbobar += 15;
                atb = 0;
                fueson.Play();
                fuesound.Play();
                baseanim.SetBool("atkfue", true);
                baseanim2.SetBool("atkfue", true);
                baseanim3.SetBool("atkfue", true);
                dano = Random.Range(0,3);
            }
            else if (rapfue == true && atb == 100 && mana >= 40 && permiso == false  && heroe.permiso == false) 
            {
                mana -= 50;
                turbobar += 35;
                ataque = Random.Range(18,25) * fuerza;
                activar = true;
                permiso = true;
                atb = 0;
                fulson.Play();
                rapfuesound.Play();
                baseanim.SetBool("atkrapfue", true);
                baseanim2.SetBool("atkrapfue", true);
                baseanim3.SetBool("atkrapfue", true);
                dano = Random.Range(0,3);
            }
            else if (turbo == true && atb == 100 && turbobar == 100 && permiso == false && heroe.permiso == false)
            {
                activar = true;
                permiso = true;
                turbobar = 0;
                turbosound.Play();
                turboson.Play();
                ataque = Random.Range(40,50) * fuerza;
                atb = 0;
                baseanim.SetBool("atkturbo", true);
                baseanim2.SetBool("atkturbo", true);
                baseanim3.SetBool("atkturbo", true);
                dano = Random.Range(0,3);
                
            }
            else
            {
                baseanim.SetBool("atkrapfue", false);
                baseanim.SetBool("atkvel", false);
                baseanim.SetBool("atkfue", false);
                baseanim.SetBool("atkturbo", false);

                baseanim2.SetBool("atkrapfue", false);
                baseanim2.SetBool("atkvel", false);
                baseanim2.SetBool("atkfue", false);
                baseanim2.SetBool("atkturbo", false);

                baseanim3.SetBool("atkrapfue", false);
                baseanim3.SetBool("atkvel", false);
                baseanim3.SetBool("atkfue", false);
                baseanim3.SetBool("atkturbo", false);
        

            }

            if (def == true && mana >= 5 && activar == false && permiso == false)
            {
                if(botebool == false)
                {bote.Play();}
                mana -= 3.5f * Time.deltaTime;
                turbobar += 0.7f * Time.deltaTime;
                prot.enabled = false;
                prot2.enabled = false;
                prot3.enabled = false;
                botebool = true;
                escudo.gameObject.SetActive(true);
                defusar = true;
                
            }
            else if (def == true && mana > 0  && mana < 5 && permiso == false && defusar == true)
            {
                mana -= 3.5f * Time.deltaTime;
                turbobar += 0.7f * Time.deltaTime;
                prot.enabled = false;
                prot2.enabled = false;
                prot3.enabled = false;
                escudo.gameObject.SetActive(true);
            }
            else 
            {   
                defusar = false;
                botebool = false;
                bote.Stop();
                prot.enabled = true;
                prot2.enabled = true;
                prot3.enabled = true;
                if(mana > -1)
                {
                    if (mana < manamax)
                    {mana+= 3f * manarec * Time.deltaTime;}
                }
                if(mana > 50)
                {
                    if (mana < manamax)
                    {mana+= 3.5f * manarec * Time.deltaTime;}
                }
                if(mana > 65)
                {
                    if (mana < manamax)
                    {mana+= 4f * manarec * Time.deltaTime;}
                }
            
                escudo.gameObject.SetActive(false);
            
            }
            

            if (mana < 0)
            {mana = 0;}

            if (turbobar > 100)
            {turbobar = 100;}
            if (hp > hpmax)
            {hp = hpmax;}
            if (mana > manamax)
            {mana = manamax;}
            if (hp < 0)
            {hp = 0;}
            if (mana < 0)
            {mana = 0;}



            rapido = false;
            fuerte = false;
            rapfue = false;
            turbo = false;

            mehp.text = "vit "+(int)hp+" / " + hpmax;
            memana.text = "Stamina "+(int)mana+" / " + manamax;


            

            if (temp < 15)
            {temp += 1 * Time.deltaTime;}

            if (temp1 < 15)
            {temp1 += 1 * Time.deltaTime;}
            if (temp4 < 15)
            {temp4 += 1 * Time.deltaTime;}
            

            
            mename.text = name;
            if (atb < 100)
            {atb += 15 * Time.deltaTime;}
            if (atb > 99) {atb = 100;}
        }
        mename.text = name;
    }
    
}
