using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class interfazcombatemulti : MonoBehaviour
{
   public ARSession arSession;
    public Image barrahp;
    public Image barrama;
    public Image barrat;
    public Image barraatb;

    public Image barrahp2;
    public Image barrama2;
    public Image barrat2;
    public Image barraatb2;
    public heromulti heroe;
    public heromulti2 heroe2;

    public Text uitext;
    public string com;

    public bool salir = false;
    void Start()
    {
        arSession.Reset();
    }
    public void _salir()
    {
        salir = true;
    }
    // Update is called once per frame
    void Update()
    {

        if(salir == true)
        {SceneManager.LoadScene("seleccion");}
        salir = false;

        barrahp.fillAmount = heroe.hp/heroe.hpmax;
        barrama.fillAmount = heroe.mana/heroe.manamax;
        barrat.fillAmount = heroe.turbobar/100;
        barraatb.fillAmount = heroe.atb/100;

        barrahp2.fillAmount = heroe2.hp/heroe.hpmax;
        barrama2.fillAmount = heroe2.mana/heroe.manamax;
        barrat2.fillAmount = heroe2.turbobar/100;
        barraatb2.fillAmount = heroe2.atb/100;

        if(uitext.text.Length > 27)
        {uitext.text = com;}
        com = uitext.text;
    }
}
