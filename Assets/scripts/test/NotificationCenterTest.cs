using UnityEngine;
using System.Collections;
using support;

public class NotificationCenterTest : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        //会打印两条消息
        NotificationCenter.getInstance().addObserver("testEvent", callBackHandler1);
        NotificationCenter.getInstance().addObserver("testEvent", callBackHandler2);
        NotificationCenter.getInstance().postNotification("testEvent", new GameObject().name = "testParams");

        //不会打印
        NotificationCenter.getInstance().addObserver("testEvent2", callBackHandler3);
        NotificationCenter.getInstance().removeObserver("testEvent2");
        NotificationCenter.getInstance().postNotification("testEvent2");

        //不会打印
        //NotificationCenter.getInstance().removeObservers();
        //NotificationCenter.getInstance().postNotification("testEvent", new GameObject());
	}

    private void callBackHandler3(object param)
    {
        print("callBackHandler3");
    }

    private void callBackHandler2(object param)
    {
        print("callBackHandler2");
    }
	
    void callBackHandler1(object param)
    {
        print("callBackHandler1");
    }

    // Update is called once per frame
    void Update()
    {

    }

}
