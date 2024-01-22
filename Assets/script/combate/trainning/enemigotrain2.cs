using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;

public class enemigotrain2 : Agent
{
    public DynamicTextData textDatadano;

    public DynamicTextData textDatamana;

    public DynamicTextData textDatamanamas;

    public DynamicTextData textDataturbomas;
    public DynamicTextData textDataturbomenos;
    public enemigotrain1 heroe;

    public float tempdtext;

    public bool defv;


    public bool turbo = false;
    public bool rapido = false;
    public bool fuerte = false;
    public bool rapfue = false;
    public bool def = false;
    public bool defusar;
    public Text turboui;
    public bool botebool = false;

    public string name;
    public string bicho;
    public float hp;
    public float mana;
    public float manarec;
    public float fuerza;
    public float nivel;

    public Collider ev1c;

    public int limite = 3;

    public GameObject ev1;

    public AudioSource rapsound;
    public AudioSource fuesound;
    public AudioSource rapfuesound;
    public AudioSource turbosound;

    public AudioSource rapsoundcat;
    public AudioSource fuesoundcat;
    public AudioSource rapfuesoundcat;
    public AudioSource turbosoundcat;

    
    public RuntimeAnimatorController madcatanim1;

    public Animator baseanim;


    public float temp;
    public float temp1;
    public float temp4;
    public float temp3;
    public float ventaja = 0;
    public float atb = 100;
    public float rangoexp;
    public float rango;
    public float turbobar = 0;


    public Text mehp;
    public Text memana;
    public Text mename;

    public AudioSource bote;

    public Collider prot;

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


    public GameObject madcat1;


    public AudioSource fueson;
    public AudioSource rapson;
    public AudioSource fulson;
    public AudioSource defson;
    public AudioSource turboson;

    




    public float floattoint;

    public float ataque;
    public bool activar;
    public bool permiso;
    public float temp5;

    public string inteligencia = "inteligencia1";

    public int decision = 0;
    public int decision2 = 0;
    public int decision3 = 0;
    // Start is called before the first frame update
    public override void OnActionReceived(ActionBuffers actions)
    {
        decision = actions.DiscreteActions[0];
    }
    void Start()
    {

        decision3 = Random.Range(25,35);

        hp = 90;
        mana = 100;
        manarec = 1;
        fuerza = 1;
        rango = 1;
        name = "ene2";
        bicho = "madcat";
        nivel = 1;

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
        
        

       

        hpmax = (int)hp;
        manamax = (int)mana;
         if(bicho == "madcat")
        {
            
            madcat1.SetActive(true);
            ev1.SetActive(true);
            madcat1.name = "madcatn";
            baseanim.runtimeAnimatorController = madcatanim1;
            rapsound = rapsoundcat;
            fuesound = fuesoundcat;
            rapfuesound = rapfuesoundcat;
            turbosound = turbosoundcat;
            dano1 = dano1cat;
            dano2 = dano2cat;
            
        }
      

    }
    public override void OnEpisodeBegin()
    {
        hp = 90;
        mana = 100;
        manarec = 1;
        fuerza = 1;
        rango = 1;
        name = "ene2";
        bicho = "madcat";
        nivel = 1;

        heroe.hp = 150;
        heroe.mana = 100;
        heroe.manarec = 1;
        heroe.fuerza = 1;
        heroe.rango = 1;
        heroe.name = "ene2";
        heroe.bicho = "madcat";
        heroe.nivel = 1;
    }
    // Update is called once per frame
    public float tempesc;
    void Update()
    {
        if(hp < 1)
        {
            SetReward(-1000f);
            heroe.AddReward(1000f);
            heroe.EndEpisode();
            EndEpisode();
        }
        turboui.text = (int)turbobar+"%";
        managerdecombatetrain manager = UnityEngine.Object.FindObjectOfType<managerdecombatetrain>();
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
            if ( hp > 0 && ventaja > 2 && permiso == false)
            {


                if(decision2 == decision && decision != 1){AddReward(-70);}
                if(defusar == true && decision > 1 && decision < 7){AddReward(-70);}
                if(decision == 3 && mana < 25){AddReward(-1);}
                if(decision == 1){AddReward(-200);}
                if(decision == 3 && mana >= 20){AddReward(3);}
                if(decision == 4 && mana >= 30){AddReward(5);}
                if(decision == 2 && turbobar != 100){AddReward(-1);}
                if(decision == 2 && turbobar == 100){AddReward(3);}
                if(decision == 4 && mana < 35){AddReward(-1);}
                if(decision == 5 && mana >= 50){AddReward(10f);}
                if(decision == 5 && mana < 50){AddReward(-1f);}
                if(heroe.hp < (heroe.hpmax/100)* 20 && decision == 3){AddReward(5f);}
                if(mana < 5 * rangoexp){AddReward(2f * Time.deltaTime);}
                if(decision == 1){def = true;defson.Play();tempesc = 0;}
                if(decision == 2){def = false;turbo = true;tempesc = 0;}
                if(decision == 3){def = false;rapido = true;tempesc = 0;}
                if(decision == 4){def = false;fuerte = true;tempesc = 0;}
                if(decision == 5){def = false;rapfue = true;tempesc = 0;}
                if(tempesc > 5 && def == true){def = false;tempesc = 0;}
                decision2 = decision;

            }
            
















            if (rapido == true && atb == 100 && mana >= 20  * rangoexp&& permiso == false && heroe.permiso == false && temp5 > Random.Range(0f,0.2f))
            {
                mana -= 20 * rangoexp;
                ataque = Random.Range(3,10) * fuerza;
                activar = true;
                permiso = true;
                turbobar += 25;
                atb = 0;
                rapson.Play();
                rapsound.Play();
                baseanim.SetBool("atkvel", true);
                
                dano = Random.Range(0,3);

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(20 * rangoexp),textDatamana);  
 
                dtext.CreateText(ev1.transform.position,"+"+(int)(25),textDataturbomas);
                AddReward(0.1f);
            }
            else if (fuerte == true && atb == 100 && mana >= 30 * rangoexp && permiso == false  && heroe.permiso == false && temp5 > Random.Range(0f,0.2f))
            {
                mana -= 30 * rangoexp;
                ataque = Random.Range(15,20) * fuerza;
                activar = true;
                permiso = true;
                turbobar += 25;
                atb = 0;
                fueson.Play();
                fuesound.Play();
                baseanim.SetBool("atkfue", true);

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(30 * rangoexp),textDatamana);  
            
