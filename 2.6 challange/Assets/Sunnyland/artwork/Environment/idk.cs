using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xmove = Input.GetAxisRaw("Horizontal");
        xmove = Input.GetAxisRaw("Vertical");
    }
}
