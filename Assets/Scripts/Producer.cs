using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Producer : MonoBehaviour {
    //a thing that produces stuff.  wow!

    string pName;
    
    public ResourceType output;
    [SerializeField]
    protected int amount;
    protected int index;

    public int time;

    protected Inventory inv;


	// Use this for initialization
	void Start () {
        inv = GameObject.Find("Canvas/Inventory").GetComponent<Inventory>();
        index = inv.findResource(output);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void produce()
    {
        
        inv.addResource(index, amount);
    }

    public IEnumerator wait(int t)
    {
        yield return new WaitForSeconds(t);
    }
}
