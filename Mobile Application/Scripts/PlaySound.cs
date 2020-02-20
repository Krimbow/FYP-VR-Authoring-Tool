﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    // Start is called before the first frame update
    public int taskNumber;
    private CreateRoom createRoom;
    void Start(){
        createRoom = GameObject.Find("Player").GetComponent<CreateRoom>();
    }
    void Update(){
        if(taskNumber == createRoom.currentTask) {
            gameObject.GetComponent<AudioSource>().Play();
            createRoom.currentTask++;
            GameObject.Find("Task").transform.GetChild(taskNumber).GetComponent<UnityEngine.UI.Text>().text += " ✓";
            Destroy(this);
        }
    }
}
