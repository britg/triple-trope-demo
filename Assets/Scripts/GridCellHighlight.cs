using UnityEngine;
using System.Collections;
using HighlightingSystem;

public class GridCellHighlight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	   var highlighter = GetComponent<Highlighter>();
       highlighter.ConstantOn(Color.gray, 0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
