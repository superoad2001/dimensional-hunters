using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu3 : MonoBehaviour
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
    // Start is called before the first frame update
    void Start()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        rango = inv.datosserial.rangoplay;
    }
    public void _atras()
    {
        SceneManager.LoadScene("menu");
    }
    public void _arcore()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        inv.datosserial.plat = "arcore";
        inv.guardar();
        SceneManager.LoadScene("seleccion2");
    }
    public void _game3d()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        inv.datosserial.plat = "game3d";
        inv.guardar();
        SceneManager.LoadScene("seleccion2");
    }
    public void _game3dt()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        inv.datosserial.plat = "game3dt";
        inv.guardar();
        SceneManager.LoadScene("seleccion2");
    }

    // Update is called once per frame
    void Update()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();


    }
}
