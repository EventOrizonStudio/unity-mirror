using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
 
public class MovePlayer : NetworkBehaviour 
{
    [SerializeField]
    private float speed; //vitesse de déplacement
 
    void FixedUpdate () 
    {
        if(this.isLocalPlayer) 
        {
            float hMove = Input.GetAxis("Horizontal"); 
            GetComponent<Rigidbody>().velocity = new Vector3(hMove * speed, 0.0f,0.0f); // uniquement sur axe X
        }
    }
}
