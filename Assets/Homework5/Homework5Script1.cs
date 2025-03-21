using UnityEngine;

public class Homework5Script1 : MonoBehaviour
{
    //Lini care pot fi modificate: 6, 7, 17, 18, 20
    public Rigidbody2D _rigidBody2D;
    public string _nameToDisplay = "Ana";
    private Vector2 _newPosition = Vector2.zero;

    private void Start()
    {
        Debug.Log("Player name: " + _nameToDisplay);
    }

    void MoveObjectToPosition()
    {
        _rigidBody2D.MovePosition(_newPosition);
        if(_rigidBody2D.position.y > 20)
        {
            _rigidBody2D.MovePosition(new Vector2(_rigidBody2D.position.y, 20));
        }
    }
}
