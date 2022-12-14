using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    float HitPoints;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        HitPoints = 3; 

    }

    // Update is called once per frame
    void Update()
    {
        if (HitPoints < 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "Enemy");
        {
            HitPoints -= 1;
        }
    }



}
