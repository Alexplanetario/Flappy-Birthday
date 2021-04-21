using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pavimento : MonoBehaviour
{
    Vector2 PosizioneI;
    // Start is called before the first frame update
    void Start()
    {
        PosizioneI = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= -1.7f)
            transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime,
                transform.position.y);
        else
            transform.position = PosizioneI;
    }
}
