using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRespawn : MonoBehaviour
{
    //public GameObject pickup;
    public float respawnTimer = 5.0f;
    public bool collected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (collected == true)
       {
            respawnTimer -= Time.deltaTime;

            if (respawnTimer <= 0)
            {
                this.gameObject.GetComponent<MeshRenderer>().enabled = true;
                collected = false;
            }
       }        
    }
    void OnTriggerEnter(Collider other)
    {
        collected = true;
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;


        //if (other.gameObject.tag == "player")
        //{
        //    other.gameObject.SetActive(false);
        //}
    }
}
