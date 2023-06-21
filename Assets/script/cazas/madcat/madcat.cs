using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class madcat : MonoBehaviour
{
    public ARSession arSession;
    public GameObject cam;
    public GameObject cam1;
    // Start is called before the first frame update
    void Start()
    {
        arSession.Reset ();
         new Vector3(0,0,0);
        cam.transform.position = new Vector3(0,0,0f);
    }

    public Text uitext;
    public AudioSource pip;
    public string com;
    public bool comienzo;
    public Text cuenta;
    public Text tempo;
    public float temp = 0;
    public float temp1 = 3;
    public float temp2 = 60;
    public float temp4 = 0;
    public int cue = 3;

    public int decision_ = 0;
    public int frases;
    public int frase1;
    public int frase2;
    public int frase3;
    public int frase4;
    public int frase5;

    public int decision;

    public bool frased1;
    public bool frased2;
    public bool frased3;
    public bool frased4;
    public bool frased5;
    public bool frased6;
    public bool frased7;
    public bool frased8;
    public bool frased9;
    public bool frased10;

    public GameObject cuenta_;
    public GameObject caza_;

    public GameObject negro;

    public Animator boca;

    public AudioSource audio;
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    public AudioSource audio6;
    public AudioSource audio7;
    public AudioSource audio8;
    public AudioSource audio9;
    public AudioSource audio10;



    public bool salir = false;
    public bool inicio = false;
    public float iniciotem = 0;
    public void _salir()
    {
        salir = true;
    }

    public Text barra;
    // Update is called once per frame
    void Update()
    {

        if(salir == true)
        {SceneManager.LoadScene("seleccion");}
        salir = false;
        if (iniciotem > 2 && inicio == false)
        {
            inicio = true;
            negro.gameObject.SetActive(false);
            temp = 0;

        }
        if(iniciotem < 15)
        {iniciotem += 1 * Time.deltaTime;}
        if (comienzo == false && cue == 3 && inicio == true )
        {
            cuenta.text = "3";
            cue = 2;
            temp = 0;

        }
        else if (comienzo == false && cue == 2 && temp > 2)
        {
            cuenta.text = "2";
            cue = 1;
            temp = 0;
            pip.Play();
        }
        else if (comienzo == false && cue == 1 && temp > 2)
        {
            cuenta.text = "1";
            cue = 0;
            temp = 0;
            pip.Play();
        }
        else if (comienzo == false && cue == 0 && temp > 2)
        {
            cuenta_.gameObject.SetActive(false);
            caza_.gameObject.SetActive(true);
            comienzo = true;
            cue = -1;
            temp = 0;
            pip.Play();
        }
        if (comienzo == true)
        {
            if (frases == 0 )
            {   
                if(decision == 0)
                {
                    decision = Random.Range(1,4);
                    frase1 = decision;
                    if(decision == 1 )
                    {
                       audio = audio1;audio.Play();
                    }
                    if(decision == 2 )
                    {
                       audio = audio2;audio.Play();
                    }
                    if(decision == 3 )
                    {
                       audio = audio3;audio.Play();
                    }
                    barra.text = "escucha";
                    temp1 = 3;
                    
                    
                }
                if(decision == 1 && !audio.isPlaying)
                {
                    if(frased1 == true)
                    {frases =1; decision = 0;temp = 0;}
                }
                if(decision == 2 && !audio.isPlaying)
                {
                    if(frased2 == true)
                    {frases =1; decision = 0;temp = 0;}
                }
                if(decision == 3 && !audio.isPlaying)
                {
                    if(frased3 == true)
                    {frases =1; decision = 0;temp = 0;}
                }
                if(!audio.isPlaying && temp1 > 0)
                {
                    
                    temp1 += -1 * Time.deltaTime;
                    barra.text = "repite en " + (int)temp1;
                    if(temp1 < 1)
                    {
                        barra.text = "repite";
                    
                        
                    }
                }
                
                frased1=false;
                frased2=false;
                frased3=false;
                frased4=false;
                frased5=false;
                frased6=false;
                frased7=false;
                frased8=false;
                frased9=false;
                frased10=false;


            }
            if (frases == 1 && temp > 3)
            {   
                if(decision == 0)
                {
                    decision = Random.Range(1,4);
                    frase2 = decision;
                    if(decision == frase1)
                    {decision = 0;}
                    if(decision == 1 )
                    {
                       audio = audio1;audio.Play();
                    }
                    if(decision == 2 )
                    {
                       audio = audio2;audio.Play();
                    }
                    if(decision == 3 )
                    {
                       audio = audio3;audio.Play();
                    }
                    barra.text = "escucha";
                    temp1 = 3;
                   
                    
                }
                if(decision == 1 && !audio.isPlaying)
                {

                    if(frased1 == true)
                    {frases =2; decision = 0;temp = 0;}
                }
                if(decision == 2 && !audio.isPlaying)
                {
                    if(frased2 == true)
                    {frases =2; decision = 0;temp = 0;}
                }
                if(decision == 3 && !audio.isPlaying)
                {
                    if(frased3 == true)
                    {frases =2; decision = 0;temp = 0;}
                }
                if(!audio.isPlaying && temp1 > 0)
                {
                    
                    temp1 += -1 * Time.deltaTime;
                    barra.text = "repite en " + (int)temp1;
                    if(temp1 < 1)
                    {
                        barra.text = "repite";
                    }
                }
                
                frased1=false;
                frased2=false;
                frased3=false;
                frased4=false;
                frased5=false;
                frased6=false;
                frased7=false;
                frased8=false;
                frased9=false;
                frased10=false;


            }
            if (frases == 2 && temp > 3 && comienzo == true)
            {   
                cuenta_.gameObject.SetActive(true);
                caza_.gameObject.SetActive(false);
                cuenta.text = "ganaste";
                temp4 = 0;
                comienzo = false;

                PlayerPrefs.SetFloat("hpr", Random.Range(100f,120));
                PlayerPrefs.SetFloat("manar", Random.Range(50f,70));
                PlayerPrefs.SetFloat("manarecr", Random.Range(0.4f,0.6f));
                PlayerPrefs.SetFloat("fuerzar", Random.Range(0.7f,0.9f));
                PlayerPrefs.SetString("tipor", "terreno");
                PlayerPrefs.SetFloat("nivelr", 1);
                PlayerPrefs.SetString("razar", "madcat");

            
            }
            if (temp2 < 1 && comienzo == true)
            {   
                cuenta_.gameObject.SetActive(true);
                caza_.gameObject.SetActive(false);
                cuenta.text = "perdiste";
                temp4 = 0;
                comienzo = false;
            }
            
        }
        if (comienzo == false && frases == 2 && temp4 > 3)
        {
            SceneManager.LoadScene("obtener");
        }
        if (comienzo == false && temp4 > 3 && temp2 < 1)
        {
            SceneManager.LoadScene("menu");
        }
        
        if (temp < 15)
        {temp += 1 * Time.deltaTime;}
        if (temp4 < 15 && comienzo == false & temp2 < 1 ||  comienzo == false && frases == 2 && temp4 < 15)
        {temp4 += 1 * Time.deltaTime;}
        if (temp2 > 0 && temp1 < 1 && comienzo == true && !audio.isPlaying)
        {temp2 += -1 * Time.deltaTime;}
        tempo.text = "tiempo: "+(int)temp2;

        
        if(uitext.text.Length > 31)
        {uitext.text = com;}
        com = uitext.text;
    
        
    }
     public void frase1dd()
    {
        frased1 = true;
    }
     public void frase2dd()
    {
        frased2 = true;
    }
     public void frase3dd()
    {
        frased3 = true;
    }
     public void frase4dd()
    {
        frased4 = true;
    }
     public void frase5dd()
    {
        frased5 = true;
    }
     public void frase6dd()
    {
        frased6 = true;
    }
     public void frase7dd()
    {
        frased7 = true;
    }
     public void frase8dd()
    {
        frased8 = true;
    }
     public void frase9dd()
    {
        frased9 = true;
    }
     public void frase10dd()
    {
        frased10 = true;
    }

}
