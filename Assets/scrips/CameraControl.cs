using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    private Vector3 velos;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0f, 1f, -5f);
        velos = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.localPosition);

        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 5, -10));

        transform.localPosition = Vector3.SmoothDamp(transform.localPosition, targetPosition, ref velos, 0.2f);

        //transform.localPosition = Vector3.Lerp(transform.localPosition, target.localPosition + offset , 0.5f);
        // 원래 위치, 목표 위치, t ??
    }
}
