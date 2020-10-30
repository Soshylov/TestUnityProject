using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    [SerializeField] private float force = default;
    private Rigidbody _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey("space"))
        {
            _rb.AddForce(Vector3.up * force);
        }
    }
}
