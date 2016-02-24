using UnityEngine;
using System.Collections;

public class MouseInput : MonoBehaviour {
    
    public GameObject body;
    public PlayerController playerController;
    
    int groundLayer = 1 << 8;
    int dist = 1000;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	   Look();
       DetectAttack();
	}
    
    void Look () {
       var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       RaycastHit hit;
       
       if (Physics.Raycast(ray, out hit, dist, groundLayer)) {
           var pos = hit.point;
           body.transform.LookAt(pos);
       } 
    }
    
    void DetectAttack () {
        if (Input.GetMouseButtonDown(0)) {
            playerController.currentCharacterController.OnAttack();
        }
        
        if (Input.GetMouseButtonUp(0)) {
            playerController.currentCharacterController.OnStopAttack();
        }
    }
}
