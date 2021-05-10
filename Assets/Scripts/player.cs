using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private int stick = 0;
    private int stone = 0;
    private int logs = 0;
    private int money = 0;
    private bool hasAxe = false;
    private bool boatUsable = false;
    public TextMesh invText;


    // Start is called before the first frame update
    void Start()
    {
        invText = GameObject.Find("InventoryText").GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (boatUsable){
            invText.text = "A hajóba szállva elhagyhatod a szigetet!";
        } else if (hasAxe)
        {
            invText.text = "Összegyûjtött anyagok:\nRönk: " + (logs) + "/1";
        } else
        {
            invText.text = "Összegyûjtött anyagok:\nBot: " + (stick) + "/2\nKõ: " + (stone) + "/1";
        }
    }

    public void PickedUpStick()
    {
        stick++;
        if (stone >= 1 && stick >= 2)
        {
            hasAxe = true;
        }
    }

    public void PickedUpStone()
    {
        stone++;
        if (stone>=1 && stick>=2)
        {
            hasAxe = true;
        }
    }

    public bool PickedUpLog()
    {
        if (hasAxe)
        {
            logs++;
            if (logs >= 1)
            {
                boatUsable = true;
            }
            return true;
        }
        return false;
    }

    public void giveMoney(int amount)
    {
        money += amount;
    }
}
