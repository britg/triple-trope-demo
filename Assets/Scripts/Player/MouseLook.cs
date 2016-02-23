using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {
    
    int groundLayer = 1 << 8;
    int dist = 1000;
    
    GameObject player;

	// Use this for initialization
	void Start () {
        player = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	   var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       RaycastHit hit;
       
       if (Physics.Raycast(ray, out hit, dist, groundLayer)) {
           var pos = hit.point;
           player.transform.LookAt(pos);
       }
	}
}
