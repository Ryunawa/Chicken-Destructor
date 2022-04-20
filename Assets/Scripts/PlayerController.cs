using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerController : MonoBehaviour
{
    [Range(1f, 50f)]
    [SerializeField] private float _rayMaxDistance = 20f;

    [SerializeField] LayerMask _groundLayer, whatIsPlayer;

    private Camera _mainCamera;
    private NavMeshAgent _agent;

    private bool isChickenInRange;

    void Start()
    {
        _mainCamera = Camera.main;
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Shader.SetGlobalVector("WS_PlayerPosition", transform.position);

        if (Input.GetMouseButtonDown(1))
        {
            Ray cameraRay = _mainCamera.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;
            if (Physics.Raycast(cameraRay, out hitInfo, _rayMaxDistance, _groundLayer.value))
            {
                _agent.SetDestination(hitInfo.point);
            }
        }
    }
}
