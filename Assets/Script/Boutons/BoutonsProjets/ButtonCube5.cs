﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class ButtonCube5 : MonoBehaviour
{
    //Variables
    private int nbScenes;
    private String LevelToLoad;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClic()
    {
        if (ES2.Exists("sceneACharger8"))
        {
            LevelToLoad = ES2.Load<string>("sceneACharger8");
            SceneManager.LoadScene(LevelToLoad); }

    }
}