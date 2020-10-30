using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    [SerializeField] private float force = default;
    private Rigidbody _rb;
    private bool _state;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        _state = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        _state = false;
    }
    void Update()
    {
        if (Input.GetKey("space") && _state )
        {
            _rb.AddForce(Vector3.up * force);
        }
    }
}
