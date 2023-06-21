using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class topoper2 : MonoBehaviour
{
    public ARSession arSession;
    public GameObject player;
    public GameObject player2;
    public float speed;
    public Text cuenta;
    public Text cuetemp;

    public bool comienzo;
    public int cue = 3;

    public GameObject cuenta_;
    public GameObject caza_;

    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;

    public float hp = 3;
    public Animator baseanim;
    public float temp = 0.7f;
    public float temp2 = 0;
    public float temp3 = 120;
    public float temp4 = 0;
    public bool disp;
    public Quaternion rota;
    public AudioSource pip;
    public bool vez1;
    public GameObject cam;
    public GameObject cam1;
    // Start is called before the first frame update
    void Start()
    {
        arSession.Reset ();
         new Vector3(0,0,0);
        cam.transform.position = new Vector3(0,0,0f);
    }

    public bool salir = false;

    public bool inicio = false;
    public float iniciotem = 0;
    public GameObject negro;

    public void _salir()
    {
        salir = true;
    }
    public void disparo()
    {
        disp = true;
    }
    public void notdisparo()
    {
        disp = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(hp == 2)
        {
            vida3.gameObject.SetActive(false);
        }
        if(hp == 1)
        {
            vida2.gameObject.SetActive(false);
        }
        if(hp == 0)
        {
            vida1.gameObject.SetActive(false);
        }
        shitene enemigo = UnityEngine.Object.FindObjectOfType<shitene>();
        if (iniciotem > 2 && inicio == false)
        {
            inicio = true;
            negro.gameObject.SetActive(false);
            temp2 = 0;

        }
        if(iniciotem < 15)
        {iniciotem += 1 * Time.deltaTime;}
        if (comienzo == false && cue == 3  && inicio == true)
        {
            cuenta.text = "3";
            cue = 2;
            temp2 = 0;

        }
        else if (comienzo == false && cue == 2 && temp2 > 2)
        {
            cuenta.text = "2";
            cue = 1;
            temp2 = 0;
            pip.Play();
        }
        else if (comienzo == false && cue == 1 && temp2 > 2)
        {
            cuenta.text = "1";
            cue = 0;
            temp2 = 0;
            pip.Play();
        }
        else if (comienzo == false && cue == 0 && temp2 > 2)
        {
            cuenta_.gameObject.SetActive(false);
            caza_.gameObject.SetActive(true);
            comienzo = true;
            cue = -1;
            temp2 = 0;
            pip.Play();
            
        }






        if(comienzo == true)
            {
            baseanim.SetBool("mov", true);
            
            if(salir == true)
            {SceneManager.LoadScene("seleccion");}
            salir = false;
        

            transform.position = Vector3.MoveTowards(transform.position,player.transform.position,speed * Time.deltaTime);
            transform.forward = player.transform.position - transform.position;

            if (temp3 > -1)
            {temp3 -= 1 * Time.deltaTime;}
            if (temp < 15)
            {temp += 1 * Time.deltaTime;}
            cuetemp.text = "tiempo: "+(int)temp3;
        }
        if(temp3 <= 0 && vez1 == false)
        {
            vez1 = true;
            cuenta_.gameObject.SetActive(true);
            caza_.gameObject.SetActive(false);
            cuenta.text = "ganaste";
            comienzo = false;

            PlayerPrefs.SetFloat("hpr", (int)Random.Range(150f ,150));
            PlayerPrefs.SetFloat("manar", (int)Random.Range(120f,120));
            PlayerPrefs.SetFloat("manarecr", Random.Range(1.20f,1.25f));
            PlayerPrefs.SetFloat("fuerzar", Random.Range(1.40f,1.50f));
            PlayerPrefs.SetString("tipor", "fuerte");
            PlayerPrefs.SetFloat("nivelr", 11);
            PlayerPrefs.SetString("razar", "poro topo");

            temp4 = 0;
        }
        if(hp <=  0 && vez1 == false)
        {
            vez1 = true;
            cuenta_.gameObject.SetActive(true);
            caza_.gameObject.SetActive(false);
            cuenta.text = "perdiste";
            comienzo = false;
            temp4 = 0;
        }
        if (comienzo == false && hp <=  0&& temp4 > 2 )
        {
            SceneManager.LoadScene("menu");
        }
        if (comienzo == false && temp3 <= 0 && temp4 > 2)
        {
            SceneManager.LoadScene("obtener");
        }
        if (temp4 < 15)
        {temp4 += 1 * Time.deltaTime;}
        if (temp2 < 15)
        {temp2 += 1 * Time.deltaTime;}
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
		{
            hp -= 1;
            if(hp != 0)
            {
            baseanim.SetBool("mov", false);
            comienzo = false;
            cue = 3;
            temp2 = 0;
            cuenta_.gameObject.SetActive(true);
            caza_.gameObject.SetActive(false);
            }
            player2.transform.position = new Vector3(-4.17999983f,1.54999995f,0.829999983f);
            player2.transform.eulerAngles = new Vector3(0,0,0);

            transform.position = new Vector3(-3.97000003f,0.583000004f,7.8499999f);
            transform.eulerAngles = new Vector3(0,0,0);
            
		}
    }
    
}