                dtext.CreateText(ev1.transform.position,"+"+(int)(25),textDataturbomas);
                AddReward(0.1f);
                
                dano = Random.Range(0,3);
            }
            else if (rapfue == true && atb == 100 && mana >= 50 * rangoexp && permiso == false  && heroe.permiso == false && temp5 > Random.Range(0f,0.2f)) 
            {
                mana -= 50 * rangoexp;
                turbobar += 50;
                ataque = Random.Range(37,40) * fuerza;
                activar = true;
                permiso = true;
                atb = 0;
                fulson.Play();
                rapfuesound.Play();
                baseanim.SetBool("atkrapfue", true);
                
                dano = Random.Range(0,3);

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(50 * rangoexp),textDatamana);  

                dtext.CreateText(ev1.transform.position,"+"+(int)(50),textDataturbomas);
                AddReward(0.1f);
            }
            else if (turbo == true && atb == 100 && turbobar == 100 && permiso == false && heroe.permiso == false && temp5 > Random.Range(0f,0.2f))
            {
                activar = true;
                permiso = true;
                turbobar = 0;
                turbosound.Play();
                turboson.Play();
                ataque = Random.Range(40,50) * fuerza;
                atb = 0;
                baseanim.SetBool("atkturbo", true);
                
                dano = Random.Range(0,3);

                DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                dtext.CreateText(ev1.transform.position,"-"+(int)(100),textDataturbomenos);
                AddReward(0.1f);
                
            }
            else
            {
                baseanim.SetBool("atkrapfue", false);
                baseanim.SetBool("atkvel", false);
                baseanim.SetBool("atkfue", false);
                baseanim.SetBool("atkturbo", false);

            
        

            }

            if (def == true && mana >= 5 * rangoexp && activar == false && permiso == false)
            {
                if(botebool == false)
                {bote.Play();}
                mana -= 8.5f * rangoexp * Time.deltaTime;
                turbobar += 0.7f * Time.deltaTime;
                defv = true;
               
                botebool = true;
                escudo.gameObject.SetActive(true);
                defusar = true;

                if(tempdtext > 1f)
                {
                    DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                    dtext.CreateText(ev1.transform.position,("-"+(3.5 * rangoexp)).Substring(0, 6),textDatamana);
                    tempdtext = 0;
                }
                tempdtext += 1 * Time.deltaTime; 
                AddReward(-0.50f);
                
            }
            else if (def == true && mana > 0  && mana < 5 * rangoexp && permiso == false && defusar == true)
            {
                mana -= 8.5f * rangoexp * Time.deltaTime;
                turbobar += 0.7f * Time.deltaTime;
                defv = true;
                escudo.gameObject.SetActive(true);
                if(tempdtext > 1f)
                {
                    DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                    dtext.CreateText(ev1.transform.position,("-"+(8.5 * rangoexp)).Substring(0, 6),textDatamana);
                    tempdtext = 0;
                }
                tempdtext += 1 * Time.deltaTime;
                AddReward(-0.50f);
            }
            else 
            {   
                defusar = false;
                botebool = false;
                bote.Stop();
                defv = false;
                
                
                    if (mana < manamax)
                    {
                        mana+= 1.5f * manarec * Time.deltaTime;
                        if(tempdtext > 1f)
                        {
                            DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
                            dtext.CreateText(ev1.transform.position,("+"+(1.5f * manarec)),textDatamanamas);
                            tempdtext = 0;
                        }
                    }
                    tempdtext += 1 * Time.deltaTime;
            
            
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
            if (temp5 < 15)
            {temp5 += 1 * Time.deltaTime;}
            if (tempesc < 15)
            {tempesc += 1 * Time.deltaTime;}
            

            
            mename.text = name;
            if (atb < 100)
            {atb += 15 * Time.deltaTime;}
            if (atb > 99) {atb = 100;}
        }
        mename.text = name;
    }
    
}
