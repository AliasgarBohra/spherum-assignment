using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    [SerializeField] private Transform redCube;
    [SerializeField] private Transform greenCube;

    private LineRenderer lineRenderer;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }
    private void Update()
    {
        lineRenderer.SetPosition(0, redCube.position);
        lineRenderer.SetPosition(1, greenCube.position);
    }
}