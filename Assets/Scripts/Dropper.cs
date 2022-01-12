using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float dropTime;

    private MeshRenderer _meshRenderer;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _meshRenderer.enabled = false;
        _rigidbody.useGravity = false;
    }

    private void Update()
    {
        if (Time.time > dropTime)
        {
            _meshRenderer.enabled = true;
            _rigidbody.useGravity = true;
        }
    }
}
