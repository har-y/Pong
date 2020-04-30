using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _moveSpeed;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _moveSpeed = GetComponent<BallMovement>().moveSpeed;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player 1")
        {
            float y = HitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;

            _rb.velocity = direction * _moveSpeed;
        }

        if (collision.gameObject.tag == "Player 2")
        {
            float y = HitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(-1, y).normalized;

            _rb.velocity = direction * _moveSpeed;
        }
    }

    private float HitFactor(Vector2 ballPosition, Vector2 playerPosition, float playerHeight)
    {
        return (ballPosition.y - playerPosition.y) / playerHeight;
    }
}
