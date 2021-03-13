using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    bool rotation;
    private void Update()
    {
        if (rotation)
        {
            RotationOfObject();
        }

    }

    public void RotateT()
    {
        rotation = true;
    }
        public void RotateF()
    {
        rotation = false;
    }

    public void RotationOfObject()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 100);
    }
}
