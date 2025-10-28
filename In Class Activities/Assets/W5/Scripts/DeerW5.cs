using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...



public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform goal;
    private void Start()
    {
        NavMeshAgent navigation = gameObject.GetComponent<NavMeshAgent>();

        //NavMeshAgent agent = GetComponent<NavMeshAgent>(); you don't need gameObject if
        //you're getting the component from the current object

        //navigation.destination = goal.position;

        navigation.SetDestination(goal.position);
    }
}
