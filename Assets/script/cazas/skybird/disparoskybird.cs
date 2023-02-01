using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class disparoskybird : MonoBehaviour
{
    public GameObject BalaInicio;
	public GameObject BalaPrefab;
    public GameObject ene1;
    public GameObject ene2;
    public GameObject ene3;
    public GameObject ene4;
    public Text cuenta;
    public Text cuetemp;

    public bool comienzo;
    public int cue = 3;

    public GameObject cuenta_;
    public GameObject caza_;

    public float temp = 0.7f;
    public float temp2 = 0;
    public float temp3 = 90;
    public float temp4 = 0;
    public bool disp;
    public Quaternion rota;
    public int enemigos = 0;
    public AudioSource pip;
    public bool vez1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bool salir = false;
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

        if (comienzo == false && cue == 3)
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
            skybirdene enemigo = UnityEngine.Object.FindObjectOfType<skybirdene>();
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
        if(enemigos == 2)
        {
            ene1.gameObject.SetActive(true);
            ene2.gameObject.SetActive(true);
            ene3.gameObject.SetActive(true);
            ene4.gameObject.SetActive(true);
        }
        if(enemigos == 6 && vez1 == false)
        {
            vez1 = true;
            cuenta_.gameObject.SetActive(true);
            caza_.gameObject.SetActive(false);
            cuenta.text = "ganaste";
            comienzo = false;
            temp4 = 0;

            PlayerPrefs.SetFloat("hpr", (int)Random.Range(70f,110));
            PlayerPrefs.SetFloat("manar", (int)Random.Range(65f,80));
            PlayerPrefs.SetFloat("manarecr", Random.Range(0.9f,1.3f));
            PlayerPrefs.SetFloat("fuerzar", Random.Range(0.8f,1.2f));
            PlayerPrefs.SetString("tipor", "aereo");
            PlayerPrefs.SetFloat("nivelr", 1);
            PlayerPrefs.SetString("razar", "skybird");
        }
        if(temp3 <= 0  && vez1 == false)
        {
            vez1 = true;
            cuenta_.gameObject.SetActive(true);
            caza_.gameObject.SetActive(false);
            cuenta.text = "perdiste";
            comienzo = false;
            temp4 = 0;
        }
        if (comienzo == false && enemigos == 6 && temp4 > 3)
        {
            SceneManager.LoadScene("obtener");
        }
        if (comienzo == false && temp3 <= 0 && temp4 > 3)
        {
            SceneManager.LoadScene("menu");
        }
        if (temp4 < 15)
        {temp4 += 1 * Time.deltaTime;}
        if (temp2 < 15)
        {temp2 += 1 * Time.deltaTime;}
    }
    
}
