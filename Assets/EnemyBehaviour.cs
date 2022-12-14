using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField, Range(0.1f, 100)]
    float enemySpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Kod f�r att �ka upp
         * Kod f�r att �ka ner
         * Kod f�r n�r vi ska byta h�ll (kanske en timer)
         */
      
        
        
     transform.position += Time.deltaTime * transform.up * enemySpeed;
        
        
        
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            transform.position = new Vector3(transform.position.x, -15, 0); 
        }
    }
    







}

