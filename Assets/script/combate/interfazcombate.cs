using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class interfazcombate : MonoBehaviour
{
    public GameObject arSession;
    public Image barrahp;
    public Image barrahpene;
    public Image barrama;
    public float iniciotem = 0;
    public Image barramaene;
    public Image barrat;
    public Image barratene;
    public Image barraatb;
    public Image barraatbene;


    public string com;

    public bool salir = false;

    public GameObject cam;
    public string plat;
    void Awake()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        plat = inv.datosserial.plat;
        if(plat == "arcore")
        {
            
        }

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
        hero heroe = UnityEngine.Object.FindObjectOfType<hero>();
        enemigo enemigo = UnityEngine.Object.FindObjectOfType<enemigo>();

        barrahp.fillAmount = heroe.hp/heroe.hpmax;
        barrama.fillAmount = heroe.mana/heroe.manamax;
        barrat.fillAmount = heroe.turbobar/100;
        barraatb.fillAmount = heroe.atb/100;

        barrahpene.fillAmount = enemigo.hp/enemigo.hpmax;
        barramaene.fillAmount = enemigo.mana/enemigo.manamax;
        barratene.fillAmount = enemigo.turbobar/100;
        barraatbene.fillAmount = enemigo.atb/100;

        if(iniciotem < 15)
        {iniciotem += 1 * Time.deltaTime;}
    }
}
