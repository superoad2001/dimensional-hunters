using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colcaza : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider col)
    {
        shitene shitene = UnityEngine.Object.FindObjectOfType<shitene>();
        if (col.gameObject.tag == "bala")
		{
            if((shitene.fuerzajug-shitene.defensa) >= 5)
			{shitene.hp = shitene.hp - (shitene.fuerzajug - shitene.defensa);}
            else if((shitene.fuerzajug-shitene.defensa) < 5)
            {shitene.hp = shitene.hp - 5;}
            UnityEngine.Object.Destroy(col.gameObject);
		}
    }
}
