using UnityEngine;
using System.Collections;

public class CameraNode : MonoBehaviour
{

    public CameraNode NextNode;
    public float CameraSpeed;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Camera.main.gameObject)
        {
            CameraMovement CamMovement = Camera.main.GetComponent<CameraMovement>();
            if (CamMovement == null)
            {
                Debug.LogError("Camera movement script not found on current camera!");
            }
            else
            {
                CamMovement.MovementSpeed = CameraSpeed;
            }
        }
    }

    void OnDrawGizmos()
    {
        if (NextNode != null)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, NextNode.transform.position);
        }
    }
}
