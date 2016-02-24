using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour {
    
    public MobController mobController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (mobController.alive) {
            transform.LookAt(mobController.target.transform.position);     
        }
	   
	}
}
