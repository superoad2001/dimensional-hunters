using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using Rewired;

public class disparoshitfloor : MonoBehaviour
{
    [SerializeField]private int playerID = 0;
	[SerializeField]private Player player;
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
    public string plat;
    void Start()
    {
        plat = PlayerPrefs.GetString("plat","game3d");
        if(plat == "arcore")
        {
        arSession.Reset ();
        cam.transform.position = new Vector3(0,0,0f);
        }
        if(plat == "game3d" || plat == "game3dt")
        {
         player = ReInput.players.GetPlayer(playerID);
        }
        rango = PlayerPrefs.GetInt("rango", 1);
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
        bicho = PlayerPrefs.GetString("bichocaza", "madcat");    
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
            if(plat == "arcore")
            {
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
            }
            if(plat == "game3d" || plat == "game3dt")
            {
                if (disp == true && temp >= 0.7f || player.GetAxis("rb") > 0 && temp >= 0.7f)
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
                if(escudoact == true && mana > 1 && escudorec == false || player.GetAxis("lb") > 0 && mana > 1 && escudorec == false)
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
            //1
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "topo topo");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            //2
            if(bicho == "dragonron")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "dragonron");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "elephant")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "eleph-ant");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "roboerto")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "roboerto");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "tufo")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "tufo");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            //3
            if(bicho == "antidog")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "antidog");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "cazafantasmas")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "cazafantasmas");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "rabmon")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "rabmon");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "vivodado")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "vivodado");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            //4
            if(bicho == "livedish")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "livedish");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "rosedragon")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "rose dragon");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "sharkman")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "sharkman");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "spider")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "spider");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            //5
            if(bicho == "algosaurio")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "algosaurio");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "dogtable")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "dogtable");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "friend")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "friend");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "trashrat")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "trashrat");
            PlayerPrefs.SetFloat("rangor", rango);
            }

            //1
            if(bicho == "aghostin")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "aghostin");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "heavydevil")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "heavy devil");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "kingslug")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "king slug");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "pollovion")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "pollovion");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            //2
            if(bicho == "ant")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "sadistic ant");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "flanerio")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "flanerio");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "flyera")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "flyera");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "gunman")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "gunman");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            //3
            if(bicho == "craneovil")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "craneovil");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "darkknight")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "dark knight");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "lizardo")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "lizardo");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "trepillo")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "trepillo");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            //4
            if(bicho == "beestosa")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "beestosa");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "fenix")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "fenix bug");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "kraken")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "kraken");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "pesadilla")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "pesadilla");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            //5
            if(bicho == "bigfat")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "bigfat");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "kingdragon")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "king dragon");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "mirror")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "mirror-mirror");
            PlayerPrefs.SetFloat("rangor", rango);
            }
            if(bicho == "pinguino")
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
            PlayerPrefs.SetFloat("claser",hierbatipo);
            PlayerPrefs.SetString("razar", "cyberpinguino");
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
         //2
        if(bicho == "aghostin")
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
        if(bicho == "algosaurio")
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
        if(bicho == "bigfat")
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
        if(bicho == "cazafantasmas")
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
        //3
        if(bicho == "darkknight")
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
        if(bicho == "antidog")
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
        if(bicho == "cyberpinguino")
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
        if(bicho == "craneovil")
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
        //4
        if(bicho == "dogtable")
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
        if(bicho == "beestosa")
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
        if(bicho == "elephant")
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
        if(bicho == "flyera")
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
        //5
        if(bicho == "friend")
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
        if(bicho == "gunman")
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
        if(bicho == "flanerio")
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
        if(bicho == "fenix")
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

        //1
        if(bicho == "kingdragon")
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
        if(bicho == "heavydevil")
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
        if(bicho == "kraken")
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
        if(bicho == "lizardo")
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
         //2
        if(bicho == "livedish")
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
        if(bicho == "pesadilla")
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
        if(bicho == "mirror")
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
        if(bicho == "rabmon")
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
        //3
        if(bicho == "ant")
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
        if(bicho == "kingslug")
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
        if(bicho == "rosedragon")
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
        if(bicho == "sharkman")
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
        //4
        if(bicho == "pollovion")
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
        if(bicho == "trepillo")
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
        if(bicho == "roboerto")
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
        if(bicho == "tufo")
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
        //5
        if(bicho == "trashrat")
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
        if(bicho == "spider")
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
        if(bicho == "vivodado")
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
        if(bicho == "dragonron")
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
