using UnityEngine;
using System.Collections;

public class MobController : MonoBehaviour {
    
    public bool alive = true;
    public float speed;
    public float health;
    
    public GameObject target;

	// Use this for initialization
	void Start () {
	   IdentifyPlayer();
	}
	
	// Update is called once per frame
	void Update () {
	   
	}
    
    void IdentifyPlayer () {
        target = GameObject.Find("Player");
    }
    
    public void TakeMeleeDamage (float amount) {
        health -= amount;
        
        TestDeath();        
    }
    
    void TestDeath () {
        if (health <= 0f) {
            Die();
        }
    }
    
    void Die () {
        alive = false;
        iTween.RotateBy(gameObject, new Vector3(1f/4f, 0f, 0f), 0.2f);
        new tpd.Wait(this, 0.3f, () => {
           Remove(); 
        });
    }
    
    void Remove () {
        Destroy(gameObject);
    }
}
