using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowCylinder : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform parentT;
    public float height;
    public float radius;


    // Start is called before the first frame update
    void Start()
    {
        height = 0.14f;
        radius = 0.14f;

        for (int i = 0; i < 360; i += 30) //This is phi (360 degrees)
        {
            for (int j = 0; j < 2*height*100; j += 2) //This goes down the side (s=constant)
            {
                for (int k = 0; k < radius * 100; k += 2) //This goes across the top (z=constant)
                {
                    //Create the arrows, three layers
                    var arrow = Instantiate<GameObject>(arrowPrefab, parentT);
                    var arrow2 = Instantiate<GameObject>(arrowPrefab, parentT);
                    var arrow3 = Instantiate<GameObject>(arrowPrefab, parentT);

                    //Define the direction of each arrow in this nested loop
                    Vector3 arrowDirTop = new Vector3(0.001f * k * Mathf.Cos(i * Mathf.Deg2Rad), 0.001f * k * Mathf.Sin(i * Mathf.Deg2Rad), height);
                    Vector3 arrowDirSide = new Vector3(1.01f * radius, 1.01f * radius, height - 0.001f * j);

                    //Translate defines how far they are from the center of the parent object (the sphere)
                    arrow.transform.Translate(0.2f * arrowDirTop);
                    arrow2.transform.Translate(0.2f * arrowDirSide);
                    arrow3.transform.Translate(-0.2f * arrowDirTop);

                    //Local scale will set the size of the arrow as a fraction of the prefab arrow size
                    arrow.transform.localScale = new Vector3(.20f, .20f, .20f);
                    arrow2.transform.localScale = new Vector3(.20f, .20f, .20f);
                    arrow3.transform.localScale = new Vector3(.20f, .20f, .20f);

                    arrow.transform.LookAt(parentT);
                    arrow2.transform.LookAt(parentT);
                    arrow3.transform.LookAt(parentT);

                    //arrow.transform.Rotate(Mathf.Sin(j*Mathf.Deg2Rad)*Mathf.Cos(i * Mathf.Deg2Rad),Mathf.Sin(j * Mathf.Deg2Rad) * Mathf.Sin(i * Mathf.Deg2Rad),Mathf.Cos(j * Mathf.Deg2Rad));
                    //arrow.transform.localEulerAngles = new Vector3(Mathf.Sin(j*Mathf.Deg2Rad)*Mathf.Cos(i * Mathf.Deg2Rad),Mathf.Sin(j * Mathf.Deg2Rad) * Mathf.Sin(i * Mathf.Deg2Rad),Mathf.Cos(j * Mathf.Deg2Rad));
                }


                // THIS DOES NOT WORK!
                //This will access the color and transparency of the arrow and change the value 
                //var trans2 = 0.5f;
                //var col2 = arrow2.GetComponent<Renderer>().material.color;
                //col2.a = trans2;

                //var trans3 = 0.25f;
                //var col3 = arrow3.GetComponent<Renderer>().material.color;
                //col3.a = trans3;

                //var color2 = arrow2.GetComponent<MeshRenderer>().material.color;
                //color2.a = trans3;

                
            }

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}