using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Flappy : MonoBehaviour
{
    Rigidbody2D Collisione;
    public static GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        Collisione = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Collisione.velocity = new Vector2(0f, 7f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameover.SetActive(true);
    }
}

