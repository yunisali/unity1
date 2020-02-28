using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionScript : MonoBehaviour
{
    public Transform explosion;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    public void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag.Equals("player"))
        {
            Instantiate(explosion, transform.position, explosion.rotation);
            Destroy(gameObject);

        }
    }
    }
