using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using TreeEditor;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.XR.WSA;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public float backStep;

    float h;
    float v;


    Vector3 moveVec = Vector3.zero;

    CharacterController playerController;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));
    }

    //private void Update()
    //{
    //    hAxis = Input.GetAxisRaw("Horizontal");
    //    vAxis = Input.GetAxisRaw("Vertical");

    //    moveVec = new Vector3(hAxis, 0, vAxis).normalized;

    //    transform.position += moveVec * speed * Time.deltaTime;

    //    transform.LookAt(transform.position + moveVec);
    //}




}
