using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class managerdeentr : MonoBehaviour
{
    public bool comienzo;
    public Text cuenta;
    public float temp = 0;
    public float temp6 = 0;
    public int cue = 3;

    public float nivel;
    public float nivelg;

    public GameObject cuenta_;
    public GameObject combate_;

    public AudioSource pip;

    public bool inicio = false;
    public float iniciotem = 0;
    public GameObject negro;
    public int o;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        heroentr heroe = UnityEngine.Object.FindObjectOfType<heroentr>();
        if (iniciotem > 2 && inicio == false)
        {
            inicio = true;
            negro.gameObject.SetActive(false);
            temp = 0;

        }
        if(iniciotem < 15)
        {iniciotem += 1 * Time.deltaTime;}
        if (comienzo == false && cue == 3 && inicio == true)
        {
            cuenta.text = "3";
            cue = 2;
        }
        if (comienzo == false && cue == 2 && temp > 2)
        {
            cuenta.text = "2";
            cue = 1;
            temp = 0;
            pip.Play();
        }
        if (comienzo == false && cue == 1 && temp > 2)
        {
            cuenta.text = "1";
            cue = 0;
            temp = 0;
            pip.Play();
        }
        if (comienzo == false && cue == 0 && temp > 2)
        {
            cuenta_.gameObject.SetActive(false);
            combate_.gameObject.SetActive(true);
            comienzo = true;
            temp = 0;
            pip.Play();
        }
        if (heroe.hp <= 0)
        {
            cuenta_.gameObject.SetActive(true);
            combate_.gameObject.SetActive(false);
            cuenta.text = "perdiste";
            if (temp6 < 15)
            {temp6 += 1 * Time.deltaTime;}
            if(temp > 5)
            {SceneManager.LoadScene("menu");}
        }
        if (temp < 15)
        {temp += 1 * Time.deltaTime;}
        
        
    }
   
}
