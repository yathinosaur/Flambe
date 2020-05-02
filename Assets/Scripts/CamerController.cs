using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    [SerializeField] private GameObject main_camera;
    [SerializeField] private Transform player;

    private float camera_offset = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        camera_offset = (main_camera.transform.position - player.position).z;
    }

    // Update is called once per frame
    void Update()
    {
        main_camera.transform.position = player.position + new Vector3(0, 0, camera_offset);
    }
}
