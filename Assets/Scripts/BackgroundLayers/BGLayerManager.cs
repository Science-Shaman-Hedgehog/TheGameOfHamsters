using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BGLayerManager : MonoBehaviour
{
    public List<BGLayer> Layers = new List<BGLayer>();

    protected CameraMovement MovementScript;

    void Start()
    {
        MovementScript = gameObject.GetComponent<CameraMovement>();
    }

    void LateUpdate()
    {
        for (int i = 0; i < Layers.Count; i++)
        {
            if (Layers[i].instance != null)
                Layers[i].instance.transform.position += transform.right * MovementScript.HorizontalDPF * Layers[i].SpeedModificator;
        }
    }
}
