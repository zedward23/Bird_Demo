using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoticeScreen : MonoBehaviour
{
    public Text message;

    public Text balance_txt;

    public Vendor active_vendor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void close()
    {
        gameObject.transform.position = new Vector3(-1500, 0, 0);
        balance_txt.color = Color.black;
    }

    public void open(string msg)
    {
        this.message.text = msg;
        gameObject.transform.position = new Vector3(960, 540, 0);
    }

    public void tryToBuy()
    {
        active_vendor.tryToBuy();
    }
}
