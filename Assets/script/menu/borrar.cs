using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class borrar : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
    }
    public void _si()
    {
        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        inv.borrar_data();
        SceneManager.LoadScene("menu");
    }
    public void _no()
    {
        SceneManager.LoadScene("menu");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
