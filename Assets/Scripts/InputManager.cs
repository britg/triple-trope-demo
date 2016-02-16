using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
    
    public bool enabled = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   if (enabled) {
           DetectInput();
       }
	}
    
    void DetectInput () {
        if (Input.GetMouseButtonUp(0)) {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            var layerMask = 1 << 8;
            if (Physics.Raycast(ray, out hit, 100, layerMask)) {
                Debug.Log("Hit a tile");
            }
            
        }
    }
}
