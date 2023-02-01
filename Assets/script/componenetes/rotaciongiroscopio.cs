using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotaciongiroscopio : MonoBehaviour
{
    private bool gyroenabled;
    private Gyroscope gyro;

    private GameObject cameracontainer;
    private Quaternion rot;
    void Start()
    {


        cameracontainer = new GameObject("camera container");
        cameracontainer.transform.position = transform.position;
        transform.SetParent(cameracontainer.transform);

        gyroenabled = Enablegyro();


    }
    private bool Enablegyro()
    {
        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
           

            cameracontainer.transform.rotation = Quaternion.Euler(90f,90f,0);
            rot = new Quaternion(0,0,1,0);
            
             return true;
        }

        return false;
    }
    private void Update()
    {
       if(gyroenabled)
       {
        transform.localRotation = gyro.attitude * rot;
       }
    }
}
