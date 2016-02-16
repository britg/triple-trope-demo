using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

public class LevelLoader : MonoBehaviour {
    
    public JSONResourceLoader jsonLoader;
    public ObjectRegistry registry;
    
    public string level = "1";

	// Use this for initialization
	void Start () {
	   jsonLoader.OnDoneLoading += OnDoneLoadingManifest;
       jsonLoader.Load(Application.streamingAssetsPath); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void OnDoneLoadingManifest () {
        var manifest = JSONResource.jsonCache["level_manifest"]["level_manifest"];
        var data = manifest.AsObject["data"].AsObject[level];
        Debug.Log("Done loading! " + data.ToString());
        LoadLevelData(data.AsObject);
    }
    
    void LoadLevelData (JSONClass levelData) {
        foreach (KeyValuePair<string, JSONNode> kv in levelData) {
            var coords = kv.Key;
            var tile = GameObject.Find(string.Format("({0})", coords));
            
            var obj = kv.Value.Value;
            
            var prefab = registry.Get(obj);
            var go = Instantiate(prefab);
            go.transform.position = tile.transform.position;
        }
    }
}
