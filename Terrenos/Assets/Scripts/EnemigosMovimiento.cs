using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemigosMovimiento : MonoBehaviour

{
    UnityEngine.AI.NavMeshAgent pathfinder;
    Transform target;
    private int tocado = 0;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        pathfinder = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        pathfinder.SetDestination(target.position);
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player"))
        {           
            tocado++;
            if(tocado == 1){
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            }
                
        } 
}
}
