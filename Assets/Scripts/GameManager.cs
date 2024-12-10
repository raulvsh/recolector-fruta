using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform punteroManzana;
    public GameObject prefabManzana;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(lanzarManzana());
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator lanzarManzana()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(prefabManzana, punteroManzana.position, punteroManzana.rotation);
        }
    }
}
