using UnityEngine;
using System.Collections;

public class MovesAtPlayer : MonoBehaviour {
    
    public MobController mobController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (mobController.alive) {
            MoveAtPlayer();     
        }
	}
    
    void MoveAtPlayer () {
        var dir = mobController.target.transform.position - transform.position;
        var v = dir.normalized * mobController.speed * Time.deltaTime;
        transform.Translate(v);
    }
}
