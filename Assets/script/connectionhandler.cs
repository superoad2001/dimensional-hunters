using Unity.Netcode;
using Unity.Netcode.Transports.UNET;
using UnityEngine;

public class connectionhandler : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NetworkManager.Singleton.ConnectionApprovalCallback += ApprovalCheck;
    }
    private void ApprovalCheck(NetworkManager.ConnectionApprovalRequest request, NetworkManager.ConnectionApprovalResponse response)
    {
        if(IsOwner)
        {
        Debug.Log(message:"Conexion Aprobada");
        response.Approved = true;
        if(NetworkManager.Singleton.ConnectedClients.Count >= 2)
        {
            response.Approved = false;
            response.Reason = "Este server esta ocupado";
        }
        response.Pending = false;
        }
    }
}
