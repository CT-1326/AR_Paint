using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class View : MonoBehaviour
{
    public RawImage img;
    public GameObject sc;
    public GameObject scp;
    string[] fName;

    // Start is called before the first frame update
    void Start()
    {
        fName = Directory.GetFiles("/storage/emulated/0/DCIM/AR_paint/", "*.png");
        for (int i = 0; i < fName.Length; i++)
        {
            go(i);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }


    void go(int a)
    {
        string myFolderLocation = "/storage/emulated/0/DCIM/AR_paint/";
        DirectoryInfo di = new DirectoryInfo(myFolderLocation);
        FileInfo[] f = di.GetFiles();
        string myFilename = f[a].Name;
        string myScreenshotLocation = myFolderLocation + myFilename;

        byte[] pt = File.ReadAllBytes(myScreenshotLocation);
        Texture2D tx = new Texture2D(Screen.width, Screen.height);
        tx.LoadImage(pt);
        img.texture = tx;

        GameObject so = Instantiate(scp);
        so.transform.SetParent(sc.transform, false);
    }
}
