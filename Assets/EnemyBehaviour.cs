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

        transform.position += new Vector3(3, 0, 0);

    }
}
