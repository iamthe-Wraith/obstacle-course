using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropDelay;

    bool hasDropped = false;
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;

    private void Start()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
        rigidBody = gameObject.GetComponent<Rigidbody>();

        SetEnabled(false);
    }

    private void Update()
    {
        if (Time.time > dropDelay && !hasDropped)
        {
            SetEnabled(true);
        }
    }

    private void SetEnabled(bool isEnabled)
    {
        hasDropped = isEnabled;
        meshRenderer.enabled = isEnabled;
        rigidBody.useGravity = isEnabled;
    }
}
