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
         * Kod f�r att �ka upp
         * Kod f�r att �ka ner
         * Kod f�r n�r vi ska byta h�ll (kanske en timer)
         */

        transform.position += new Vector3(3, 0, 0);

    }
}
