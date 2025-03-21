using UnityEngine;

public class Homework5Script2 : MonoBehaviour
{
    //Lini care pot fi modificate: 3, 6, 7, 12
    public float _speed = 20f;
    public float _maxSpeed = 50f;
    private int _randomNumber = 10;

    private void Start()
    {
        if (_randomNumber == 10)
        {
            if (_speed < _maxSpeed)
            {
                Debug.Log("Speed is lower than max speed");
            }
            else
            {
                Debug.Log("Speed is higher than max speed");
            }
        } 
    }
}
