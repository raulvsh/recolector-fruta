using UnityEngine;

public class AppleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject gameManager;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Colision");
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //collision es el collider del objeto que nos ha colisionado
        if (collision.gameObject.CompareTag("Player"))
        {
            //print("Suma puntos");

            gameManager.GetComponent<GameManager>().puntos++;
            //gameManager
        }
        else
        {
            //print("Resta vidas");
            gameManager.GetComponent<GameManager>().restaVida();
            //gameManager.GetComponent<GameManager>().vidas--;

        }


        Destroy(gameObject);


    }
}
