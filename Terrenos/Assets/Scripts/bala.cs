using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocidad = 5.0f;
    public float valorherida = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movDistancia = Time.deltaTime * velocidad;
        transform.Translate(Vector3.forward * movDistancia);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("chocado");
        other.SendMessage("tocado", valorherida, SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }
}
