using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

//https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/mini-legion-grunt-pbr-hp-polyart-98187
public class AnimPrefab : NetworkBehaviour {

    [SerializeField]
    private float speed = 10; //vitesse de déplacement

    [SerializeField]
    private Vector3 rotVector = new Vector3 (0, 20, 0); //vitesse de rotation

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private NetworkAnimator netAnim;

    void Update () {
        if (Input.GetMouseButton (2) && this.isLocalPlayer) {
            Debug.Log ("Pressed left click: attack");
            //animator.SetTrigger ("hit"); // not working in sync

            netAnim.SetTrigger ("hit");
        }
    }

    void FixedUpdate () {
        if (this.isLocalPlayer) {
            float rot = Input.GetAxis ("Horizontal"); // rot
            float move = Input.GetAxis ("Vertical"); //move

            /*if (move != 0f) {
                animator.SetTrigger ("run");
            } else {
                animator.SetTrigger ("stop");
            }*/

            animator.SetFloat("move", move);

            GetComponent<Rigidbody> ().velocity = transform.forward * move * speed; //new Vector3(0.0f,0.0f,move * speed); // uniquement sur axe Z
            this.transform.Rotate (rotVector * rot);
        }
    }
}