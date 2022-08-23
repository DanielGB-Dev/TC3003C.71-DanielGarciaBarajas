using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapa : MonoBehaviour
{
    public GameObject player;
    public GameObject cursor;
    Vector3 playerPos;
    Vector3 mapSize;
    // Start is called before the first frame update
    void Start()
    {
        mapSize = GetComponent<Collider>().bounds.size;
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        float w = mapSize.x;
        float h = mapSize.z;
        Vector3 cursorPos = new Vector3(-w/2.0f, 0, -h/2.0f);
        cursorPos.x += (playerPos.x * w / 200.0f) * 5.0f;
        cursorPos.z += (playerPos.z * h / 200.0f) * 5.0f;

        cursor.transform.position = cursorPos;
    }
}
