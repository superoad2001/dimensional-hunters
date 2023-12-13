using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shitene : MonoBehaviour
{   

    public Image barrahp;
    public Image barrahp2;
    public float hp = 100;
    public float hpmax = 100;
    public float ataquetemp = 3;
    public float temp;
    public Quaternion rota;
    public GameObject BalaInicio;
	public GameObject BalaPrefab;
    public GameObject player;
    public string bicho = "madcat";
    public GameObject madcat;
    public GameObject skybird;
    public GameObject shitfloor;
    public GameObject topo;
    // Start is called before the first frame update
    void Start()
    {
        if (bicho == "madcat")
        {
            hpmax = 100;
            hp = 100;
            ataquetemp = 3;
        }
        mostrar();
    }
    // Update is called once per frame
    void Update()
    {
        disparoshitfloor manager = UnityEngine.Object.FindObjectOfType<disparoshitfloor>();
        if(manager.comienzo == true)
        {
            barrahp.fillAmount = hp/hpmax;
            barrahp2.fillAmount = hp/hpmax;
            if(hp <= 0)
            {UnityEngine.Object.Destroy(this.gameObject);}
            if(temp > ataquetemp)
            {
                rota = BalaInicio.transform.rotation;
                GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position,rota) as GameObject;
                Debug.Log(BalaTemporal.transform.eulerAngles);

                Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

                

                Destroy(BalaTemporal, 5.0f);
                temp = 0;



            }
            if(temp < 15)
            {temp += 1 * Time.deltaTime;}
        }
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bala")
		{
			hp -= 5;
            UnityEngine.Object.Destroy(col.gameObject);
		}
    }
    public void mostrar()
    {
        if(bicho == "madcat")
        {
            madcat.SetActive(true);
        }
        if(bicho == "skybird")
        {
            skybird.SetActive(true);
        }
        if(bicho == "shitfloor")
        {
            shitfloor.SetActive(true);
        }
        if(bicho == "topo")
        {
            topo.SetActive(true);
        }
    }   
    
}
