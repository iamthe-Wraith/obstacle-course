using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    Vector2 rawInput;


    private void Update()
    {
        Move();
    }

    private void OnMove(InputValue value)
    {
        rawInput = value.Get<Vector2>();
    }

    private void Move()
    {
        Vector3 delta = rawInput * moveSpeed * Time.deltaTime;
        Vector3 newPos = new Vector3(delta.x,0,delta.y);

        transform.Translate(newPos);
    }
    
}
