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
       SceneManager.LoadScene("seleccion2"); 
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
