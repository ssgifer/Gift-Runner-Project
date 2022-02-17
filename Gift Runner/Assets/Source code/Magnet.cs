using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//แม่เหล็ก
public class Magnet : MonoBehaviour
{
    public static bool isMagnet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            isMagnet = true;
            Destroy(gameObject);
        }
    }
}
