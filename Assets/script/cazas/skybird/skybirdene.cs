using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skybirdene : MonoBehaviour
{   

    public Image barrahp;
    public float hp = 5;
    public float hpmax = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        disparoskybird manager = UnityEngine.Object.FindObjectOfType<disparoskybird>();
        barrahp.fillAmount = hp/hpmax;
        if(hp <= 0)
        { manager.enemigos++; UnityEngine.Object.Destroy(this.gameObject);}
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bala")
		{
			hp -= 1;
            UnityEngine.Object.Destroy(col.gameObject);
		}
    }
    
}
