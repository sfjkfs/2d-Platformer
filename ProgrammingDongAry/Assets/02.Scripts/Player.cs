using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    RaycastHit2D Hit;
    float moveSpeed = 10;
    public LayerMask groundCheck;
    public LayerMask monsterLayer;
    public float jumpforce;
    public bool isPlayerWatchingRignt;
    public SpriteRenderer IMG;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        IMG = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), rb.velocity.y);
        if (Physics2D.Raycast(transform.position, Vector2.down,1.1f,groundCheck)&& Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up*jumpforce, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.C))
        {
            if(Physics2D.Raycast(transform.position,Vector2.right, 2, monsterLayer)&& isPlayerWatchingRignt)
            {
                Debug.DrawRay(transform.position, Vector2.right * 2, Color.red);
            }
            if (Physics2D.Raycast(transform.position, Vector2.left, 2, monsterLayer)&& !isPlayerWatchingRignt)
            {
                Debug.DrawRay(transform.position, Vector2.left * 2, Color.red);
            }
        }
        if (Input.GetAxis("Horizontal")> 0)
        {
            isPlayerWatchingRignt = true;
            IMG.flipX = false;
        }
        if(Input.GetAxis("Horizontal")< 0)
        {
            isPlayerWatchingRignt = false;
            IMG.flipX = true;
        }
    }
}
