using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "SimpleFirstPersonWalker")
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<player>().PickedUpStone();
        }

    }
}
