using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu2 : MonoBehaviour
{
    public int rango;

    public bool cazar = false;
    public bool combate = false;
    public bool atras = false;
    public int tutorial1;
    public int tutorial3;
    public int vez1;
    public int jefe1;
    public Text rangot;

    public Text com;
    public Text tie;
    public Text inve;
    public Text red;
    public bool rangomost;
    // Start is called before the first frame update
    void Start()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        rango = inv.datosserial.rangoplay;
        if(rangomost == true)
        {rangot.text = ""+rango;}
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void _cazar()
    {
        SceneManager.LoadScene("zonadecaza");
    }
    public void _combate()
    {
        SceneManager.LoadScene("combatemenu");
    }
    public void _tienda()
    {
        SceneManager.LoadScene("tienda");
    }
    public void _rango()
    {
        SceneManager.LoadScene("subirrango");
    }
    public void _almacenamiento()
    {
        SceneManager.LoadScene("subiralmacenamiento");
    }
    public void _atras()
    {
        SceneManager.LoadScene("menu");
    }
    public void _atras2()
    {
        SceneManager.LoadScene("seleccion2");
    }
    public void _mision()
    {
        SceneManager.LoadScene("mision");
    }
    public void _inventario()
    {
        SceneManager.LoadScene("inventario");
    }
    public void _entrar()
    {
        SceneManager.LoadScene("seleccion");
    }
    public void _cinematicas()
    {
        SceneManager.LoadScene("cinematicas");
    }

    // Update is called once per frame
    void Update()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();


    }
}
