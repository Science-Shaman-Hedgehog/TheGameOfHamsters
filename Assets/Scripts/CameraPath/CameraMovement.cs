using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public float MovementSpeed = 1;
    public float Acceleration = 0.05f;
    public float CurrentSpeed = 0;
    [Tooltip("Horizontal Distance Per Frame")]      //multiply that with vector to get distance in standart units
    public float HorizontalDPF;

	void Update () {
        CurrentSpeed += (MovementSpeed - CurrentSpeed) * Acceleration;
        HorizontalDPF = CurrentSpeed * Time.deltaTime;
    }

    void LateUpdate()
    {
        transform.position += transform.right * HorizontalDPF;
    }
}
