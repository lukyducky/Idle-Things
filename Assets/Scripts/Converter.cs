using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Converter :  Producer {
    //a thing that takes resources & returns a new resource!
    
    public ResourceType[] input = new ResourceType[2];

    int numOfInputs = 2;
    int[] inIndex = new int[2];
    public int[] inAmounts = new int[2];

    

	// Use this for initialization
	void Start () {
        inv = GameObject.Find("Canvas/Inventory").GetComponent<Inventory>();
        index = inv.findResource(output);
        for (int i = 0; i < 2; i++)
        {
            inIndex[i] = inv.findResource(input[i]);
            Debug.Log("inv index of converter " + inIndex[i]);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void convert()
    {
        Debug.Log("Converting stuff");
        if (numOfInputs != 1)
        {
            for (int i = 0; i < 2; i++)
            {
                Debug.Log("Amount " + inAmounts[i] +" |Index " + inIndex[i]);
                inv.removeResource(inIndex[i], inAmounts[i]);
                Debug.Log("Convert index: " + i);

            }
        }
        else
        {
            inv.removeResource(inIndex[0], inAmounts[0]);
            
        }
        inv.addResource(index, amount);
        Debug.Log("Lets add some resources: index" + index + " | amount " + amount);

    }

}
