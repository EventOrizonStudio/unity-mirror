using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

//https://github.com/vis2k/Mirror/blob/master/Assets/Mirror/Runtime/NetworkBehaviour.cs/#L686
public class callbacks : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void OnStartServer() {
        /*NetworkMessage test = new NetworkMessage();
        test.chosenClass = "grunt2";
 
        ClientScene.AddPlayer(conn, 0, test);*/

        Debug.Log("StartServer");
    }

    /*public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId, NetworkReader extraMessageReader) {

      public override void OnServerAddPlayer(NetworkConnection conn){
        NetworkMessage message = extraMessageReader.ReadMessage< NetworkMessage>();
        int selectedClass = message.chosenClass;
        Debug.Log("server add with message "+ selectedClass);
 
        if (selectedClass == 0) {
            GameObject player = Instantiate(Resources.Load("Characters/A", typeof(GameObject))) as GameObject;
            NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
        }
 
        if (selectedClass == 1) {
            GameObject player = Instantiate(Resources.Load("Characters/B", typeof(GameObject))) as GameObject;
            NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
        }
    }*/
}
