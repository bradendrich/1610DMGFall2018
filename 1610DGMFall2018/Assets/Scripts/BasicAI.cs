using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform Destination;
    public GameAction Action;

    void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        Action.Raise += UpdateDestination;
	}

    void Update ()
    {
        if (Destination != null) agent.destination = Destination.position;
    }

    public void UpdateDestination(object location)
    {
        Destination = location as Transform;
    }
}
