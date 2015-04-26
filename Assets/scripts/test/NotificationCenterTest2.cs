using UnityEngine;
using System.Collections;
using support;

public class NotificationCenterTest2 : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        NotificationCenter.getInstance().addObserver("testEvent", callBackHandler4);
	}

    private void callBackHandler4(object param)
    {
        print("callBackHandler4");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
