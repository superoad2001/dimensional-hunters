using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu2 : MonoBehaviour
{

    public bool cazar = false;
    public bool combate = false;
    public bool atras = false;
    public int tutorial1;
    public int tutorial3;
    public int vez1;
    public int jefe1;

    public Text com;
    public Text tie;
    public Text inve;
    public Text red;
    // Start is called before the first frame update
    void Start()
    {
        tutorial1 = PlayerPrefs.GetInt("tutorial1",0);
        tutorial3 = PlayerPrefs.GetInt("tutorial3",0);
        vez1 = PlayerPrefs.GetInt("escena2",0);
        PlayerPrefs.SetInt("jefe1",0);
        
    }
    public void _cazar()
    {
        cazar = true;
    }
    public void _combate()
    {
        combate = true;
    }
    public void _tienda()
    {
        if(tutorial3 == 1)
        {SceneManager.LoadScene("tienda");}
    }
    public void _atras()
    {
        SceneManager.LoadScene("menu");
    }
    public void _mision()
    {
        SceneManager.LoadScene("mision");
    }
    public void _inventario()
    {
        if(tutorial1 == 1)
        {SceneManager.LoadScene("inventario");}
    }
    public void _red()
    {
        if(tutorial1 == 1)
        {SceneManager.LoadScene("lared");}
    }

    // Update is called once per frame
    void Update()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(combate == true && tutorial1 == 1)
        {
            SceneManager.LoadScene("combatemenu");
        }
        if(cazar  == true)
        {
            SceneManager.LoadScene("zonadecaza");
        }
        if(atras  == true)
        {
            SceneManager.LoadScene("menu");
        }
        combate = false;
        cazar = false;
        atras = false;

        if (inv.indexmax > 0 && tutorial1 == 0)
        {
            tutorial1 = 1;
            PlayerPrefs.SetInt("tutorial1",1);
        }
        if (tutorial1 == 1 && vez1 == 0)
        {
            PlayerPrefs.SetInt("escena2",1);
            SceneManager.LoadScene("escena2");
        }
        if (tutorial1 == 0)
        {
            com.text = "bloqueado";
            tie.text = "bloqueado";
            inve.text = "bloqueado";
            red.text = "bloqueado";
        }
        else if (tutorial3 == 0)
        {
            tie.text = "bloqueado";
        }
    }
}
