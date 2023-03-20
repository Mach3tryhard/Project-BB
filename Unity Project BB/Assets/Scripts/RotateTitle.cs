using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTitle : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Rotate(1.0f, 1.0f, 1.0f, Space.Self);
    }
}
