using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Text;
using System;

public class Tst : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        int x = 1;
        int y = 2;

        string progToRun = "Assets\\Scripts\\tst.py";
        char[] spliter = { '\r' };

        Process proc = new Process();
        proc.StartInfo.FileName = "python.exe";
        proc.StartInfo.RedirectStandardOutput = true;
        proc.StartInfo.UseShellExecute = false;
        //call hello.py to concatenate passed parameters
        proc.StartInfo.Arguments = string.Concat(progToRun, " ", x.ToString(), " ", y.ToString());
        proc.Start();
        StreamReader sReader = proc.StandardOutput;
        string[] output = sReader.ReadToEnd().Split(spliter);

        /*foreach (string s in output)
            Console.WriteLine(s);*/

        proc.WaitForExit();
    }
}
