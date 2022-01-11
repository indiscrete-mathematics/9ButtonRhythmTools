using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNotes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

//Upon collision with another GameObject, this GameObject will do the following motion
    void OnTriggerEnter2D(Collider2D other)
    {
		//Debug.Log("autodestroy");
		Destroy(other.gameObject);
    } 
}
