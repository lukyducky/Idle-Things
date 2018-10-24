using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvResource : MonoBehaviour {
    //holds a resource and a number.  used for Inventory & other applications.

    [SerializeField]
    ResourceType resource;
    int count;


    public int getCount() { return count; }

    public void add(int i)
    {
        count += i;
    }

    public void remove(int i)
    {
        Debug.Log("Attempting to remove " + resource + " " + i);
        if (count >= i)
        {
            Debug.Log("before removing some shit hell yeah " + resource + " | " + count);
            count -= i;

            Debug.Log("after removing some shit hell yeah " + resource + " | " + count);
        }
        else
        {
            Debug.Log("not enough" + resource);
        }
        
    }

    public void set(int i)
    { count = i; }
    
    public ResourceType getResource() { return resource; }

    
	
}

public enum ResourceType {
    Red,
    Green,
    Blue,
    Purple,
    Gray,

}
