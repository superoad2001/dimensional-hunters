using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class interfazentr : MonoBehaviour
{
   public ARSession arSession;
    public Image barrahp;
    public Image barrahpene;
    public Image barrama;

    public Image barrat;

    public Image barraatb;


    public string com;

    public bool salir = false;
    public GameObject cam;
    public float iniciotem = 0;
    public string plat;
    void Start()
    {
        plat = PlayerPrefs.GetString("plat","game3d");
        if(plat == "arcore")
        {
            cam.transform.position = new Vector3(0,0,0f);
        }
    }
    public void _salir()
    {
        salir = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(plat == "arcore")
        {
            if (iniciotem > 0 && iniciotem < 1)
            {
                arSession.Reset ();

            }
        }

        if(salir == true)
        {SceneManager.LoadScene("seleccion");}
        salir = false;
        heroentr heroe = UnityEngine.Object.FindObjectOfType<heroentr>();
        enemigoentr enemigo = UnityEngine.Object.FindObjectOfType<enemigoentr>();

        barrahp.fillAmount = heroe.hp/heroe.hpmax;
        barrama.fillAmount = heroe.mana/heroe.manamax;
        barrat.fillAmount = heroe.turbobar/100;
        barraatb.fillAmount = heroe.atb/100;

        barrahpene.fillAmount = enemigo.hp/60;

        if(iniciotem < 15)
        {iniciotem += 1 * Time.deltaTime;}
    }
}
