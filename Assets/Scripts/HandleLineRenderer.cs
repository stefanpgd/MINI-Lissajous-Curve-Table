using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleLineRenderer : MonoBehaviour
{
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private List<Transform> handles;

    private void Start()
    {
        lineRenderer.positionCount = handles.Count;
    }

    private void Update()
    {
        for(int i = 0; i < handles.Count; i++)
        {
            lineRenderer.SetPosition(i, handles[i].position);
        }
    }
}
