using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform Player;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate ()
    {
        Vector3 desiredPosition = Player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
