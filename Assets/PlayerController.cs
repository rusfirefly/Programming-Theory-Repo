using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject player;
    Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        player = GameManeger.Instance.selectedObj;
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(player!=null)
        {
            if (player.gameObject.name != GameManeger.Instance.selectedObj.name)
            {
                player = GameManeger.Instance.selectedObj;
                mainCamera.transform.position = new Vector3(player.transform.position.x, 7, player.transform.position.z - 9 );
            }

            if (Input.GetKeyDown(KeyCode.T))
                player.gameObject.GetComponent<Animal>().Talk();

            player.gameObject.GetComponent<Animal>().Walk();
            mainCamera.transform.position = new Vector3(player.transform.position.x, 7, player.transform.position.z - 9);

            if (Input.GetKeyDown(KeyCode.Space))
                player.gameObject.GetComponent<Animal>().Jamp();
        }
        else
        {
            player = GameManeger.Instance.selectedObj;
        }
    }
}
