using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float ScreenWidth=16f;
    [SerializeField] float minScreenSize = 1f;
    [SerializeField] float maxScreenSize = 15f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = (Input.mousePosition.x) / Screen.width * ScreenWidth;
        Vector2 paddlePos = new Vector2(transform.position.x,transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minScreenSize, maxScreenSize);
        transform.position = paddlePos;
    }
}
