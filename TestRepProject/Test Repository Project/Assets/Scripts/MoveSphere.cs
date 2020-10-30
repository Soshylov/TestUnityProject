using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    [SerializeField] private float force = default;
    [SerializeField] private float speed = default;
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
        MovementLogic();
    }
    private void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
