using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float forca_pulo;
    public GameObject GameOverScreen;




    void Start()
    {
        
    }

    
    void Update()
    {
        Pulin();
    }

    void Pulin()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = (Vector2.up * forca_pulo);
        }
    }

        private void OnTriggerEnter2D(Collider2D collision​)
        {
            if(collision.gameObject.tag == "Wall")
            {
            this.enabled = false;
            GameOverScreen.SetActive(true);
        }
        }
}
