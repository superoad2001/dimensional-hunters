using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shitene : MonoBehaviour
{   

    public Image barrahp;
    public Image barrahp2;
    public float hp = 100;
    public float hpmax = 100;
    public float ataquetemp = 3;
    public float temp;
    public Quaternion rota;
    public GameObject BalaInicio;
	public GameObject BalaPrefab;
    public GameObject player;
    public string bicho = "madcat";
    public GameObject madcat;
    public GameObject skybird;
    public GameObject shitfloor;
    public GameObject topo;
    public float defensa;
    public int rango;
    public float rangoexp;
    public float fuerzajug;
    public Text nombre;
    public Text hpt;

    public int hierba;
    public float hierbaexp;
    public float fuerza;
    // Start is called before the first frame update
    void Start()
    {
        bicho = PlayerPrefs.GetString("bichocaza", "madcat");
        rango = PlayerPrefs.GetInt("rango", 1);
        if(rango == 1)
        {fuerzajug = 5;}
        if(rango == 2)
        {fuerzajug = 10 ;}
        if(rango == 3)
        {fuerzajug = 20 ;}
        if(rango == 4)
        {fuerzajug = 30 ;}
        if(rango == 5)
        {fuerzajug = 40 ;}

        if(rango == 6)
        {fuerzajug = 50 ;}
        if(rango == 7)
        {fuerzajug = 58 ;}
        if(rango == 8)
        {fuerzajug = 65 ;}
        if(rango == 9)
        {fuerzajug = 70 ;}
        if(rango == 10)
        {fuerzajug = 80 ;}

        if(rango == 11)
        {fuerzajug = 90 ;}
        if(rango == 12)
        {fuerzajug = 98 ;}
        if(rango == 13)
        {fuerzajug = 105 ;}
        if(rango == 14)
        {fuerzajug = 110 ;}
        if(rango == 15)
        {fuerzajug = 120 ;}

        if(rango == 16)
        {fuerzajug = 125 ;}
        if(rango == 17)
        {fuerzajug = 135 ;}
        if(rango == 18)
        {fuerzajug = 145 ;}
        if(rango == 19)
        {fuerzajug = 150 ;}
        if(rango == 20)
        {fuerzajug = 155 ;}

        if(rango == 21)
        {fuerzajug = 160;}

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

        
        hierba = PlayerPrefs.GetInt("hierbatipo", 1);
        if (hierba == 1)
        {hierbaexp = 1;}
        if (hierba == 2)
        {hierbaexp = 1.1f;}
        if (hierba == 3)
        {hierbaexp = 1.2f;}

        if (bicho == "madcat")
        {
            if(rango <= 2)
            {
            hpmax = 110 * hierbaexp;
            ataquetemp = 3;
            defensa = 0;
            fuerza = 10 * hierbaexp;
            }
            else if(rango > 2)
            {
            hpmax = 110 * rangoexp * hierbaexp;
            ataquetemp = 3;
            defensa = 0 * rangoexp;
            fuerza = 10 * rangoexp * hierbaexp;
            }
            nombre.text = "madcat";
        }
        if (bicho == "skybird")
        {
            if(rango <= 2)
            {
            hpmax = 100 * hierbaexp;
            ataquetemp = 2;
            defensa = 0 ;
            fuerza = 10 * hierbaexp;
            }
            else if(rango > 2)
            {
            hpmax = 100 * rangoexp * hierbaexp;
            ataquetemp = 3;
            defensa = 0 * rangoexp;
            fuerza = 10 * rangoexp * hierbaexp;
            }
            nombre.text = "skybird";

        }
        if (bicho == "shitfloor")
        {
            if(rango <= 2)
            {
            hpmax = 100  * hierbaexp;
            ataquetemp = 3;
            defensa = 0 ;
            fuerza = 20  * hierbaexp;
            }
            else if(rango > 2)
            {
            hpmax = 100 * rangoexp * hierbaexp;
            ataquetemp = 3;
            defensa = 0 * rangoexp;
            fuerza = 20 * rangoexp * hierbaexp;
            }
            nombre.text = "shitfloor";

        }
        if (bicho == "topo")
        {
            if(rango <= 2)
            {
            hpmax = 100 * hierbaexp;
            ataquetemp = 3;
            defensa = 0 ;
            fuerza = 10  * hierbaexp;
            }
            else if(rango > 2)
            {
            hpmax = 100 * rangoexp * hierbaexp;
            ataquetemp = 3;
            defensa = 0 * rangoexp;
            fuerza = 10 * rangoexp * hierbaexp;
            }
            nombre.text = "topo topo";

        }
        hp = hpmax;
        mostrar();
    }
    // Update is called once per frame
    void Update()
    {
        disparoshitfloor manager = UnityEngine.Object.FindObjectOfType<disparoshitfloor>();
        if(manager.comienzo == true)
        {
            barrahp.fillAmount = hp/hpmax;
            barrahp2.fillAmount = hp/hpmax;
            hpt.text = "hp: "+(int)hp+"/"+hpmax;
            if(hp <= 0)
            {UnityEngine.Object.Destroy(this.gameObject);}
            if(temp > ataquetemp)
            {
                rota = BalaInicio.transform.rotation;
                GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position,rota) as GameObject;
                Debug.Log(BalaTemporal.transform.eulerAngles);

                Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                

                Destroy(BalaTemporal, 5.0f);
                temp = 0;



            }
            if(temp < 15)
            {temp += 1 * Time.deltaTime;}
        }
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bala")
		{
            Debug.Log("fun");
            if((fuerzajug-defensa) >= 5)
			{hp = hp - (fuerzajug - defensa);}
            else if((fuerzajug-defensa) < 5)
            {hp = hp - 5;}
            UnityEngine.Object.Destroy(col.gameObject);
		}
    }
    public void mostrar()
    {
        if(bicho == "madcat")
        {
            madcat.SetActive(true);
        }
        if(bicho == "skybird")
        {
            skybird.SetActive(true);
        }
        if(bicho == "shitfloor")
        {
            shitfloor.SetActive(true);
        }
        if(bicho == "topo")
        {
            topo.SetActive(true);
        }
    }   
    
}
