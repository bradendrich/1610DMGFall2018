using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform Destination;
    public GameAction Action;
    private bool isFlipped;

    void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        Action.Raise += UpdateDestination;
	}

    void Update ()
    {
        if (Destination != null) agent.destination = Destination.position;
        if (agent.velocity.x >= 0 && isFlipped == false)
        {
            transform.Rotate(0, 180, 0);
            isFlipped = true;
        }
        else if (agent.velocity.x <= 0 && isFlipped == true)
        {
            transform.Rotate(0, 180, 0);
            isFlipped = false;
        }
    }

    public void UpdateDestination(object location)
    {
        Destination = location as Transform;
    }
}
