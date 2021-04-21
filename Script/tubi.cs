using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubi : MonoBehaviour
{
    bool giacontato = false;
    AudioSource audioSource;
    Vector2 posiniziale;
    // Start is called before the first frame update
    void Start()
    {
        posiniziale = transform.position;
        audioSource = GetComponent<AudioSource>();
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
       
        if(!giacontato && transform.position.x < -4)
        {
            giacontato = true;
            Punti.punteggio += 1;
            audioSource.Play();
        }
    }
}
