using UnityEngine;
using UnityEngine.AI;


public class skeletoMove : MonoBehaviour
{
    public Transform destination;
    public NavMeshAgent agent;

    private void Update()
    {
        agent.SetDestination(destination.position);
    }

}