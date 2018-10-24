using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInvItem : MonoBehaviour {

    [SerializeField]
    ResourceType res;
    Inventory inv;
    int index;

    Text text;
    Text count;



	// Use this for initialization
	void Start () {
        text = transform.Find("ItemName").GetComponent<Text>();
        count = transform.Find("ItemCount").GetComponent<Text>();
        inv = GameObject.Find("Canvas/Inventory").GetComponent<Inventory>();
        res = transform.GetComponent<InvResource>().getResource();


        Debug.Log("Finding " + res + " in UVItem");
        index = inv.findResource(res);
        text.text = res.ToString();
        count.text = inv.getCount(index).ToString();

    }
	
    public void updateAmount()
    {
        count.text = inv.getCount(index).ToString();
    }

	// Update is called once per frame
	void Update () {
        updateAmount();
	}
}
