using UnityEngine;
using UnityEngine.UI;
using support;

public class ButtonTest : MonoBehaviour {

	// Use this for initialization
    public Button btn;
	void Start ()
    {
        NotificationCenter.getInstance().addObserver("testEvent3", callBackHandler5);
        btn.onClick.AddListener(clickHandler);
	}

    private void callBackHandler5(object param)
    {
        print("callBackHandler5");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void clickHandler()
    {
        NotificationCenter.getInstance().postNotification("testEvent3", new Object());
    }
}
