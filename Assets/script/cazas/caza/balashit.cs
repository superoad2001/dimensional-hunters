using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balashit : MonoBehaviour
{
    //cuando se genera la bala va en direccion al jugador


    public GameObject player;
    public float speed;
    public Vector3 dir;
    public float temp;
    void Start()
    {
        shitene enemigo = UnityEngine.Object.FindObjectOfType<shitene>();
        player = enemigo.player;
        dir = player.transform.position;
    }

    public float BalaVelocidad;
    void Update()
    {
       
       transform.position = Vector3.MoveTowards(transform.position,dir,speed * Time.deltaTime);
       if(transform.position == dir)
       {
        UnityEngine.Object.Destroy(this.gameObject);
       }
    }
}
