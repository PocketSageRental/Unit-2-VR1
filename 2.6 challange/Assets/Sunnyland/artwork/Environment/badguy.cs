using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badguy : MonoBehaviour
{
    Transform badguy1;
    // Start is called before the first frame update
    void Start()
    {
        badguy1 = gameObject.transform;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime);
    }
}
