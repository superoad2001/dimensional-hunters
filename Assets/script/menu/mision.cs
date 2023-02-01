using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mision : MonoBehaviour
{
    public int tutorial1;
    public int tutorial3;
    public Text misiont;
    public void _atras()
    {
       SceneManager.LoadScene("seleccion"); 
    }
    // Start is called before the first frame update
    void Start()
    {
        tutorial1 = PlayerPrefs.GetInt("tutorial1",0);
        tutorial3 = PlayerPrefs.GetInt("tutorial3",0);
        if (tutorial1 == 0)
        {misiont.text = " objetivo 1 : caza 2 criaturas";}
        else if (tutorial3 == 0)
        {misiont.text = "objetivo 2 : vence a enric en combate";}
        else{misiont.text = "fin de la demo";}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
