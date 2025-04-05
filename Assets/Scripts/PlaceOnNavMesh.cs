using UnityEngine;
using UnityEngine.AI;

public class PlaceOnNavMesh : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float maxDistance = 5f;

    void Start()
    {
        Place();
    }

    public void Place()
    {
        // Get the current position
        Vector3 originalPosition = target.transform.position;
        
        NavMeshHit hit;
        if (NavMesh.SamplePosition(originalPosition, out hit, maxDistance, NavMesh.AllAreas))
        {
            target.transform.position = hit.position;
        }
        else
        {
            Debug.LogWarning("Could not find NavMesh near position: " + originalPosition);
        }
    }
}