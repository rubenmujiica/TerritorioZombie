using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class gestionVidas : MonoBehaviour
{
    public float vida = 5f;
    public float MaxVida = 5f;

    public UnityEvent hesidotocado;
    public UnityEvent estoyMuerto;
    public GameObject enemigo;

    void tocado(float fuerza)
    {
        vida -= fuerza;
        hesidotocado.Invoke();
        if(vida <= 0)
        {
            Destroy(enemigo);
            estoyMuerto.Invoke();
        }
    }
}
