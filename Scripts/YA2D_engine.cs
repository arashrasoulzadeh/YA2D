//version 0.1
//by Arash Rasoulzadeh
//contact me : arashrasoulzadeh@gmail.com


using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEditor;

[Serializable]
public class YA2D_engine : ScriptableObject
{
        public static float ver = 0.1f;


    [MenuItem("YA2D/Create/Side Scroll Camera")]
    public static void createSideScrollCamera()
    {
 

        GameObject a = new GameObject();
        a.AddComponent<Camera>();
        a.AddComponent<YA2D_sidescrollcamera>();
        a.name = "side Scroll Camera";
 
        //  Instantiate(a);


    }

 
    [MenuItem("YA2D/About")]
	public static void About()
    {
        EditorUtility.DisplayDialog("YA2D","Yet another 2D framework. \n\n arashrasoulzadeh@gmail.com \n\nversion:"+ver,"okay");
    }
}