using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class playermov : MonoBehaviour
{

    [SerializeField]private int playerID = 0;
	[SerializeField]private Player player;
    public float velocidad = 4;
    private float cameraverticalangle;
	public Vector3 rotationinput;
    public Transform camara;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        player = ReInput.players.GetPlayer(playerID);
        this._rb = base.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = transform.TransformDirection(new Vector3 (player.GetAxis("lhorizontal") * velocidad, _rb.velocity.y, player.GetAxis("lvertical") * velocidad));
        
        if(player.GetAxis("lhorizontal") == 0f && player.GetAxis("lvertical") == 0f )
        {
            _rb.velocity = new Vector3 (0, _rb.velocity.y, 0);
        }


        rotationinput.x = player.GetAxis("rhorizontal") * 80 * Time.deltaTime;
        rotationinput.y = player.GetAxis("rvertical") * 80 * Time.deltaTime;

        cameraverticalangle +=  rotationinput.y;
        cameraverticalangle = Mathf.Clamp(cameraverticalangle, -50 , 20);
        
        transform.Rotate(Vector3.up * rotationinput.x);
        camara.localRotation = Quaternion.Euler(-cameraverticalangle,0,0);

        
    }
}
