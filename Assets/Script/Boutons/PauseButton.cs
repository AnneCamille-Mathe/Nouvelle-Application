﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PauseButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    //variables
    [HideInInspector]
    public bool Pressed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    public void OnPointerDown(PointerEventData eventData)
    {
        GameObject.Find("CanvasPause").GetComponent<MenuPause>().testBug = true;
        Pressed = true;
    }

    
    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
    
}
