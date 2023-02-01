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
       if(transform.position == player.transform.position)
       {
        //la bala es destruida a en 0.5 segundos si toca al jugador
        if (temp > 0.5f)
        {UnityEngine.Object.Destroy(this.gameObject);}
        temp += 1 * Time.deltaTime;
       }
    }
}
