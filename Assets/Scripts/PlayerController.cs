using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadX = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Juego de recolección de frutas");
        velocidadX = 5.0f;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(-velocidadX * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(velocidadX * Time.deltaTime, 0, 0);
        }
    }



}
