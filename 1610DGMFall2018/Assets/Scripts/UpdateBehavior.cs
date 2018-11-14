using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class UpdateBehavior : MonoBehaviour {

    public UnityEvent Event;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Event.Invoke();
	}
}
