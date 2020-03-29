using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float tumble;

    private void Start()
    {
        rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
    }
}
