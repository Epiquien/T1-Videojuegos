using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(player.name);
    }

    // Update is called once per frame
    void Update()
    {
        var x= player.transform.position.x +17;
        var y = player.transform.position.y +2 ;

        transform.position = new Vector3(x, y, transform.position.z);
    }
}
