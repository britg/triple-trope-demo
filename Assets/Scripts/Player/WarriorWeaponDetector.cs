using UnityEngine;
using System.Collections;

public class WarriorWeaponDetector : MonoBehaviour {
    
    public WarriorController warriorController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void OnTriggerEnter (Collider collider) {
        if (enabled) {
            Debug.Log("trigger " + collider);
            var mobController = collider.gameObject.GetComponent<MobController>();
            if (mobController != null) {
                warriorController.OnHitMob(mobController);
            }
        }
    }
    
}
