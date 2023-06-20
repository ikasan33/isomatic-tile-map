using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Vector3 = UnityEngine.Vector3;

public class cameracont : MonoBehaviour
{
    public float smoothspeed = 2;

    private Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("witch").GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,
            new Vector3(target.position.x, target.position.y, transform.position.z), smoothspeed * Time.deltaTime);
    }
}
