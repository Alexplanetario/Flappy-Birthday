using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime,
            transform.position.y);
        if (transform.position.x < -6)
            Destroy(gameObject);
    }
}
