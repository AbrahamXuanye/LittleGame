using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float v = 1;
    private Rigidbody2D rb;
    public GameManager gameManager;
    private Transform birdTransformbefore;
    private Transform birdTransformafter;
    private bool gameStart;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //gameStart = GetComponent<GameManager>().gameStart;
        birdTransformbefore = transform;
        birdTransformafter = transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * v;

        };
        
    }
    void earlyUpdate()
    {
        birdTransformbefore = transform;
    }
    void lateUpdate()
    {
        if (birdTransformafter.position.y > birdTransformbefore.position.y)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 45), 0.05f);
        }
        if (birdTransformafter.position.y < birdTransformbefore.position.y)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -45), 0.05f);
        }
        birdTransformafter = transform;
        if(birdTransformbefore != birdTransformafter)
        {
            Debug.Log(" not equal");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
