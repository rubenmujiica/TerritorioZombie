using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemigos : MonoBehaviour
{
    public int muerto = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(muerto == 2){
            SceneManager.LoadScene("Win", LoadSceneMode.Single);
        }
    }

    public void hesidotocado()
    {
        Debug.Log("Estoy en el enemigo");
        
    }

    public void estoyMuerto()
    {
        Debug.Log("Estoy MUERTO");
        muerto++;
        
    }

    
}
