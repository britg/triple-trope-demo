using UnityEngine;
using System.Collections;

public class KeyboardMove : MonoBehaviour {
    
    public bool movementEnabled = true;
    public float speed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (movementEnabled) {
            DetectInput();     
        }
	}
    
    void DetectInput () {
        var dir = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) {
            dir += Vector3.forward;
        }
        
        if (Input.GetKey(KeyCode.A)) {
            dir += Vector3.left;
        }
        
        if (Input.GetKey(KeyCode.D)) {
            dir += Vector3.right;
        }
        
        if (Input.GetKey(KeyCode.S)) {
            dir += Vector3.back;
        }
        
        var result = dir.normalized * speed * Time.deltaTime;
        
        transform.Translate(result);
    }
}
