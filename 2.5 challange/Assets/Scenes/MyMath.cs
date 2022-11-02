using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMath : MonoBehaviour
{int  num=6;
    // Start is called before the first frame update
    void Start()
    {
        debug.log(num);
    }

    // Update is called once per frame
    void Update()
    {
        num = product(num, 2);
        Project(int num1);
    }
}
