using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DTopDownController : MonoBehaviour
{
    public float _speed = 7.5f;
    public Rigidbody2D _rigidbody;
    public KeyCode _upKey;
    public KeyCode _downKey;
    public KeyCode _leftKey;
    public KeyCode _rightKey;
    float _distance;
    Vector2 _direction = new Vector2(0, 0);

    void Update()
    {
        //read inputs here
        _direction.y = 0;
        if (Input.GetKey(_upKey))
        {
            _direction.y += 1;
        }
        if (Input.GetKey(_downKey))
        {
            _direction.y -= 1;
        }
        if (Input.GetKey(_leftKey))
        {
            _direction.x -= 1;
        }
        if (Input.GetKey(_rightKey))
        {
            _direction.x += 1;
        }
    }

    void FixedUpdate()
    {
        //move the player here if we received inputs
        if (_direction.magnitude != 0)
        {
            _distance = _speed * Time.fixedDeltaTime;
            _rigidbody.MovePosition((Vector2)gameObject.transform.position + _direction.normalized * _distance);
        }

    }
}
