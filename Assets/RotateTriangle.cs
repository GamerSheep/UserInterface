using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTriangle : MonoBehaviour
{

    public void Rotate(float degrees)
    {
        transform.Rotate(0, 0, degrees);
    }

}
