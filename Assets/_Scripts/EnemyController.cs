﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBound;
    public float dir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed * dir * Time.deltaTime, 0.0f, 0.0f);
    }

    private void _CheckBounds()
    {
        // ---------------- check right bound ----------------- //
        if(transform.position.x >= horizontalBound)
        {
            dir = -1.0f;
        }


        // ---------- check right bound -------------------- //
        if(transform.position.x <= -horizontalBound)
        {
            dir = 1.0f;
        }
    }

}
