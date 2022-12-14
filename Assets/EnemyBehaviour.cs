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
         * Kod för att åka upp
         * Kod för att åka ner
         * Kod för när vi ska byta håll (kanske en timer)
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

