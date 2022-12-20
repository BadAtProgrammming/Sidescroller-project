using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private GameObject player;

    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    KeyCode dashLeft;
    [SerializeField]
    KeyCode dashRight;
    [SerializeField]
    KeyCode jump;
    [SerializeField]
    KeyCode down;    
    [SerializeField]
    KeyCode right;
    [SerializeField]
    KeyCode left;
    [SerializeField]
    bool inAir;
    [SerializeField]
    float jumpHeight = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.Space)&&inAir== false)
        {
            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            inAir = true;
        }

        if (Input.GetKey(down))
        {
            transform.position += new Vector3(0, -10, 0) * Time.deltaTime;
        }

        if (Input.GetKey(right))
        {
            transform.position += new Vector3(10, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(left))
        {
            transform.position += new Vector3(-10, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKeyDown(dashRight))
        {
            transform.position += new Vector3(10, 0, 0);
        }

        if (Input.GetKeyDown(dashLeft))
        {
            transform.position += new Vector3(-10, 0, 0);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            inAir = false;
            
        }

    }
}
