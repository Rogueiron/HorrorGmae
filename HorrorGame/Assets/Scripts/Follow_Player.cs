using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class Follow_Player : MonoBehaviour
{
    public float speed;
    // private Rigidbody enemyrb;
    //private GameObject player;
    public GameObject player;
    private NavMeshAgent zombert;
    // Start is called before the first frame update
    void Start()
    {
        //enemyrb = GetComponent<Rigidbody>();
        //player = GameObject.Find("Player");
        player = GameObject.Find("Player");

        zombert = GetComponent<NavMeshAgent>();
        zombert.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        zombert.destination = player.transform.position;
        //enemyrb.AddForce((player.transform.position - transform.position).normalized * speed);
    }

}
