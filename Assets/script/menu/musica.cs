using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musica : MonoBehaviour
{

    public int musicaid = 1;
    public musicaidzona musicaidzona;
    public musica musica2;
    private void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        if(GameObject.FindGameObjectsWithTag("musica").Length > 1)
        {
            musicaidzona = UnityEngine.Object.FindObjectOfType<musicaidzona>();
            musica2 = UnityEngine.Object.FindObjectOfType<musica>();
            if(musica2.musicaid != musicaidzona.musicaid)
            {
                Destroy(musica2.gameObject);
            }
            if(musica2.musicaid == musicaidzona.musicaid)
            {
                Destroy(this.gameObject);
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
