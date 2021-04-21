using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torta : MonoBehaviour
{
    bool giacontatoTorta = false;
    
    Vector2 posinizialeTorta;
    
    void Start()
    {
        posinizialeTorta = transform.position;
        
    }

   
    void Update()
    {
        if (!GameController.GameOver)
        {
            transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime, transform.position.y);

        }

        if (transform.position.x <= -6)
            Destroy(gameObject);

       
    }


    private void OnTriggerEnter2D(Collision2D collision)
    {

        giacontatoTorta = true;
        Punti.punteggio += 10;
        Destroy(gameObject);

    }
}
