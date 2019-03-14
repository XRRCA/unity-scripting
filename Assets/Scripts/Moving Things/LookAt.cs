using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

    public Transform target;
	
    public enum LookType
    {
        LookAt, LookRotation, DontLook
    }

    public LookType method;
	// Update is called once per frame
	void Update () {
        if(method == LookType.LookAt)
        {
            // TODO use Transforms LookAt method
        }
            
        else if (method == LookType.LookRotation)
        {
            // TODO Copmute a direction verctor and use
            // transform.rotation = Quaternion.LookRotation(directionVector)
        }
            
	}
}
