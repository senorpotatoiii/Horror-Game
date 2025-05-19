using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NPCMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;

    Rigidbody2D rb;

    public void SetMovementSpeed(float moveSpeed){
        this.moveSpeed = moveSpeed;
    }

    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void MovetoLocation(){
        // rb.velocity = V2.normalized * moveSpeed;
        Debug.Log("Test NPC Move Call");
    }


}
