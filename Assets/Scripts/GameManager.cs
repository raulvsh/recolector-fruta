using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform punteroManzana;
    public GameObject prefabManzana;
    public GameObject player;

    public Transform limiteI;
    public Transform limiteD;

    public int puntos;
    public int vidas;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(lanzarManzana());
        puntos = 0;
        vidas = 3;
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator lanzarManzana()
    {
        float posicionX = 0;
        while (true)
        {
            yield return new WaitForSeconds(3f);
            posicionX = Random.Range(limiteI.position.x, limiteD.position.x);
            punteroManzana.position = new Vector3(posicionX, punteroManzana.position.y, punteroManzana.position.z);


            Instantiate(prefabManzana, punteroManzana.position, punteroManzana.rotation);
        }
    }

    public void restaVida()
    {
        vidas--;
        if (vidas < 1)
        {
            print("Game over");
            StopAllCoroutines();
            player.GetComponent<PlayerController>().enabled = false;

        }
    }
}
