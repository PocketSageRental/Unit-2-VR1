using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left : MonoBehaviour
{
    Transform left1;
    // Start is called before the first frame update
    void Start()
    {
        left1 = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime);
    }
}
