using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour {

    [SerializeField]
    ResourceType resource;
    [SerializeField]
    string description;
	

    ResourceType getResource() { return resource; }
    string getDescription() { return description; }
}
