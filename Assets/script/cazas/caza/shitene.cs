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

    public GameObject ghost;
    public GameObject algosaurio;
    public GameObject bigfat;
    public GameObject cazafantasmas;

    public GameObject darkknight;
    public GameObject antidog;
    public GameObject pinguino;
    public GameObject craneovil;

    public GameObject dogtable;
    public GameObject bee;
    public GameObject elephant;
    public GameObject flyera;

    public GameObject friend;
    public GameObject gunman;
    public GameObject flanerio;
    public GameObject fenix;





    public GameObject kingdragon;
    public GameObject heavydevil;
    public GameObject kraken;
    public GameObject lizardo;

    public GameObject livedish;
    public GameObject pesadilla;
    public GameObject mirror;
    public GameObject rabmon;

    public GameObject ant;
    public GameObject kingslug;
    public GameObject rosedragon;
    public GameObject sharkman;

    public GameObject pollovion;
    public GameObject trepillo;
    public GameObject roboerto;
    public GameObject tufo;

    public GameObject trashrat;
    public GameObject spider;
    public GameObject vivodado;
    public GameObject dragonron;



    public float defensa;
    public int rango;
    public float rangoexp;
    public float fuerzajug;
    public Text nombre;
    public Text hpt;

    public int hierba;
    public float hierbaexp;
    public float fuerza;
    public Animator anim;
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

        //1
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
        //2
        if (bicho == "dragonron")
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
            nombre.text = "dragon ron";
        }
        if (bicho == "elephant")
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
            nombre.text = "elephant";

        }
        if (bicho == "roboerto")
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
            nombre.text = "roboerto";

        }
        if (bicho == "tufo")
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
            nombre.text = "tufo";

        }
        //3
        if (bicho == "antidog")
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
            nombre.text = "antidog";
        }
        if (bicho == "cazafantasmas")
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
            nombre.text = "cazafantasmas";

        }
        if (bicho == "rabmon")
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
            nombre.text = "rabmon";

        }
        if (bicho == "vivodado")
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
            nombre.text = "vivodado";

        }
        //4
        if (bicho == "livedish")
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
            nombre.text = "livedish";
        }
        if (bicho == "rosedragon")
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
            nombre.text = "rose dragon";

        }
        if (bicho == "sharkman")
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
            nombre.text = "sharkman";

        }
        if (bicho == "spider")
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
            nombre.text = "spider";

        }
        //5
        if (bicho == "algosaurio")
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
            nombre.text = "algosaurio";
        }
        if (bicho == "dogtable")
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
            nombre.text = "dogtable";

        }
        if (bicho == "friend")
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
            nombre.text = "friend";

        }
        if (bicho == "trashrat")
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
            nombre.text = "trashrat";

        }
        //1
        if (bicho == "aghostin")
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
            nombre.text = "aghostin";
        }
        if (bicho == "heavydevil")
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
            nombre.text = "heavy devil";

        }
        if (bicho == "kingslug")
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
            nombre.text = "king slug";

        }
        if (bicho == "pollovion")
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
            nombre.text = "pollovion";

        }
        //2
        if (bicho == "ant")
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
            nombre.text = "sadistic ant";
        }
        if (bicho == "flanerio")
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
            nombre.text = "flanerio";

        }
        if (bicho == "flyera")
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
            nombre.text = "flyera";

        }
        if (bicho == "gunman")
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
            nombre.text = "gunman";

        }
        //3
        if (bicho == "craneovil")
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
            nombre.text = "craneovil";
        }
        if (bicho == "darkknight")
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
            nombre.text = "dark knight";

        }
        if (bicho == "lizardo")
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
            nombre.text = "lizardo";

        }
        if (bicho == "trepillo")
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
            nombre.text = "trepillo";

        }
        //4
        if (bicho == "beestosa")
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
            nombre.text = "beestosa";
        }
        if (bicho == "fenix")
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
            nombre.text = "fenix bug";

        }
        if (bicho == "kraken")
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
            nombre.text = "kraken";

        }
        if (bicho == "pesadilla")
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
            nombre.text = "pesadilla";

        }
        //5
        if (bicho == "bigfat")
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
            nombre.text = "bigfat";
        }
        if (bicho == "kingdragon")
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
            nombre.text = "king dragon";

        }
        if (bicho == "mirror")
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
            nombre.text = "mirror-mirror";

        }
        if (bicho == "cyberpinguino")
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
            nombre.text = "cyberpinguino";

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

                

                Destroy(BalaTemporal, 10.0f);
                temp = 0;



            }
            if(temp < 15)
            {temp += 1 * Time.deltaTime;}
            anim.SetInteger("atk", Random.Range(1,5));
        }
    }
    public void mostrar()
    {
        //1
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
         //2
        if(bicho == "aghostin")
        {
            ghost.SetActive(true);
        }
        if(bicho == "algosaurio")
        {
            algosaurio.SetActive(true);
        }
        if(bicho == "bigfat")
        {
            bigfat.SetActive(true);
        }
        if(bicho == "cazafantasmas")
        {
            cazafantasmas.SetActive(true);
        }
        //3
        if(bicho == "darkknight")
        {
            darkknight.SetActive(true);
        }
        if(bicho == "antidog")
        {
            antidog.SetActive(true);
        }
        if(bicho == "cyberpinguino")
        {
            pinguino.SetActive(true);
        }
        if(bicho == "craneovil")
        {
            craneovil.SetActive(true);
        }
        //4
        if(bicho == "dogtable")
        {
            dogtable.SetActive(true);
        }
        if(bicho == "beestosa")
        {
            bee.SetActive(true);
        }
        if(bicho == "elephant")
        {
            elephant.SetActive(true);
        }
        if(bicho == "flyera")
        {
            flyera.SetActive(true);
        }
        //5
        if(bicho == "friend")
        {
            friend.SetActive(true);
        }
        if(bicho == "gunman")
        {
            gunman.SetActive(true);
        }
        if(bicho == "flanerio")
        {
            flanerio.SetActive(true);
        }
        if(bicho == "fenix")
        {
            fenix.SetActive(true);
        }

        //1
        if(bicho == "kingdragon")
        {
            kingdragon.SetActive(true);
        }
        if(bicho == "heavydevil")
        {
            heavydevil.SetActive(true);
        }
        if(bicho == "kraken")
        {
            kraken.SetActive(true);
        }
        if(bicho == "lizardo")
        {
            lizardo.SetActive(true);
        }
         //2
        if(bicho == "livedish")
        {
            livedish.SetActive(true);
        }
        if(bicho == "pesadilla")
        {
            pesadilla.SetActive(true);
        }
        if(bicho == "mirror")
        {
            mirror.SetActive(true);
        }
        if(bicho == "rabmon")
        {
            rabmon.SetActive(true);
        }
        //3
        if(bicho == "ant")
        {
            ant.SetActive(true);
        }
        if(bicho == "kingslug")
        {
            kingslug.SetActive(true);
        }
        if(bicho == "rosedragon")
        {
            rosedragon.SetActive(true);
        }
        if(bicho == "sharkman")
        {
            sharkman.SetActive(true);
        }
        //4
        if(bicho == "pollovion")
        {
            pollovion.SetActive(true);
        }
        if(bicho == "trepillo")
        {
            trepillo.SetActive(true);
        }
        if(bicho == "roboerto")
        {
            roboerto.SetActive(true);
        }
        if(bicho == "tufo")
        {
            tufo.SetActive(true);
        }
        //5
        if(bicho == "trashrat")
        {
            trashrat.SetActive(true);
        }
        if(bicho == "spider")
        {
            spider.SetActive(true);
        }
        if(bicho == "vivodado")
        {
            vivodado.SetActive(true);
        }
        if(bicho == "dragonron")
        {
            dragonron.SetActive(true);
        }
    }   
    
}
