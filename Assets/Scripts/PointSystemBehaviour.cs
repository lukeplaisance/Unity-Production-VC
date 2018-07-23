﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystemBehaviour : MonoBehaviour
{
    [SerializeField]
    private List<int> pointsList = new List<int>();

    public void AddPoints(int point)
    {
        pointsList.Add(point);
    }
}