using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class esctopo : MonoBehaviour
{
    public float temp;

    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
        
    }
    public void saltar()
    {
        SceneManager.LoadScene("topo");
    }
    // Update is called once per frame
    void Update()
    {
        temp += 1 * Time.deltaTime;
        if (temp >= 25)
        {SceneManager.LoadScene("topo");}
    }
 

    
}
