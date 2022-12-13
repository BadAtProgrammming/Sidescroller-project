using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
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

        if (transform.position.y <= 5)
        {
            transform.position += Time.deltaTime * transform.up * 1;
        }
        if (transform.position.y >= 5)
        {
            transform.position = new Vector3 (-1, -5, 0);
        }

        

    }
}
