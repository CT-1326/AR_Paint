using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eraser : MonoBehaviour {

    GameObject go;
    

    public void ER()
    {      
       go = GameObject.Find("Draw(Clone)");
       Destroy(go);
    }
}
