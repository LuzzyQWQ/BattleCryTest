using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{

    public GameObject _ui;

    // Start is called before the first frame update
    void Start()
    {
        _ui = GameObject.FindGameObjectWithTag("UI");
    }

    // Update is called once per frame
    void Update()
    {
        // 呼出隐藏UI
        if(Input.GetKeyDown(KeyCode.M))
        {
            callUI();
        }
    }

    public void callUI()
    {
        _ui.SetActive(!_ui.activeSelf);
    }
}
