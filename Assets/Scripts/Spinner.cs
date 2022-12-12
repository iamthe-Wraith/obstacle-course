using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 75f;
    [SerializeField] float startingRotation = 0f;
    [SerializeField] bool clockwise = true;

    private void Start()
    {
        transform.Rotate(0,(clockwise ? 1 : -1) * startingRotation,0);
    }

    void Update()
    {
        float delta = (clockwise ? 1 : -1) * rotationSpeed * Time.deltaTime;
        transform.Rotate(0,delta,0);
    }
}
