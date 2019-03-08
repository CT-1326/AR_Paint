using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go : MonoBehaviour {


    public void Pgo()
    {
        SceneManager.LoadScene("Paint");
    }
    public void Vgo()
    {
        SceneManager.LoadScene("View");
    }
    public void Mgo()
    {
        SceneManager.LoadScene("Main");
    }
	
}
