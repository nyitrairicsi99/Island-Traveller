using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "SimpleFirstPersonWalker")
        {
            if (collision.gameObject.GetComponent<player>().PickedUpLog())
            {
                Destroy(this.gameObject);
            }
            
        }

    }
}
