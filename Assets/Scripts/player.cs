using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private int stick = 0;
    private int stone = 0;
    private int logs = 0;
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
        invText.text = "Összegyûjtött anyagok:\nBot: " + (stick) + "\nKõ: " + (stone) + "\nRönk: " + (logs) + "";
    }

    public void PickedUpStick()
    {
        stick++;
        if (stone > 1 && stick > 2)
        {
            hasAxe = true;
        }
    }

    public void PickedUpStone()
    {
        stone++;
        if (stone>1 && stick>2)
        {
            hasAxe = true;
        }
    }

    public void CuttedTree()
    {
        logs+=4;
        if (logs>=8)
        {
            boatUsable = true;
        }
    }
}
