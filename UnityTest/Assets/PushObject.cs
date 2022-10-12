using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class PushObject : MonoBehaviour
{
    [Min(0.1f)]
    public float PushForce = 5f;

    private bool _isDown;
    private Rigidbody _rb;
    private Plane _planeXZ;

    private void Start() => _rb = GetComponent<Rigidbody>();

    private void OnMouseDown()
    {
        _isDown = true;
        _planeXZ = new Plane(Vector2.up, new Vector3(0, _rb.position.y, 0));
    }

    private void Update()
    {
        if (_isDown)
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            _planeXZ.Raycast(ray, out float enter);

            Vector3 mouse = ray.GetPoint(enter);

            Vector3 direction = _rb.position - mouse;

            DebugDrawArrow(_rb.position, direction);
            DebugDrawDashedRay(mouse, direction);

            if (Input.GetMouseButtonUp(0))
            {
                Push(direction);
                _isDown = false;
            }

        }
    }
    private void Push(Vector3 direction)
    {
        _rb.AddForce(direction * PushForce, ForceMode.Impulse);
    }

    private void DebugDrawDashedRay(Vector3 start, Vector3 direction)
    {
        float dashGap = 1f;
        int dots = (int)(direction.magnitude / dashGap);
        Vector3 dir = direction.normalized;

        for (int i = 0; i < dots; i++)
        {
            Debug.DrawRay(start + dir * (dashGap * i), dir * dashGap * 0.5f);
        }
    }

    private void DebugDrawArrow(Vector3 start, Vector3 direction)
    {
        float arrowOffset = 1f;
        float arrowWidth = 0.5f;

        Debug.DrawRay(start, direction);

        Vector3 end = start + direction;
        Vector3 leftNormal = (Quaternion.Euler(0, -90, 0) * direction).normalized;
        Vector3 rightNormal = -leftNormal;

        Vector3 endBackOffset = end - (direction.normalized * arrowOffset);

        Vector3 leftNormalEnd = endBackOffset + leftNormal * arrowWidth;
        Vector3 rightNormalEnd = endBackOffset - leftNormal * arrowWidth;

        Debug.DrawRay(endBackOffset, leftNormal * arrowWidth);
        Debug.DrawRay(endBackOffset, rightNormal * arrowWidth);

        Debug.DrawLine(end, leftNormalEnd);
        Debug.DrawLine(end, rightNormalEnd);
    }
}
