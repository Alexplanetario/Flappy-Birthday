using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flappy : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject GameCollisionOver;
    public GameObject restart;
    public AudioClip[] audioClips;
    AudioSource  audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   if (Input.GetMouseButtonDown(0) && transform.position.y < 4f && !GameController.GameOver)
            { 
                audioSource.PlayOneShot(audioClips[0]);
                rb.velocity = new Vector2(0f, 7f);
            }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(audioClips[1]);
        GameCollisionOver.SetActive(true);
        GameController.GameOver = true;
        restart.SetActive(true);
    
    }
}
