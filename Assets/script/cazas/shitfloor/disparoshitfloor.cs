using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class disparoshitfloor : MonoBehaviour
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

    public float hp;
    public float hpmax = 3;
    public float temp = 0.7f;
    public float temp2 = 0;
    public float temp3 = 120;
    public float temp4 = 0;
    public bool disp;
    public bool escudorec;
    public Quaternion rota;
    public AudioSource pip;
    public bool vez1;
    public GameObject cam;
    public GameObject cam1;
    public bool escudo = false;
    public bool escudoact = false;
    public float mana = 100;
    public Image barrahp;
    public Image barramana;
    public string bicho = "madcat";
    public GameObject escudoonda;
    public int rango;
    public float rangoexp;
    public float hierbaexp;
    public int hierbatipo;
    public Text hpt;
    public Text manat;
    public float fuerzaene;
    void Start()
    {
        arSession.Reset ();
         new Vector3(0,0,0);
        cam.transform.position = new Vector3(0,0,0f);
        rango = PlayerPrefs.GetInt("rango", 1);
        if(rango == 1)
        {rangoexp = 1;}
        if(rango == 2)
        {rangoexp = 1.05f;}
        if(rango == 3)
        {rangoexp = 1.10f;}
        if(rango == 4)
        {rangoexp = 1.15f;}
        if(rango == 5)
        {rangoexp = 1.20f;}

        if(rango == 6)
        {rangoexp = 1.25f;}
        if(rango == 7)
        {rangoexp = 1.30f;}
        if(rango == 8)
        {rangoexp = 1.35f;}
        if(rango == 9)
        {rangoexp = 1.40f;}
        if(rango == 10)
        {rangoexp = 1.45f;}

        if(rango == 11)
        {rangoexp = 1.50f;}
        if(rango == 12)
        {rangoexp = 1.55f;}
        if(rango == 13)
        {rangoexp = 1.60f;}
        if(rango == 14)
        {rangoexp = 1.65f;}
        if(rango == 15)
        {rangoexp = 1.70f;}

        if(rango == 16)
        {rangoexp = 1.75f;}
        if(rango == 17)
        {rangoexp = 1.80f;}
        if(rango == 18)
        {rangoexp = 1.85f;}
        if(rango == 19)
        {rangoexp = 1.90f;}
        if(rango == 20)
        {rangoexp = 1.95f;}

        if(rango == 21)
        {rangoexp = 2;}

        if(rango == 1)
        {hpmax = 30; }
        if(rango == 2)
        {hpmax = 50; }
        if(rango == 3)
        {hpmax = 70; }
        if(rango == 4)
        {hpmax = 90; }
        if(rango == 5)
        {hpmax = 100; }

        if(rango == 6)
        {hpmax = 150; }
        if(rango == 7)
        {hpmax = 200; }
        if(rango == 8)
        {hpmax = 250; }
        if(rango == 9)
        {hpmax = 300; }
        if(rango == 10)
        {hpmax = 350; }

        if(rango == 11)
        {hpmax = 400; }
        if(rango == 12)
        {hpmax = 500; }
        if(rango == 13)
        {hpmax = 600; }
        if(rango == 14)
        {hpmax = 650; }
        if(rango == 15)
        {hpmax = 700; }

        if(rango == 16)
        {hpmax = 750;}
        if(rango == 17)
        {hpmax = 780; }
        if(rango == 18)
        {hpmax = 800; }
        if(rango == 19)
        {hpmax = 875; }
        if(rango == 20)
        {hpmax = 950; }

        if(rango == 21)
        {hpmax = 1000;}

        statsc();

        hp = hpmax;

        hierbatipo = PlayerPrefs.GetInt("hierbatipo", 1);

        if(hierbatipo == 1)
        {hierbaexp = 1;}
        if(hierbatipo == 2)
        {hierbaexp = 1.25f;}
        if(hierbatipo == 3)
        {hierbaexp = 1.5f;}       
    }

    public bool salir = false;

    public bool inicio = false;
    public float iniciotem = 0;
    public GameObject negro;

    public void _salir()
    {
        salir = true;
    }
    public void _escudo()
    {

            escudoact = true;
            
    }
    public void _noescudo()
    {
        escudoact = false;
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

            barrahp.fillAmount = hp/hpmax;
            barramana.fillAmount = mana/100;
            hpt.text = "hp: "+(int)hp+"/"+hpmax;
            manat.text = "mana: "+(int)mana+"/100";

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

                    Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                    

                    Destroy(BalaTemporal, 5.0f);
                    temp = 0;

            
            }
            if(escudorec == true && mana >= 100)
            {
                escudorec = false;
                barramana.color = new Color(0,221,255,255);
            }
            if(escudoact == true && mana > 1 && escudorec == false)
            {
                escudo = true;
                mana -= 100 * Time.deltaTime;
                if(mana < 0){mana = 0;}
                escudoonda.SetActive(true);
            }
            else
            {
                escudo = false;

                mana += 10 * Time.deltaTime;
                if(mana > 100)
                {mana = 100;}
                escudoonda.SetActive(false);
            }
            if (mana <= 1)
            {
                escudorec = true;
                barramana.color = new Color(219,255,0,255);
            }
            if (temp3 > -1)
            {temp3 -= 1 * Time.deltaTime;}
            if (temp < 15)
            {temp += 1 * Time.deltaTime;}
        }
        if(enemigo.hp <=  0 && vez1 == false)
        {
            cuenta_.gameObject.SetActive(true);
            caza_.gameObject.SetActive(false);
            cuenta.text = "ganaste";
            comienzo = false;
            vez1 = true;
            temp4 = 0;
            if(bicho == "madcat")
            {
            PlayerPrefs.SetFloat("hpr", (int)Random.Range(100f,140)*rangoexp * hierbaexp);
            PlayerPrefs.SetFloat("manar", (int)Random.Range(80f,90)*rangoexp * hierbaexp);
            PlayerPrefs.SetFloat("manarecr", Random.Range(0.7f,0.7f)*rangoexp * hierbaexp);
            PlayerPrefs.SetFloat("fuerzar", Random.Range(0.3f,0.5f)*rangoexp * hierbaexp);
            if(hierbatipo == 1){PlayerPrefs.SetString("tipor", "comun rango :"+rango);}
            if(hierbatipo == 2){PlayerPrefs.SetString("tipor", "plateado rango :"+rango);}
            if(hierbatipo == 3){PlayerPrefs.SetString("tipor", "dorado rango :"+rango);}
            if(hierbatipo == 1){PlayerPrefs.SetFloat("nivelr", 1);}
            if(hierbatipo == 2){PlayerPrefs.SetFloat("nivelr", (int)Random.Range(1,3));}
            if(hierbatipo == 3){PlayerPrefs.SetFloat("nivelr", (int)Random.Range(1,4));}
            PlayerPrefs.SetString("razar", "madcat");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "skybird")
            {
            PlayerPrefs.SetFloat("hpr", (int)Random.Range(90f,95f)*rangoexp * hierbaexp);
            PlayerPrefs.SetFloat("manar", (int)Random.Range(110f,130f)*rangoexp * hierbaexp);
            PlayerPrefs.SetFloat("manarecr", Random.Range(0.9f,1f)*rangoexp * hierbaexp);
            PlayerPrefs.SetFloat("fuerzar", Random.Range(0.3f,0.5f)*rangoexp * hierbaexp);
            if(hierbatipo == 1){PlayerPrefs.SetString("tipor", "comun rango :"+rango);}
            if(hierbatipo == 2){PlayerPrefs.SetString("tipor", "plateado rango :"+rango);}
            if(hierbatipo == 3){PlayerPrefs.SetString("tipor", "dorado rango :"+rango);}
            if(hierbatipo == 1){PlayerPrefs.SetFloat("nivelr", 1);}
            if(hierbatipo == 2){PlayerPrefs.SetFloat("nivelr", (int)Random.Range(1,3));}
            if(hierbatipo == 3){PlayerPrefs.SetFloat("nivelr", (int)Random.Range(1,4));}
            PlayerPrefs.SetString("razar", "skybird");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "shitfloor")
            {
            PlayerPrefs.SetFloat("hpr", (int)Random.Range(150f,160)*rangoexp * hierbaexp);
            PlayerPrefs.SetFloat("manar", (int)Random.Range(200f,210)*rangoexp * hierbaexp);
            PlayerPrefs.SetFloat("manarecr", Random.Range(0.2f,0.4f)*rangoexp * hierbaexp);
            PlayerPrefs.SetFloat("fuerzar", Random.Range(0.2f,0.35f)*rangoexp * hierbaexp);
            if(hierbatipo == 1){PlayerPrefs.SetString("tipor", "comun rango :"+rango);}
            if(hierbatipo == 2){PlayerPrefs.SetString("tipor", "plateado rango :"+rango);}
            if(hierbatipo == 3){PlayerPrefs.SetString("tipor", "dorado rango :"+rango);}
            if(hierbatipo == 1){PlayerPrefs.SetFloat("nivelr", 1);}
            if(hierbatipo == 2){PlayerPrefs.SetFloat("nivelr", (int)Random.Range(1,3));}
            if(hierbatipo == 3){PlayerPrefs.SetFloat("nivelr", (int)Random.Range(1,4));}
            PlayerPrefs.SetString("razar", "shitfloor");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "topo")
            {
            PlayerPrefs.SetFloat("hpr", (int)Random.Range(70f,80)*rangoexp * hierbaexp);
            PlayerPrefs.SetFloat("manar", (int)Random.Range(50f,60)*rangoexp * hierbaexp);
            PlayerPrefs.SetFloat("manarecr", Random.Range(0.1f,0.3f)*rangoexp * hierbaexp);
            PlayerPrefs.SetFloat("fuerzar", Random.Range(1f,1.1f)*rangoexp * hierbaexp);
            if(hierbatipo == 1){PlayerPrefs.SetString("tipor", "comun rango :"+rango);}
            if(hierbatipo == 2){PlayerPrefs.SetString("tipor", "plateado rango :"+rango);}
            if(hierbatipo == 3){PlayerPrefs.SetString("tipor", "dorado rango :"+rango);}
            if(hierbatipo == 1){PlayerPrefs.SetFloat("nivelr", 1);}
            if(hierbatipo == 2){PlayerPrefs.SetFloat("nivelr", (int)Random.Range(1,3));}
            if(hierbatipo == 3){PlayerPrefs.SetFloat("nivelr", (int)Random.Range(1,4));}
            PlayerPrefs.SetString("razar", "topo topo");
            PlayerPrefs.SetFloat("rangor", rango);
            }
        }
        if( hp <=  0 && vez1 == false)
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
        if (col.gameObject.tag == "balaene" && escudo == false)
		{
            hp = hp -(fuerzaene* hierbaexp);
            UnityEngine.Object.Destroy(col.gameObject);
		}
        if (col.gameObject.tag == "balaene" && escudo == true)
		{
            if(hp<hpmax)
            {hp += 5 * rangoexp;}
            if(hp > hpmax)
            {hp = hpmax;}
            UnityEngine.Object.Destroy(col.gameObject);
		}
    }
    public void statsc()
    {
        if (bicho == "madcat")
        {
            if(rango <= 2)
            {
                fuerzaene = 5;
            }
            else if(rango > 2)
            {
                fuerzac();
            }
        }
        if (bicho == "skybird")
        {
            if(rango <= 2)
            {
                fuerzaene = 5;
            }
            else if(rango > 2)
            {
                fuerzac();
            }

        }
        if (bicho == "shitfloor")
        {
            if(rango <= 2)
            {
                fuerzaene = 5;
            }
            else if(rango > 2)
            {
                fuerzac();
            }

        }
        if (bicho == "topo")
        {
            if(rango <= 2)
            {
                fuerzaene = 5;
            }
            else if(rango > 2)
            {
                fuerzac();
            }

        }
    }
    public void fuerzac()
    {
        if(rango == 1)
        {fuerzaene = 5;}
        if(rango == 2)
        {fuerzaene = 10 ;}
        if(rango == 3)
        {fuerzaene = 20 ;}
        if(rango == 4)
        {fuerzaene = 30 ;}
        if(rango == 5)
        {fuerzaene = 40 ;}

        if(rango == 6)
        {fuerzaene = 50 ;}
        if(rango == 7)
        {fuerzaene = 58 ;}
        if(rango == 8)
        {fuerzaene = 65 ;}
        if(rango == 9)
        {fuerzaene = 70 ;}
        if(rango == 10)
        {fuerzaene = 80 ;}

        if(rango == 11)
        {fuerzaene = 100 ;}
        if(rango == 12)
        {fuerzaene = 130 ;}
        if(rango == 13)
        {fuerzaene = 150 ;}
        if(rango == 14)
        {fuerzaene = 170 ;}
        if(rango == 15)
        {fuerzaene = 200 ;}

        if(rango == 16)
        {fuerzaene = 220 ;}
        if(rango == 17)
        {fuerzaene = 240 ;}
        if(rango == 18)
        {fuerzaene = 260 ;}
        if(rango == 19)
        {fuerzaene = 280 ;}
        if(rango == 20)
        {fuerzaene = 300 ;}

        if(rango == 21)
        {fuerzaene = 320;}
    }
    
}
