using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class LookWalk : MonoBehaviour
{

    public Transform vrCamera;
    public float toggleAngle=30.0f;
    public float speed = 3.0f;
    public bool moveForward;

    private CharacterController cc;


    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90)
        {
            moveForward = true;
        }else
        {
            moveForward = false;
        }
        if (moveForward)
        {
            UnityEngine.Vector3 forward = vrCamera.TransformDirection(UnityEngine.Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
    }
}
