using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overload : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Add(1,2));
        Debug.Log(Add(1.1f, 2.2f));
        Debug.Log(Add(1.1d, 2.2d));

    }

    int Add(int a, int b)
    {
        return a + b;
    }

    float Add(float a, float b)
    {
        return a + b;

    }

    double Add(double a, double b)
    {
        return a + b;
    }

}
