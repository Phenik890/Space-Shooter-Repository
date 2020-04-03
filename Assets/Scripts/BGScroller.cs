using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    private int zLength;
    public float scrollSpeed;

    void Start()
    {
        zLength = 30;
    }

    void Update()
    {
        transform.position = new Vector3(0.0f, -10.0f, Mathf.Repeat(Time.time * scrollSpeed, zLength));
    }
}
