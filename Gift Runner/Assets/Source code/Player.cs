using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float timeLeft = 5f;
    public bool flytoplayer;
    private float speed = 1500;
    //public PlayerManager gameOver;
    Rigidbody rb;
    GameObject player;
    Vector3 playerDirection;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        /*if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }*/

        //ควบคุมการเดิน
        if (flytoplayer && Magnet.isMagnet)
        {
            playerDirection = -(transform.position - player.transform.position).normalized;
            rb.velocity = new Vector3(playerDirection.x, playerDirection.y, playerDirection.z) * speed * Time.deltaTime;
        }
    }

    //วิ่งชนวัตถุ
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("MagnetArea"))
        {
            flytoplayer = true;
        }

        if (other.tag == "Player")
        {
            Score.score++;          //+score
            Destroy(gameObject);    //วัตถุหาย
        }

    }

}
