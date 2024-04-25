using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class desconexionmenu : MonoBehaviour
{
    public float temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(temp > 5f)
        {
            SceneManager.LoadScene("combatemenumulti");
        }
        temp += 1 * Time.deltaTime;
    }
}
