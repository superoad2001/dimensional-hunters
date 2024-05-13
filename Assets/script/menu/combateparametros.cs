using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combateparametros : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int rango;
    public float rangoexp;
    public void carga()
    {

        combatemenu comb = UnityEngine.Object.FindObjectOfType<combatemenu>();
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        rango = inv.datosserial.rangoplay;
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
        if(rango == 18)
        {rangoexp = 8.75f;}
        if(rango == 19)
        {rangoexp = 9.25f;}
        if(rango == 20)
        {rangoexp = 9.75f;}

        if(rango == 21)
        {rangoexp = 10;}
        comb.ciuda = new string[6];


        comb.ciuda[0] = "barcelona";
        comb.ciuda[1] = "tokyo";
        comb.ciuda[2] = "nueva york";
        comb.ciuda[3] = "londres";
        comb.ciuda[4] = "ciudad de mexico";


        comb.ligas = new string[27];
        comb.ligas[0] = "liga iniciales";
        comb.ligas[1] = "liga menor";
        comb.ligas[2] = "liga mayor";
        comb.ligas[3] = "liga veterana";
        comb.ligas[4] = "liga inicial veterana";
        comb.ligas[5] = "liga rango 1";

        comb.ligas[6] = "liga plateada";
        comb.ligas[7] = "liga dorada";
        comb.ligas[8] = "liga secundaria";
        comb.ligas[9] = "liga de rangos";
        comb.ligas[10] = "liga experta";
        comb.ligas[11] = "liga rango 2";

        comb.ligas[12] = "liga voladora";
        comb.ligas[13] = "liga extraña";
        comb.ligas[14] = "liga de juguete";
        comb.ligas[15] = "liga animal";
        comb.ligas[16] = "liga rango 3";

        comb.ligas[17] = "liga tecnologica";
        comb.ligas[18] = "liga oscura";
        comb.ligas[19] = "liga brillante";
        comb.ligas[20] = "liga variada";
        comb.ligas[21] = "liga rango 4"; 

        comb.ligas[22] = "liga romantica";
        comb.ligas[23] = "liga robada";
        comb.ligas[24] = "liga de apuestas";
        comb.ligas[25] = "liga especial";
        comb.ligas[26] = "liga rango 5";



        comb.torneos = new string[16];
        comb.torneos[0] = "torneo copa bronce";
        comb.torneos[1] = "torneo copa plata";
        comb.torneos[2] = "torneo copa oro";
        comb.torneos[3] = "torneo copa platino";


        comb.torneos[4] = "torneo animado";
        comb.torneos[5] = "torneo variado";
        comb.torneos[6] = "torneo especial";

        comb.torneos[7] = "torneo animal";
        comb.torneos[8] = "torneo inicial";
        comb.torneos[9] = "torneo experto";

        comb.torneos[10] = "torneo de muerte";
        comb.torneos[11] = "torneo casino";
        comb.torneos[12] = "torneo cientifico";

        comb.torneos[13] = "torneo ilegal";
        comb.torneos[14] = "torneo oscuro";
        comb.torneos[15] = "torneo veterano";
        


        comb.namebarcelona = new string[150];
        comb.hpbarcelona = new float[150];
        comb.manabarcelona = new float[150];
        comb.manarecbarcelona = new float[150];
        comb.fuerzabarcelona = new float[150];
        comb.elementobarcelona = new string[150];
        comb.nivelbarcelona = new float[150];
        comb.rangobarcelona = new float[150];
        comb.clasebarcelona = new float[150];

        


        comb.namebarcelona[0] = "paco";
        comb.hpbarcelona[0] = 75;
        comb.manabarcelona[0] = 60;
        comb.manarecbarcelona[0] = 0.5f;
        comb.fuerzabarcelona[0] = 0.8f;
        comb.nivelbarcelona[0] = 1;
        comb.rangobarcelona[0] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[0])
        {
            comb.rangobarcelona[0] = inv.datosserial.rangoplay;
            comb.hpbarcelona[0] = 75 * rangoexp;
            comb.manabarcelona[0] = 60 * rangoexp;
            comb.manarecbarcelona[0] = 0.5f * rangoexp;
            comb.fuerzabarcelona[0] = 0.8f * rangoexp;
            comb.rangobarcelona[0] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[0] = "comun rango : "+comb.rangobarcelona[0];
        comb.clasebarcelona[0] = 1;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[0] = "madcat";


        comb.namebarcelona[1] = "jaume";
        comb.hpbarcelona[1] = 110;
        comb.manabarcelona[1] = 100;
        comb.manarecbarcelona[1] = 0.3f;
        comb.fuerzabarcelona[1] = 0.8f;
        comb.rangobarcelona[1] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[1])
        {
            comb.rangobarcelona[1] = inv.datosserial.rangoplay;
            comb.hpbarcelona[1] = 110* rangoexp;
            comb.manabarcelona[1] = 100* rangoexp;
            comb.manarecbarcelona[1] = 0.3f* rangoexp;
            comb.fuerzabarcelona[1] = 0.8f* rangoexp;
            comb.rangobarcelona[1] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[1] = "comun rango : "+comb.rangobarcelona[1];
        comb.clasebarcelona[1] = 1;
        comb.nivelbarcelona[1] = 2;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[1] = "shitfloor";


        comb.namebarcelona[2] = "agusti";
        comb.hpbarcelona[2] = 160;
        comb.manabarcelona[2] = 75;
        comb.manarecbarcelona[2] = 0.45f;
        comb.fuerzabarcelona[2] = 1f;
        comb.rangobarcelona[2] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[2])
        {
            comb.rangobarcelona[2] = inv.datosserial.rangoplay;
            comb.hpbarcelona[2] = 160* rangoexp;
            comb.manabarcelona[2] = 75* rangoexp;
            comb.manarecbarcelona[2] = 0.45f* rangoexp;
            comb.fuerzabarcelona[2] = 1f* rangoexp;
            comb.rangobarcelona[2] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[2] = "comun rango : "+comb.rangobarcelona[2];
        comb.clasebarcelona[2] = 1;
        comb.nivelbarcelona[2] = 2;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[2] = "topo topo";


        comb.namebarcelona[3] = "enric";
        comb.hpbarcelona[3] = 210;
        comb.manabarcelona[3] = 90;
        comb.manarecbarcelona[3] = 1f;
        comb.fuerzabarcelona[3] = 0.9f;
        comb.rangobarcelona[3] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[3])
        {
            comb.rangobarcelona[3] = inv.datosserial.rangoplay;
            comb.hpbarcelona[3] = 210* rangoexp;
            comb.manabarcelona[3] = 90* rangoexp;
            comb.manarecbarcelona[3] = 1f* rangoexp;
            comb.fuerzabarcelona[3] = 0.9f* rangoexp;
            comb.rangobarcelona[3] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[3] = "comun rango : "+comb.rangobarcelona[3];
        comb.clasebarcelona[3] = 1;
        comb.nivelbarcelona[3] = 3;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[3] = "skybird";

        comb.namebarcelona[4] = "josep";
        comb.hpbarcelona[4] = 260;
        comb.manabarcelona[4] = 100;
        comb.manarecbarcelona[4] = 1f;
        comb.fuerzabarcelona[4] = 1f;
        comb.rangobarcelona[4] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[4])
        {
            comb.rangobarcelona[4] = inv.datosserial.rangoplay;
            comb.hpbarcelona[4] = 260* rangoexp;
            comb.manabarcelona[4] = 100* rangoexp;
            comb.manarecbarcelona[4] = 1.2f* rangoexp;
            comb.fuerzabarcelona[4] = 1.3f* rangoexp;
            comb.rangobarcelona[4] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[4] = "comun rango : "+comb.rangobarcelona[4];
        comb.clasebarcelona[4] = 1;
        comb.nivelbarcelona[4] = 4;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[4] = "topo topo";


        comb.namebarcelona[5] = "maria";
        comb.hpbarcelona[5] = 330;
        comb.manabarcelona[5] = 110;
        comb.manarecbarcelona[5] = 1f;
        comb.fuerzabarcelona[5] = 1.70f;
        comb.rangobarcelona[5] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[5])
        {
            comb.rangobarcelona[5] = inv.datosserial.rangoplay;
            comb.hpbarcelona[5] = 330* rangoexp;
            comb.manabarcelona[5] = 110* rangoexp;
            comb.manarecbarcelona[5] = 1.0f* rangoexp;
            comb.fuerzabarcelona[5] = 1.7f* rangoexp;
            comb.rangobarcelona[5] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[5] = "comun rango : "+comb.rangobarcelona[5];
        comb.clasebarcelona[5] = 1;
        comb.nivelbarcelona[5] = 5;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[5] = "madcat";

        comb.namebarcelona[6] = "ariadna";
        comb.hpbarcelona[6] = 370;
        comb.manabarcelona[6] = 120;
        comb.manarecbarcelona[6] = 1f;
        comb.fuerzabarcelona[6] = 1.9f;
        comb.rangobarcelona[6] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[6])
        {
            comb.rangobarcelona[6] = inv.datosserial.rangoplay;
            comb.hpbarcelona[6] = 370* rangoexp;
            comb.manabarcelona[6] = 120* rangoexp;
            comb.manarecbarcelona[6] = 1f* rangoexp;
            comb.fuerzabarcelona[6] = 1.9f* rangoexp;
            comb.rangobarcelona[6] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[6] = "plateado rango : "+comb.rangobarcelona[6];
        comb.clasebarcelona[6] = 2;
        comb.nivelbarcelona[6] = 6;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[6] = "friend";



        comb.namebarcelona[7] = "alex";
        comb.hpbarcelona[7] = 430;
        comb.manabarcelona[7] = 117;
        comb.manarecbarcelona[7] = 1.05f;
        comb.fuerzabarcelona[7] = 2.1f;
        comb.rangobarcelona[7] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[7])
        {
            comb.rangobarcelona[7] = inv.datosserial.rangoplay;
            comb.hpbarcelona[7] = 430* rangoexp;
            comb.manabarcelona[7] = 117* rangoexp;
            comb.manarecbarcelona[7] = 1.05f* rangoexp;
            comb.fuerzabarcelona[7] = 2.1f* rangoexp;
            comb.rangobarcelona[7] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[7] = "comun rango : "+comb.rangobarcelona[7];
        comb.clasebarcelona[7] = 1;
        comb.nivelbarcelona[7] = 7;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[7] = "pollovion";



        comb.namebarcelona[8] = "roberto";
        comb.hpbarcelona[8] = 490;
        comb.manabarcelona[8] = 120;
        comb.manarecbarcelona[8] = 1.05f;
        comb.fuerzabarcelona[8] = 2.3f;
        comb.rangobarcelona[8] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[8])
        {
            comb.rangobarcelona[8] = inv.datosserial.rangoplay;
            comb.hpbarcelona[8] = 490* rangoexp;
            comb.manabarcelona[8] = 120* rangoexp;
            comb.manarecbarcelona[8] = 1.05f* rangoexp;
            comb.fuerzabarcelona[8] = 2.3f* rangoexp;
            comb.rangobarcelona[8] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[8] = "comun rango : "+comb.rangobarcelona[8];
        comb.clasebarcelona[8] = 1;
        comb.nivelbarcelona[8] = 8;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[8] = "roboerto";

        comb.namebarcelona[9] = "pepe";
        comb.hpbarcelona[9] = 550;
        comb.manabarcelona[9] = 130;
        comb.manarecbarcelona[9] = 1.10f;
        comb.fuerzabarcelona[9] = 2.5f;
        comb.rangobarcelona[9] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[9])
        {
            comb.rangobarcelona[9] = inv.datosserial.rangoplay;
            comb.hpbarcelona[9] = 550* rangoexp;
            comb.manabarcelona[9] = 130* rangoexp;
            comb.manarecbarcelona[9] = 1.10f* rangoexp;
            comb.fuerzabarcelona[9] = 2.5f* rangoexp;
            comb.rangobarcelona[9] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[9] = "comun rango : "+comb.rangobarcelona[9];
        comb.clasebarcelona[9] = 1;
        comb.nivelbarcelona[9] = 9;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[9] = "aghostin";


        comb.namebarcelona[10] = "alan";
        comb.hpbarcelona[10] = 600;
        comb.manabarcelona[10] = 130;
        comb.manarecbarcelona[10] = 1.25f;
        comb.fuerzabarcelona[10] = 2.7f;
        comb.rangobarcelona[10] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[10])
        {
            comb.rangobarcelona[10] = inv.datosserial.rangoplay;
            comb.hpbarcelona[10] = 600* rangoexp;
            comb.manabarcelona[10] = 130* rangoexp;
            comb.manarecbarcelona[10] = 1.25f* rangoexp;
            comb.fuerzabarcelona[10] = 2.7f* rangoexp;
            comb.rangobarcelona[10] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[10] = "comun rango : "+comb.rangobarcelona[10];
        comb.clasebarcelona[10] = 1;
        comb.nivelbarcelona[10] = 10;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[10] = "cazafantasmas";



        //liga mayor

        comb.namebarcelona[11] = "jordi";
        comb.hpbarcelona[11] = 670;
        comb.manabarcelona[11] = 140;
        comb.manarecbarcelona[11] = 1.30f;
        comb.fuerzabarcelona[11] = 3.20f;
        comb.rangobarcelona[11] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[11])
        {
            comb.rangobarcelona[11] = inv.datosserial.rangoplay;
            comb.hpbarcelona[11] = 670* rangoexp;
            comb.manabarcelona[11] = 140* rangoexp;
            comb.manarecbarcelona[11] = 1.30f* rangoexp;
            comb.fuerzabarcelona[11] = 3.2f* rangoexp;
            comb.rangobarcelona[11] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[11] = "comun rango : "+comb.rangobarcelona[11];
        comb.clasebarcelona[11] = 1;
        comb.nivelbarcelona[11] = 11;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[11] = "darkknight";


        comb.namebarcelona[12] = "david";
        comb.hpbarcelona[12] = 700;
        comb.manabarcelona[12] = 142;
        comb.manarecbarcelona[12] = 1.45f;
        comb.fuerzabarcelona[12] = 3.5f;
        comb.rangobarcelona[12] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[12])
        {
            comb.rangobarcelona[12] = inv.datosserial.rangoplay;
            comb.hpbarcelona[12] = 700* rangoexp;
            comb.manabarcelona[12] = 142* rangoexp;
            comb.manarecbarcelona[12] = 1.45f* rangoexp;
            comb.fuerzabarcelona[12] = 3.5f* rangoexp;
            comb.rangobarcelona[12] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[12] = "comun rango : "+comb.rangobarcelona[12];
        comb.clasebarcelona[12] = 1;
        comb.nivelbarcelona[12] = 12;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[12] = "roboerto";

        comb.namebarcelona[13] = "marc";
        comb.hpbarcelona[13] = 750;
        comb.manabarcelona[13] = 147;
        comb.manarecbarcelona[13] = 1.50f;
        comb.fuerzabarcelona[13] = 3.8f;
        comb.rangobarcelona[13] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[13])
        {
            comb.rangobarcelona[13] = inv.datosserial.rangoplay;
            comb.hpbarcelona[13] = 750* rangoexp;
            comb.manabarcelona[13] = 147* rangoexp;
            comb.manarecbarcelona[13] = 1.50f* rangoexp;
            comb.fuerzabarcelona[13] = 3.8f* rangoexp;
            comb.rangobarcelona[13] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[13] = "comun rango : "+comb.rangobarcelona[13];
        comb.clasebarcelona[13] = 1;
        comb.nivelbarcelona[13] = 13;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[13] = "vivodado";

        comb.namebarcelona[14] = "carlos";
        comb.hpbarcelona[14] = 800;
        comb.manabarcelona[14] = 152;
        comb.manarecbarcelona[14] = 1.55f;
        comb.fuerzabarcelona[14] = 4.2f;
        comb.rangobarcelona[14] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[14])
        {
            comb.rangobarcelona[14] = inv.datosserial.rangoplay;
            comb.hpbarcelona[14] = 800* rangoexp;
            comb.manabarcelona[14] = 152* rangoexp;
            comb.manarecbarcelona[14] = 1.55f* rangoexp;
            comb.fuerzabarcelona[14] = 4.2f* rangoexp;
            comb.rangobarcelona[14] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[14] = "comun rango : "+comb.rangobarcelona[14];
        comb.clasebarcelona[14] = 1;
        comb.nivelbarcelona[14] = 14;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[14] = "cyberpinguino";

        comb.namebarcelona[15] = "albert";
        comb.hpbarcelona[15] = 850;
        comb.manabarcelona[15] = 160;
        comb.manarecbarcelona[15] = 1.6f;
        comb.fuerzabarcelona[15] = 4.5f;
        comb.rangobarcelona[15] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[15])
        {
            comb.rangobarcelona[15] = inv.datosserial.rangoplay;
            comb.hpbarcelona[15] = 850* rangoexp;
            comb.manabarcelona[15] = 160* rangoexp;
            comb.manarecbarcelona[15] = 1.6f* rangoexp;
            comb.fuerzabarcelona[15] = 4.5f* rangoexp;
            comb.rangobarcelona[15] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[15] = "comun rango : "+comb.rangobarcelona[15];
        comb.clasebarcelona[15] = 1;
        comb.nivelbarcelona[15] = 15;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[15] = "gunman";

        comb.namebarcelona[16] = "chris";
        comb.hpbarcelona[16] = 900;
        comb.manabarcelona[16] = 165;
        comb.manarecbarcelona[16] = 1.65f;
        comb.fuerzabarcelona[16] = 5f;
        comb.rangobarcelona[16] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[16])
        {
            comb.rangobarcelona[16] = inv.datosserial.rangoplay;
            comb.hpbarcelona[16] = 900* rangoexp;
            comb.manabarcelona[16] = 165* rangoexp;
            comb.manarecbarcelona[16] = 1.65f* rangoexp;
            comb.fuerzabarcelona[16] = 5f* rangoexp;
            comb.rangobarcelona[16] = inv.datosserial.rangoplay;
        }
        comb.elementobarcelona[16] = "comun rango : "+comb.rangobarcelona[16];
        comb.clasebarcelona[16] = 1;
        comb.nivelbarcelona[16] = 16;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[16] = "pesadilla";













        

    }
    public void _torneo(int torneo)
    {
        combatemenu comb = UnityEngine.Object.FindObjectOfType<combatemenu>();
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(torneo == 0)
        {

            inv.datosserial.hptorneo[0] = comb.hpbarcelona[1];
            inv.datosserial.manatorneo[0] = comb.manabarcelona[1];
            inv.datosserial.manarectorneo[0] = comb.manarecbarcelona[1];
            inv.datosserial.fuerzatorneo[0] = comb.fuerzabarcelona[1];
            inv.datosserial.nametorneo[0] = comb.namebarcelona[1];
            inv.datosserial.razatorneo[0] =  comb.bichosbarcelona[1];
            inv.datosserial.niveltorneo[0] = (int)comb.nivelbarcelona[1];
            inv.datosserial.clasetorneo[0] = comb.clasebarcelona[1];
            inv.datosserial.rangotorneo[0] = comb.rangobarcelona[1];

            inv.datosserial.hptorneo[1] = comb.hpbarcelona[2];
            inv.datosserial.manatorneo[1] = comb.manabarcelona[2];
            inv.datosserial.manarectorneo[1] = comb.manarecbarcelona[2];
            inv.datosserial.fuerzatorneo[1] = comb.fuerzabarcelona[2];
            inv.datosserial.nametorneo[1] = comb.namebarcelona[2];
            inv.datosserial.razatorneo[1] =  comb.bichosbarcelona[2];
            inv.datosserial.niveltorneo[1] = (int)comb.nivelbarcelona[2];
            inv.datosserial.clasetorneo[1] = comb.clasebarcelona[2];
            inv.datosserial.rangotorneo[1] = comb.rangobarcelona[2];

            inv.datosserial.hptorneo[2] = comb.hpbarcelona[3];
            inv.datosserial.manatorneo[2] = comb.manabarcelona[3];
            inv.datosserial.manarectorneo[2] = comb.manarecbarcelona[3];
            inv.datosserial.fuerzatorneo[2] = comb.fuerzabarcelona[3];
            inv.datosserial.nametorneo[2] = comb.namebarcelona[3];
            inv.datosserial.razatorneo[2] =  comb.bichosbarcelona[3];
            inv.datosserial.niveltorneo[2] = (int)comb.nivelbarcelona[3];
            inv.datosserial.clasetorneo[2] = comb.clasebarcelona[3];
            inv.datosserial.rangotorneo[2] = comb.rangobarcelona[3];
            inv.datosserial.torneopuesto = 0;
            inv.datosserial.modotorneo = true;
            inv.guardar();


            inv.datosserial.hpr = (int)Random.Range(900f,1000f)*comb.rangoexp * 1.5f;
            inv.datosserial.manar = (int)Random.Range(200f,220f)*comb.rangoexp * 1.5f;
            inv.datosserial.manarecr = Random.Range(1.6f,1.7f)*comb.rangoexp * 1.5f;
            inv.datosserial.fuerzar = Random.Range(1.8f,2f)*comb.rangoexp * 1.5f;
            inv.datosserial.elementor = "dorado rango :"+inv.datosserial.rangoplay;
            inv.datosserial.nivelr = 15;
            inv.datosserial.claser = 3;
            inv.datosserial.razar = "skybird";
            inv.datosserial.rangorr = inv.datosserial.rangoplay;
            inv.guardar();
        }
    }
}
