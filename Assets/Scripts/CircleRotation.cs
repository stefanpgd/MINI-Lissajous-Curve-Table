using UnityEngine;

public class CircleRotation : MonoBehaviour
{
    [SerializeField] private float rotationIncrement = 1f;
    [SerializeField] private float radius;
    [SerializeField] private GameObject circle;

    private float angle = 0f;
    private Vector2 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        angle += rotationIncrement;

        float x = radius * Mathf.Cos(angle);
        float y = radius * Mathf.Sin(angle);
        Vector2 polarToCartesian = new Vector2(x, y);

        circle.transform.position = polarToCartesian + startPosition;
    }
}
