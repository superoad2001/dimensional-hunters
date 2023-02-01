using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inicio : MonoBehaviour
{

    public bool iniciar = false;
    public int vez1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        vez1 = PlayerPrefs.GetInt("nuevapartida",0);
    }
    public void _iniciar()
    {
        iniciar = true;
    }
    public void _borrar()
    {
        SceneManager.LoadScene("borrar");
    }
    // Update is called once per frame
    void Update()
    {

        if(iniciar == true && vez1 == 0)
        {
            SceneManager.LoadScene("intro");
            PlayerPrefs.SetInt("nuevapartida",1);
        }
        else if(iniciar == true && vez1 == 1)
        {SceneManager.LoadScene("seleccion");}
        iniciar = false;
    }
}
