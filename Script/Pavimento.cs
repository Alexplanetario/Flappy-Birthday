using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pavimento : MonoBehaviour
{
    Vector2 posiniziale;
    // Start is called before the first frame update
    void Start()
    {
        posiniziale = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameController.GameOver)
        {
            if (transform.position.x >= -0.647)
                transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime, transform.position.y);
            else
                transform.position = posiniziale;

        }

    }
}
