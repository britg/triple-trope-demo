using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    
    public GameObject mobPrefab;
    public float intervalMin;
    public float intervalMax;

	// Use this for initialization
	void Start () {
        SpawnRepeating();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void SpawnRepeating () {
        float interval = Random.Range(intervalMin, intervalMax);
        
        new tpd.Wait(this, interval, () => {
            SpawnMob();
            SpawnRepeating();
        });
    }
    
    void SpawnMob () {
        Instantiate(mobPrefab, transform.position, Quaternion.identity);
    }
}
