using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField, Range(0.1f, 100)]
    float enemySpeed = 5;
    [SerializeField, Range(-100, 100)]
    float TeleportY = -15;
    [SerializeField]
    float HitPoints;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Kod f?r att ?ka upp
         * Kod f?r att ?ka ner
         * Kod f?r n?r vi ska byta h?ll (kanske en timer)
         */
      
        
        
     transform.position += Time.deltaTime * transform.up * enemySpeed;

        if (HitPoints < 0)
        {
            Destroy(this.gameObject);
        }



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall") 
        {
            transform.position = new Vector3(transform.position.x, -TeleportY, 0); 

        
        }
        if (collision.tag == "Bullet")
        {
            HitPoints -= 1;
        }



    }

    







}

