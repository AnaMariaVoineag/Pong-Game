using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework4Comment : MonoBehaviour
{
    [SerializeField]
    private string _message = "";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(_message);
    }
}
