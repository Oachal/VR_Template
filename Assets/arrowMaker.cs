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
        for (int i=0; i<360; i+=36)
        {
            var arrow = Instantiate<GameObject>(arrowPrefab, parentT);
            arrow.transform.Translate(Mathf.Cos(i*Mathf.Deg2Rad),Mathf.Sin(i * Mathf.Deg2Rad),0);
            //arrow.transform.Rotate();
            //arrow.transform.localEulerAngles = vector(0, 0, 0);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
