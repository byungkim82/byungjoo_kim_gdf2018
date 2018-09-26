using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship_movement : MonoBehaviour {
    public float floatStrength;
    private float originalY;
	// Use this for initialization
	void Start () {
        originalY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, originalY + (float)Mathf.Sin(Time.time) * floatStrength, transform.position.z);
	}
}
