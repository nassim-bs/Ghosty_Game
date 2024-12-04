using UnityEngine;
using UnityEngine.AI;

public class GhostNavMeshScript : MonoBehaviour
{
    public Camera cam;
    [SerializeField] private GameObject movePosition;
    [SerializeField] private NavMeshAgent aAgent, Player;

    private void Awake() { }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Player.SetDestination(hit.point);
            }
        }
        aAgent.destination = movePosition.transform.position;
    }
    /* public void Moved(){
        aAgent.destination = movePosition.transform.position;
    } */

}
