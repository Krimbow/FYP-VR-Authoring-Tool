﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScene : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject door;
    public int taskNumber;
    private CreateRoom createRoom;
    void Start()
    {
        door = GameObject.Find("door");
        createRoom = GameObject.Find("Player").GetComponent<CreateRoom>();
    }

    // Update is called once per frame
    void Update()
    {
        if(taskNumber == createRoom.currentTask) {
            gameObject.GetComponent<MeshCollider>().enabled = true;
            createRoom.currentTask++;
            GameObject.Find("Task").transform.GetChild(taskNumber).GetComponent<UnityEngine.UI.Text>().text += " ✓";
        }
    }
}
