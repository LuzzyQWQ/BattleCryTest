using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeObject : MonoBehaviour
{

    private Boolean _colorChange;
    private Renderer _renderer;
    private Color _originColor;
    private void Awake()
    {
        _colorChange = false;
        _renderer = gameObject.GetComponent<Renderer>();
        
    }

    private void Start()
    {
        _originColor = _renderer.material.color;
    }
    // 指针悬停时

    private void OnMouseOver()
    {
        if(EventSystem.current.IsPointerOverGameObject() == false)   
            _colorChange = true;
    }

    // 鼠标离开
    private void OnMouseExit()
    {
        _colorChange = false;
    }
    private void Update()
    {
        if(_colorChange)
        {
            _renderer.material.color = Color.Lerp(Color.black, _originColor, Mathf.PingPong(Time.time, 1));
        }else
        {
            _renderer.material.color = _originColor;
        }
    }

}
