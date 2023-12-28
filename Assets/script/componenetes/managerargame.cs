using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerargame : MonoBehaviour
{
    public string plat;
    public GameObject arcore;
    public GameObject game3d;
    public GameObject game3dtact;
    // Start is called before the first frame update
    void Start()
    {
        plat = PlayerPrefs.GetString("plat","game3d");
        if(plat == "arcore")
        {
            arcore.SetActive(true);
            game3d.SetActive(false);
            game3dtact.SetActive(false);
        }
        if(plat == "game3d")
        {
            arcore.SetActive(false);
            game3d.SetActive(true);
            game3dtact.SetActive(false);
        }
        if(plat == "game3dt")
        {
            arcore.SetActive(false);
            game3d.SetActive(true);
            game3dtact.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
