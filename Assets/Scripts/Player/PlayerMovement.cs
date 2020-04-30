using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public string verticalAxis = "Vertical";
    public float moveSpeed = 10f;

    private Rigidbody2D _rb;
    private float _vertical;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        _vertical = Input.GetAxis(verticalAxis);
        _rb.velocity = new Vector2(0f, _vertical) * moveSpeed;
    }
}
