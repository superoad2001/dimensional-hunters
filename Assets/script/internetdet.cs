using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class internetdet : MonoBehaviour
{
    public float load;
    // Start is called before the first frame update

    public bool Connected_Internet;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(Application.internetReachability == NetworkReachability.NotReachable)
        {
            Connected_Internet = false;
        }
        else
        {
            Connected_Internet = true;
        }
        if(Connected_Internet == false)
        {
            SceneManager.LoadScene("menu");
            Destroy(this.gameObject);
        }
    }
}
