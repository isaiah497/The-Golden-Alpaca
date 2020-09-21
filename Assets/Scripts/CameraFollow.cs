﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//Author: MatthewCopeland
public class CameraFollow : MonoBehaviour
{
    [Header("Settings")]
    public Transform target;
    public Vector3 offset;
    private Vector3 velocity = Vector3.zero;
    public float smoothingSpeed = 0.125f;
    public bool showSceneLabels;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothingSpeed);
        transform.position = smoothedPosition;
    }

    private void OnDrawGizmosSelected()
    {
        if (showSceneLabels)
        {
            //Draw sphere from the view point of the size of the view range
            Gizmos.color = Color.white;
            Gizmos.DrawLine(transform.position, target.position);
            Handles.Label(target.position,"Follow Target: "+target.name);
        }
    }
}