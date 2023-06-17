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
        SceneManager.LoadScene("inventario");
    }

    // Update is called once per frame
    void Update()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        if(combate == true )
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


    }
}
