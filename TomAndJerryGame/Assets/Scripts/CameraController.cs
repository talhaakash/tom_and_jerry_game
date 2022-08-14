using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour

{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // lateupdate help to update the vehicle after camera move so the vehcile running smooth
    void LateUpdate()
    {
        //offset the position behind the player by changing camera position
        transform.position = player.transform.position + offset;
    }
}
