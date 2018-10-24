using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    //class to hold all of the player's resources.
    
    public InvResource[] inventory;


    
    public InvResource getResources(int index, int amount)
    {
        InvResource output = inventory[index];
        inventory[index].remove(amount);
        output.set(amount);
        return output;
    }

    public void removeResource(int index, int amount)
    {
        inventory[index].remove(amount);
    }


    public void addResource(int index, int amount)
    {
        inventory[index].add(amount);
    }

    public int findResource(ResourceType findMe) //returns the index of the inputted ResourceType, if it exists.
    {
        int index = 0;
        for (index = 0; index < inventory.Length; index ++)
        {
            if (inventory[index].getResource() == findMe)
            {
                Debug.Log("The resource, " + findMe + ", was found at " + index);
                return index;
            }
            
        }
        Debug.Log("did not find Resource" + findMe);
        return 0;
    }

    public int getCount(int index) { return inventory[index].getCount(); }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
