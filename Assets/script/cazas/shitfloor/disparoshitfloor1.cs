using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class disparoshitfloor1 : MonoBehaviour
{
    public ARSession arSession;
    public GameObject BalaInicio;
	public GameObject BalaPrefab;
    //numeros de la cuenta atras
    public Text cuenta;
    //texto con el temporizador que si acaba pierdes el nivel
    public Text cuetemp;
    //permiso para comenzar los eventos del nivel
    public bool comienzo;
    //el numero que cuando llega a 0 pierdes
    public int cue = 3;
    
    public GameObject cuenta_;
    public GameObject caza_;

    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;

    public float hp = 3;

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
        arSession.Reset();
        cam1.transform.position = new Vector3(0,0,0);
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
            
            if(salir == true)
            {SceneManager.LoadScene("seleccion");}
            salir = false;
            if (disp == true && temp >= 0.7f)
            {
                
                    rota = BalaInicio.transform.rotation;
                    GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position,rota) as GameObject;
                    Debug.Log(BalaTemporal.transform.eulerAngles);

                    Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                    

                    Destroy(BalaTemporal, 5.0f);
                    temp = 0;

            
            }
            if (temp3 > -1)
            {temp3 -= 1 * Time.deltaTime;}
            if (temp < 15)
            {temp += 1 * Time.deltaTime;}
            cuetemp.text = "tiempo: "+(int)temp3;
        }
        if(enemigo.hp <=  0 && vez1 == false)
        {
            cuenta_.gameObject.SetActive(true);
            caza_.gameObject.SetActive(false);
            cuenta.text = "ganaste";
            comienzo = false;
            vez1 = true;
            temp4 = 0;

            PlayerPrefs.SetFloat("hpr", (int)Random.Range(135f,145));
            PlayerPrefs.SetFloat("manar", (int)Random.Range(140f,150));
            PlayerPrefs.SetFloat("manarecr", Random.Range(1.05f,1.15f));
            PlayerPrefs.SetFloat("fuerzar", Random.Range(1.05f,1.15f));
            PlayerPrefs.SetString("tipor", "viscoso");
            PlayerPrefs.SetFloat("nivelr", 6);
            PlayerPrefs.SetString("razar", "shitplus");
        }
        if(temp3 <= 0 || hp <=  0 && vez1 == false)
        {
            cuenta_.gameObject.SetActive(true);
            caza_.gameObject.SetActive(false);
            cuenta.text = "perdiste";
            comienzo = false;
            temp4 = 0;
            vez1 = true;
        }
        if (comienzo == false && temp3 <= 0 && temp4 > 3||comienzo == false &&  hp <=  0 && temp4 > 3)
        {
            SceneManager.LoadScene("menu");
        }
        if (comienzo == false && enemigo.hp <=  0&& temp4 > 3 )
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
        if (col.gameObject.tag == "balaene")
		{
            hp -= 1;
            UnityEngine.Object.Destroy(col.gameObject);
		}
    }
    
}
