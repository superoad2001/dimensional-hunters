using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemigoentr : MonoBehaviour
{


    public DynamicTextData textDatadano;

    public GameObject ev1;
    public float hp;
    public float temp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp < 60)
        {hp += 6 *Time.deltaTime;}
        if (temp < 15)
        {temp+= 1 * Time.deltaTime;}
    }
    public void OnTriggerEnter(Collider col)
    {
        heroentr heroe = UnityEngine.Object.FindObjectOfType<heroentr>();
        
        if (col.gameObject.tag == "Player" && temp > 5)
        {

            int ataqued = (int)heroe.ataque;

            DynamicTextManager dtext = UnityEngine.Object.FindObjectOfType<DynamicTextManager>(); 
            dtext.CreateText(ev1.transform.position,"-"+(int)(ataqued),textDatadano);
                
            hp -= heroe.ataque;
            temp = 0;

        }
    }
}
