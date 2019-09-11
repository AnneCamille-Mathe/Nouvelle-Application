﻿using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Text;

public class InsertFolderScript : MonoBehaviour 
{
    public string filePath = "";
    public Texture2D texture;
    public GameObject m_goCube;

    // Use this for initialization
    void Start () 
    {
        m_goCube = GameObject.Find ("Cube");
    }
	
    // Update is called once per frame
    void Update () 
    {
    }

    void OnGUI ()
    {
        GUIStyle mybutton = new GUIStyle(GUI.skin.button);
        mybutton.fontSize = 50;
        
        if (GUI.Button (new Rect (500, 700, 400, 100), "Select Folder", mybutton))
        {

#if UNITY_EDITOR
            filePath = EditorUtility.OpenFilePanel ("Overwrite with png"
                , Application.streamingAssetsPath
                , "png");
            
            
#endif
            /*
            if (filePath.Length! = 0)
            {
                WWW www = new WWW ("file: //" + filePath);
                texture = new Texture2D (64, 64);
                www.LoadImageIntoTexture (texture);
                m_goCube.renderer.material.mainTexture = texture;
            }
            */
        }
    }

    public void OpenFilePanel ()
    {
		
    }
}