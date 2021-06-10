using UnityEngine;

public class BindHandlePosition : MonoBehaviour
{
    [SerializeField] private GameObject xHandle;
    [SerializeField] private GameObject yHandle;

    private Vector2 startOffset;

    private void Start()
    {
        startOffset = transform.position;
    }

    private void Update()
    {
        Vector2 position = new Vector2(xHandle.transform.localPosition.x, yHandle.transform.localPosition.y);
        transform.position = position + startOffset;
    }
}
