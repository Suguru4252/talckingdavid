using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Transform target;
    public float distance = 4f;
    public float speedX = 4f;
    public float speedY = 2f;
    private float x = 0f;
    private float y = 20f;

    void LateUpdate()
    {
        if (target == null) return;

        x += Input.GetAxis("Mouse X") * speedX;
        y -= Input.GetAxis("Mouse Y") * speedY;
        y = Mathf.Clamp(y, -30f, 60f);

        Quaternion rot = Quaternion.Euler(y, x, 0);
        Vector3 pos = rot * new Vector3(0, 0, -distance) + target.position;

        transform.position = pos;
        transform.LookAt(target);
    }
}