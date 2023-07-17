using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowMaker : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform parentT;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 360; i += 36) //This is phi
        {
            for (int j = 0; j < 180; j += 36) //This is theta
            {
                var arrow = Instantiate<GameObject>(arrowPrefab, parentT);
                Vector3 arrowDir = new Vector3(Mathf.Sin(j * Mathf.Deg2Rad) * Mathf.Cos(i * Mathf.Deg2Rad), Mathf.Sin(j * Mathf.Deg2Rad) * Mathf.Sin(i * Mathf.Deg2Rad), Mathf.Cos(j * Mathf.Deg2Rad));
                arrow.transform.Translate(0.5f * arrowDir);
                var arrow2 = Instantiate<GameObject>(arrowPrefab, parentT);
                arrow2.transform.Translate(arrowDir);
                //arrow.transform.Rotate(Mathf.Sin(j*Mathf.Deg2Rad)*Mathf.Cos(i * Mathf.Deg2Rad),Mathf.Sin(j * Mathf.Deg2Rad) * Mathf.Sin(i * Mathf.Deg2Rad),Mathf.Cos(j * Mathf.Deg2Rad));
                //arrow.transform.localEulerAngles = new Vector3(Mathf.Sin(j*Mathf.Deg2Rad)*Mathf.Cos(i * Mathf.Deg2Rad),Mathf.Sin(j * Mathf.Deg2Rad) * Mathf.Sin(i * Mathf.Deg2Rad),Mathf.Cos(j * Mathf.Deg2Rad));
                arrow.transform.LookAt(parentT);
                arrow2.transform.LookAt(parentT);
            }

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}