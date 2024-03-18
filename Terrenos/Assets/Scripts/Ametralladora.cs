using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ametralladora : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSource;
    Animation animacion;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animacion = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            audioSource.Play();

            animacion.wrapMode = WrapMode.Once; //Para que solo funcione una vez la animacion
            animacion.Play();
        }
    }
}
