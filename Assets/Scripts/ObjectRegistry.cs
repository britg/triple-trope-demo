using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectRegistry : MonoBehaviour {
    
    public GameObject playerPrefab;
    public GameObject goblinPrefab;
    
    public Dictionary<string, GameObject> registry;
    
    void Awake () {
        registry = new Dictionary<string, GameObject>() {
            { "player", playerPrefab },
            { "goblin", goblinPrefab }
        };
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public GameObject Get (string key) {
        return registry[key];
    }
}
