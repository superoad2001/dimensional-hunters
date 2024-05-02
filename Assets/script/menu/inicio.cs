using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class inicio : MonoBehaviour
{

    public bool iniciar = false;
    public int vez1 = 0;

    public Text version;
    // Start is called before the first frame update
    void Start()
    {
        version.text = "version "+ Application.version;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
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

        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        inv.datosserial.limite = 9999;
        inv.datosserial.dinero = 999999999;
        for(int i = 0;i< 30 ; i++)
        {
            inv.datosserial.tipohierba[i] = 999;
        }

        
                inv.datosserial.name.Add("prueba");
                inv.datosserial.hp.Add(9999);
                inv.datosserial.mana.Add(9999);
                inv.datosserial.manarec.Add(1);
                inv.datosserial.fuerza.Add(1);
                inv.datosserial.elemento.Add("comun rango: 1");
                inv.datosserial.nivel.Add(1);
                inv.datosserial.rango.Add(1);
                inv.datosserial.clase.Add(1);
                inv.datosserial.exp.Add(0);
                inv.datosserial.bichosmios.Add("madcat");
                inv.datosserial.indexmax = inv.datosserial.name.Count;
                inv.guardar();
    }
    // Update is called once per frame
    void Update()
    {

        if(iniciar == true)
        {
            SceneManager.LoadScene("seleccion3");
            
        }
    }
}
