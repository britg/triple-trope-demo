using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour {
    
    public bool movementEnabled = true;
    public float speed; // 10f
    public float rotateTime; // = 0.1f;
    
    public GameObject rotation;
    public PlayerController playerController;
    
    bool isRotating = false;
    int lastRotationDir = 0;

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
        
        if (Input.GetKeyDown(KeyCode.E)) {
            Rotate(1);
        }
        
        if (Input.GetKeyDown(KeyCode.Q)) {
            Rotate(-1);
        }
        
        var result = dir.normalized * speed * Time.deltaTime;
        
        transform.Translate(result);
    }
    
    void Rotate (int dir) {
        if (isRotating) {
            return;
        }
        
        var amount = new Vector3(0f, 1f/3f, 0f);
        isRotating = true;
        lastRotationDir = dir;
        iTween.RotateBy(rotation, iTween.Hash(
            "amount", amount * dir, 
            "time", rotateTime,
            "oncompletetarget", gameObject,
            "oncomplete", "ReleaseRotationHold"
            )
        );
    }
    
    void ReleaseRotationHold () {
        isRotating = false;
        playerController.OnRotate(lastRotationDir);        
    }
}
