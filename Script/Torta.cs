using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torta : MonoBehaviour
{
    bool giacontatoTorta = false;
    
    Vector2 posinizialeTorta;
    // Start is called before the first frame update
    void Start()
    {
        posinizialeTorta = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.GameOver)
        {
            transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime, transform.position.y);

        }

        if (transform.position.x <= -6)
            Destroy(gameObject);

        if (!giacontatoTorta && transform.position.x < -4)
        {
            giacontatoTorta = true;
            Punti.punteggio += 10;
            
        }
    }
}
