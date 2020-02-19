using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int health;
    public int gamestate;
    public int disrupter;

    public Text healthtext;
    public Text emptext;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;

        health = 5;
        disrupter = 1;

        healthtext.text = "";
        emptext.text = "";
    }


    void Awake()
    {
        Application.targetFrameRate = 60;
        Cursor.visible = false;
    }


    // Update is called once per frame
    void Update()
    {
        healthtext.text = "Health: " + health;
        emptext.text = "Disrupters: " + disrupter;

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
