﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonFly : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 0.2f);
    }
}
