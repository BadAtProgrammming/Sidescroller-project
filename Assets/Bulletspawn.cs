using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletspawn : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    [SerializeField]
    Transform spawnpoint;

    [SerializeField]
    KeyCode Space;

    float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer < 0.25f)
        {

        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(bullet, spawnpoint.position, Quaternion.identity);
            timer = 0;
        }




    }
}
