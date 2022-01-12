using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xRotation = 0f;
    [SerializeField] private float yRotation = 0f;
    [SerializeField] private float zRotation = 0f;
    private void Update()
    {
        transform.Rotate(xRotation,yRotation,zRotation);
    }
}
