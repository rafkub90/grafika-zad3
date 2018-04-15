using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPiramid : MonoBehaviour
{

    public GameObject cube;
    public GameObject position;


    int rows = 5;
    float space = 0.6f;

    // Use this for initialization
    void Start()
    {



        DoPodstawa();

        //Instantiate(cube).transform.position = new Vector3(i, j, k);


    }

    void DoPodstawa()
    {

        //GameObject.FindGameObjectsWithTag("mid")transform.position;
        //float x, y, z;
        //x = position.transform.position.x;
        //y = position.transform.position.z;
        //z = position.transform.position.z;

        int x = 4;
        int y = 9;
        for (int i = x; i < y; i++)
        {
            

            for (int j = x; j < y; j++)
            {
                
                GameObject Nowy2 = Instantiate(cube, new Vector3(i, 1, j), Quaternion.identity);
                Nowy2.name = "t" + i + j;
                var springJoint = Nowy2.GetComponent<Rigidbody>();


                    //= GameObject.Find("t" + i + j)
                for (int k = 0; k < 3; k++)
                {
                    
                   

                }
            }

        }
        //for (int i = 5; i < 8; i++)
        //{
        //    GameObject Nowy3 = Instantiate(cube, new Vector3(i, 1, 5), Quaternion.identity);
        //    Nowy3.name = "t" + 11 + i;

        //    for (int j = 5; j < 8; j++)
        //    {
        //        GameObject Nowy4 = Instantiate(cube, new Vector3(i, 1, j), Quaternion.identity);
        //        Nowy4.name = "t" + 11 + i + j;



        //    }

        //}
        //GameObject Nowy5 = Instantiate(cube, new Vector3(6, 2, 6), Quaternion.identity);
        //Nowy5.name = "t622";



    }




    //Instantiate(cube).transform.position = new Vector3(x, y, z);



}
