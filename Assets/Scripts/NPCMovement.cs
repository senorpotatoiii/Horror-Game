using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour{
    Rigidbody2D rb;
    [SerializeField] float timeBetweenMove = 2f;
    [SerializeField] float varienceTimeMove = 0.2f;
    [SerializeField] float minTimeMove = 1f;
    [SerializeField] bool moving = false;
    [SerializeField] Vector2 currentSpeed;

    // Start is called before the first frame update
    void Start(){
        currentSpeed = new Vector2(0f, 0f);
        rb = GetComponent<Rigidbody2D>();
    }

    public void TestMove()
    {
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        for (int i = 0; i < 3; i++)
        {
            currentSpeed.x = Random.Range(-1.0f, 1.0f) * 2;
            currentSpeed.y = Random.Range(-1.0f, 1.0f) * 2;
            moving = true;
            rb.velocity = currentSpeed;
            moving = false;
            yield return new WaitForSeconds(timeBetweenMove);
        }
        Debug.Log("Test NPC Move");
    }
}
