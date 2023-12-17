using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class destroynm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NetworkManager manager = UnityEngine.Object.FindObjectOfType<NetworkManager>();
        Destroy(manager.gameObject);
    }
}
