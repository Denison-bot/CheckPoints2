using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public CharacterController Player;
    Vector3 respawnPoint;
    

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = new Vector3(0.0f, 1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Resetting player");
            //Player.transform.position = new Vector3(0.0f, 1.0f, 0.0f);
            //Player.Move(new Vector3(0.0f, 10.0f, 0.0f));
            Vector3 deltaMove = respawnPoint - Player.transform.position;
            Player.Move(deltaMove);
        }
    }
}
