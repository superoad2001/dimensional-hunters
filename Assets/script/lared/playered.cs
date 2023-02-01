using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playered : MonoBehaviour
{
    public bool adelanteb = false;
    public void adelante()
    {
        adelanteb = true;
    }
    public void noadelante()
    {
        adelanteb = false;
    }

    public bool interactuar = false;
    public void _interactuar()
    {
        interactuar = true;
    }
    public void _nointeractuar()
    {
        interactuar = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (adelanteb == true)
        {
            transform.position += transform.forward * 4 * Time.deltaTime;
        }
    }
    public void OnCollisionStay(Collision col) 
    {   if (interactuar == true)
        {
            if (col.gameObject.tag == "lared")
            {   
                 SceneManager.LoadScene("bichored");
            }
            if (col.gameObject.tag == "zonadecaza")
            {
                SceneManager.LoadScene("zonadecaza");
            }
            if (col.gameObject.tag == "zonadecombate")
            {
                SceneManager.LoadScene("combatemenu");
            }
            if (col.gameObject.tag == "salirdered")
            {
                SceneManager.LoadScene("seleccion");
            }
            if (col.gameObject.tag == "salirmundored")
            {
                SceneManager.LoadScene("lared");
            }
        }
    }
}
