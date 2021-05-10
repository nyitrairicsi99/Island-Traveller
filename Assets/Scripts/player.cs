using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    int stick = 0;
    int stone = 0;
    int logs = 0;
    bool hasAxe = false;
    bool boatUsable = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PickedUpStick()
    {
        stick++;
        if (stone > 1 && stick > 2)
        {
            hasAxe = true;
        }
    }

    void PickedUpStone()
    {
        stone++;
        if (stone>1 && stick>2)
        {
            hasAxe = true;
        }
    }

    void CuttedTree()
    {
        logs+=4;
        if (logs>=8)
        {
            boatUsable = true;
        }
    }
}
