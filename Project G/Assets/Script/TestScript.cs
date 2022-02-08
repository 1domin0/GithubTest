using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Light sun;
    void Start()
    {
        //Bubble sort
        int[] x = new int[] {1,9,4,8,3,7,2,5,6};
        int y;
        for (int i = 0; i < x.Length - 1; i++)
        {
            for (int j = 0; j < x.Length - 1; j++)
            {
                if (x[j] > x[j + 1])
                {
                    y = x[j + 1];
                    x[j + 1] = x[j];
                    x[j] = y;
                }
            }
        }
        for (int i = 0; i < x.Length; i++)
        {
            print(x[i]);
        }
        print("test");
        //sun.enabled = false;
    }

}
