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

    float hAxis;
    float vAxis;


    Vector3 moveVec;


    private void Awake()
    {
     

    }

    void Start()
    {
        
    }

    private void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        transform.position += moveVec * speed * Time.deltaTime;
    }


    private void LateUpdate()
    {
        
    }


}
