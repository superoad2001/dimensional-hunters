using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigoentr : MonoBehaviour
{
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
                
            hp -= heroe.ataque;
            temp = 0;

        }
    }
}
