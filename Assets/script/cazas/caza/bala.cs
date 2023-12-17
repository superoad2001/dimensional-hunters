using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    //la bala del jugador va en direccion z hacia adelante cuado la disparas asi que va delante de ti
    void Start()
    {
        
    }

    public float BalaVelocidad;
    void Update()
    {
        transform.position += transform.forward *BalaVelocidad * Time.deltaTime;
    }
}
