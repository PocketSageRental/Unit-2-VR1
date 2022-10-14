using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int Lives = 3
    Rigidbody2D player = null;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(Lives);
        Debug.Log(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
