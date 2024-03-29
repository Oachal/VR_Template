using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowCube : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform parentT;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 360; i += 12) //This is phi
        {
            for (int j = 0; j < 180; j += 12) //This is theta
            {
                //Create the arrows, three layers
                var arrow = Instantiate<GameObject>(arrowPrefab, parentT);
                var arrow2 = Instantiate<GameObject>(arrowPrefab, parentT);
                var arrow3 = Instantiate<GameObject>(arrowPrefab, parentT);
                
                //Define the direction of each arrow in this nested loop
                Vector3 arrowDir = new Vector3(Mathf.Sin(j * Mathf.Deg2Rad) * Mathf.Cos(i * Mathf.Deg2Rad), Mathf.Sin(j * Mathf.Deg2Rad) * Mathf.Sin(i * Mathf.Deg2Rad), Mathf.Cos(j * Mathf.Deg2Rad));
                
                //Translate defines how far they are from the center of the parent object (the sphere)
                arrow.transform.Translate(0.07f * arrowDir);
                arrow2.transform.Translate(0.10f * arrowDir);
                arrow3.transform.Translate(0.15f * arrowDir);
                
                //Local scale will set the size of the arrow as a fraction of the prefab arrow size
                arrow.transform.localScale = new Vector3(.20f, .20f, .20f);
                arrow2.transform.localScale = new Vector3(.15f, .15f, .15f);
                arrow3.transform.localScale = new Vector3(.05f, .05f, .05f);

                //arrow.transform.Rotate(Mathf.Sin(j*Mathf.Deg2Rad)*Mathf.Cos(i * Mathf.Deg2Rad),Mathf.Sin(j * Mathf.Deg2Rad) * Mathf.Sin(i * Mathf.Deg2Rad),Mathf.Cos(j * Mathf.Deg2Rad));
                //arrow.transform.localEulerAngles = new Vector3(Mathf.Sin(j*Mathf.Deg2Rad)*Mathf.Cos(i * Mathf.Deg2Rad),Mathf.Sin(j * Mathf.Deg2Rad) * Mathf.Sin(i * Mathf.Deg2Rad),Mathf.Cos(j * Mathf.Deg2Rad));



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

                arrow.transform.LookAt(parentT);
                arrow2.transform.LookAt(parentT);
                arrow3.transform.LookAt(parentT);
            }

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}