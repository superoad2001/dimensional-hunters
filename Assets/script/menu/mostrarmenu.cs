using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mostrarmenu : MonoBehaviour
{

    public GameObject madcat1;
    public GameObject shitfloor;
    public GameObject topo;
    public GameObject skybird;

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

    public List<int> lista = new List<int>();
    
    // Start is called before the first frame update
    void Awake()
    {
        for(int i = 0;i< 10 ; i++)
        {
            int cont = lista.Count;
            int r = Random.Range(0,40);
            if(i == 0)
            {lista.Add(r);}
            for(int e = 0;e < cont && i != 0; e++)
            {
                Debug.Log(i+":"+lista.Count);
                Debug.Log(e);
                if(r == lista[e])
                {
                    i--;
                    e = cont;
                }
                else if(e == (lista.Count-1))
                {lista.Add(r);}
            }
            Debug.Log(i+":"+lista[i]);
        }
        for(int i = 0;i< 10 ; i++)
        {
            carga(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void carga(int t)
    {
        if(lista[t] == 0)
        {
            madcat1.SetActive(true);
        }
        if(lista[t] == 1)
        {
            shitfloor.SetActive(true);
        }
        if(lista[t] == 2)
        {
            topo.SetActive(true);
        }
        if(lista[t] == 3)
        {
            skybird.SetActive(true);
        }
        if(lista[t] == 4)
        {
            ghost.SetActive(true);
        }
        if(lista[t] == 5)
        {
            algosaurio.SetActive(true);
        }
        if(lista[t] == 6)
        {
            bigfat.SetActive(true);
        }
        if(lista[t] == 7)
        {
            cazafantasmas.SetActive(true);
        }
        if(lista[t] == 8)
        {
            darkknight.SetActive(true);
        }
        if(lista[t] == 9)
        {
            antidog.SetActive(true);
        }


        if(lista[t] == 10)
        {
            pinguino.SetActive(true);
        }
        if(lista[t] == 11)
        {
            craneovil.SetActive(true);
        }
        if(lista[t] == 12)
        {
            dogtable.SetActive(true);
        }
        if(lista[t] == 13)
        {
            bee.SetActive(true);
        }
        if(lista[t] == 14)
        {
            elephant.SetActive(true);
        }
        if(lista[t] == 15)
        {
            flyera.SetActive(true);
        }
        if(lista[t] == 16)
        {
            friend.SetActive(true);
        }
        if(lista[t] == 17)
        {
            gunman.SetActive(true);
        }
        if(lista[t] == 18)
        {
            flanerio.SetActive(true);
        }
        if(lista[t] == 19)
        {
            fenix.SetActive(true);
        }

        if(lista[t] == 20)
        {
            kingdragon.SetActive(true);
        }
        if(lista[t] == 21)
        {
            heavydevil.SetActive(true);
        }
        if(lista[t] == 22)
        {
            kraken.SetActive(true);
        }
        if(lista[t] == 23)
        {
            lizardo.SetActive(true);
        }
        if(lista[t] == 24)
        {
            livedish.SetActive(true);
        }
        if(lista[t] == 25)
        {
            pesadilla.SetActive(true);
        }
        if(lista[t] == 26)
        {
            mirror.SetActive(true);
        }
        if(lista[t] == 27)
        {
            rabmon.SetActive(true);
        }
        if(lista[t] == 28)
        {
            ant.SetActive(true);
        }
        if(lista[t] == 29)
        {
            kingslug.SetActive(true);
        }
        if(lista[t] == 30)
        {
            rosedragon.SetActive(true);
        }
        if(lista[t] == 31)
        {
            sharkman.SetActive(true);
        }
        if(lista[t] == 32)
        {
            pollovion.SetActive(true);
        }
        if(lista[t] == 33)
        {
            trepillo.SetActive(true);
        }
        if(lista[t] == 34)
        {
            roboerto.SetActive(true);
        }
        if(lista[t] == 35)
        {
            tufo.SetActive(true);
        }
        if(lista[t] == 36)
        {
            trashrat.SetActive(true);
        }
        if(lista[t] == 37)
        {
            spider.SetActive(true);
        }
        if(lista[t] == 38)
        {
            vivodado.SetActive(true);
        }
        if(lista[t] == 39)
        {
            dragonron.SetActive(true);
        }

    }
}
