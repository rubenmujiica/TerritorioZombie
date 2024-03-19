using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    // Start is called before the first frame update
    Transform salida;
    float proximodisparo = 0f;
    float tiempodeEspera = 0.3f;
    public GameObject bala;

    void Start()
    {
        salida = gameObject.transform.GetChild(0).transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= proximodisparo && Input.GetMouseButtonDown(0))
        {
            proximodisparo = Time.time + tiempodeEspera;

            GameObject nuevabala = Instantiate(bala, salida.position, salida.rotation);
        }
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Zombie"))
        {           
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
                 
        } 
}
}