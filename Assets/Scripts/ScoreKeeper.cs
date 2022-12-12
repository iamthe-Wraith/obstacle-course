using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int collisions = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Ground" && other.gameObject.tag != "Hit")
        {
            collisions++;
            Debug.Log("You have bumped into " + collisions + " obstacles.");
        }
    }
}
