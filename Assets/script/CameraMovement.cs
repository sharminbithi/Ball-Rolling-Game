using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 offset;
    public Transform camera;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        offset = camera.position;
    }

    // Update is called once per frame
    void Update()
    {
        camera.position = offset + player.position;
    }
}
