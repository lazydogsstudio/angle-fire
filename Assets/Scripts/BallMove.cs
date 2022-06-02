using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private GameObject gun;

    private GamePlayManager gamePlayManager;

    private void Start()
    {
        gun = GameObject.Find("Gun");
        gamePlayManager = GameObject.Find("Game Play Manager").GetComponent<GamePlayManager>();
    }

    void Update()
    {
        transform.Translate(gun.transform.up * speed);

        if (transform.position.x > 7f)
        {
            gamePlayManager.incrementScore();
            Destroy(gameObject);
        }
        else if (transform.position.x < -7f)
        {
            gamePlayManager.incrementScore();
            Destroy(gameObject);
        }

        else if (transform.position.y > 7f)
        {
            gamePlayManager.incrementScore();
            Destroy(gameObject);
        }

        else if (transform.position.y < -7f)
        {
            gamePlayManager.incrementScore();
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
            gamePlayManager.gameOver();
        }
    }


}
