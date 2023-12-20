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
    public void _debug()
    {
        PlayerPrefs.SetFloat("limite",9999);
        PlayerPrefs.SetFloat("dinerosave",999999999);
        for(int i = 0;i< 30 ; i++)
        {
            PlayerPrefs.SetFloat("hierba"+i,999);
        }
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
