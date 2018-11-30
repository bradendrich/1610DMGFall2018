using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Player;
    public GameObject SpawnPoint;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Player == null) Instantiate(Player, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
    } 
}
