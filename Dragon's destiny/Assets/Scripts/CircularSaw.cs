﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularSaw : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, -3f));
    }
}
