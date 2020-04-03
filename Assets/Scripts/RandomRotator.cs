﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float tumble;

    private void Start()
    {
        rigidBody.angularVelocity = Random.insideUnitSphere * tumble;
    }
}
