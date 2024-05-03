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
        if(rango == 48)
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
        comb.ligas[1] = "liga menos";
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
        comb.hpbarcelona[0] = 100;
        comb.manabarcelona[0] = 60;
        comb.manarecbarcelona[0] = 0.5f;
        comb.fuerzabarcelona[0] = 0.8f;
        comb.nivelbarcelona[0] = 1;
        comb.rangobarcelona[0] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[0])
        {
            comb.rangobarcelona[0] = inv.datosserial.rangoplay;
            comb.hpbarcelona[0] = 100 * rangoexp;
            comb.manabarcelona[0] = 60 * rangoexp;
            comb.manarecbarcelona[0] = 0.5f * rangoexp;
            comb.fuerzabarcelona[0] = 0.8f * rangoexp;
            comb.nivelbarcelona[0] = 1 * rangoexp;
            comb.rangobarcelona[0] = 1 * rangoexp;
        }
        comb.elementobarcelona[0] = "comun rango : "+comb.rangobarcelona[0];
        comb.clasebarcelona[0] = 1;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[0] = "madcat";


        comb.namebarcelona[1] = "jaume";
        comb.hpbarcelona[1] = 60;
        comb.manabarcelona[1] = 100;
        comb.manarecbarcelona[1] = 0.3f;
        comb.fuerzabarcelona[1] = 0.8f;
        comb.rangobarcelona[1] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[1])
        {
            comb.rangobarcelona[1] = inv.datosserial.rangoplay;
            comb.hpbarcelona[1] = 60* rangoexp;
            comb.manabarcelona[1] = 100* rangoexp;
            comb.manarecbarcelona[1] = 0.3f* rangoexp;
            comb.fuerzabarcelona[1] = 0.8f* rangoexp;
            comb.rangobarcelona[1] = 1* rangoexp;
        }
        comb.elementobarcelona[1] = "comun rango : "+comb.rangobarcelona[1];
        comb.clasebarcelona[1] = 1;
        comb.nivelbarcelona[1] = 1;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[1] = "shitfloor";


        comb.namebarcelona[2] = "agusti";
        comb.hpbarcelona[2] = 80;
        comb.manabarcelona[2] = 70;
        comb.manarecbarcelona[2] = 0.4f;
        comb.fuerzabarcelona[2] = 1f;
        comb.rangobarcelona[2] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[2])
        {
            comb.rangobarcelona[2] = inv.datosserial.rangoplay;
            comb.hpbarcelona[2] = 80* rangoexp;
            comb.manabarcelona[2] = 70* rangoexp;
            comb.manarecbarcelona[2] = 0.4f* rangoexp;
            comb.fuerzabarcelona[2] = 1f* rangoexp;
            comb.rangobarcelona[2] = 1* rangoexp;
        }
        comb.elementobarcelona[2] = "comun rango : "+comb.rangobarcelona[2];
        comb.clasebarcelona[2] = 1;
        comb.nivelbarcelona[2] = 2;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[2] = "topo topo";


        comb.namebarcelona[3] = "enric";
        comb.hpbarcelona[3] = 120;
        comb.manabarcelona[3] = 80;
        comb.manarecbarcelona[3] = 0.7f;
        comb.fuerzabarcelona[3] = 0.7f;
        comb.rangobarcelona[3] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[3])
        {
            comb.rangobarcelona[3] = inv.datosserial.rangoplay;
            comb.hpbarcelona[3] = 120* rangoexp;
            comb.manabarcelona[3] = 80* rangoexp;
            comb.manarecbarcelona[3] = 0.7f* rangoexp;
            comb.fuerzabarcelona[3] = 0.7f* rangoexp;
            comb.rangobarcelona[3] = 1* rangoexp;
        }
        comb.elementobarcelona[3] = "comun rango : "+comb.rangobarcelona[3];
        comb.clasebarcelona[3] = 1;
        comb.nivelbarcelona[3] = 3;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[3] = "skybird";

        comb.namebarcelona[4] = "josep";
        comb.hpbarcelona[4] = 100;
        comb.manabarcelona[4] = 110;
        comb.manarecbarcelona[4] = 0.4f;
        comb.fuerzabarcelona[4] = 1.1f;
        comb.rangobarcelona[4] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[4])
        {
            comb.rangobarcelona[4] = inv.datosserial.rangoplay;
            comb.hpbarcelona[4] = 100* rangoexp;
            comb.manabarcelona[4] = 110* rangoexp;
            comb.manarecbarcelona[4] = 0.4f* rangoexp;
            comb.fuerzabarcelona[4] = 1.1f* rangoexp;
            comb.rangobarcelona[4] = 1* rangoexp;
        }
        comb.elementobarcelona[4] = "comun rango : "+comb.rangobarcelona[4];
        comb.clasebarcelona[4] = 1;
        comb.nivelbarcelona[4] = 5;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[4] = "topo topo";


        comb.namebarcelona[5] = "maria";
        comb.hpbarcelona[5] = 130;
        comb.manabarcelona[5] = 100;
        comb.manarecbarcelona[5] = 0.8f;
        comb.fuerzabarcelona[5] = 1f;
        comb.rangobarcelona[5] = 1;
        if(inv.datosserial.rangoplay > comb.rangobarcelona[5])
        {
            comb.rangobarcelona[5] = inv.datosserial.rangoplay;
            comb.hpbarcelona[5] = 130* rangoexp;
            comb.manabarcelona[5] = 100* rangoexp;
            comb.manarecbarcelona[5] = 0.8f* rangoexp;
            comb.fuerzabarcelona[5] = 1f* rangoexp;
            comb.rangobarcelona[5] = 1* rangoexp;
        }
        comb.elementobarcelona[5] = "comun rango : "+comb.rangobarcelona[5];
        comb.clasebarcelona[5] = 1;
        comb.nivelbarcelona[5] = 5;
        comb.bichosbarcelona.Add( "");
        comb.bichosbarcelona[5] = "madcat";
    }
}
