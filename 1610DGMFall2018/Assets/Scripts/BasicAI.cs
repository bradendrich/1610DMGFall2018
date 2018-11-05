using UnityEngine.AI;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform Destination;

    void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
	}

    void Update ()
    {
        if (Destination != null) agent.destination = Destination.position;
	}
}
