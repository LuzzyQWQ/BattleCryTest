using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public List<CubeUIunit> cubeList;
    private static int num;
    public Transform content;
    public GameObject _prefabOperator;
    public int CreateNum { get; set; }
    //

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScrollView()
    {

        GameObject t = GameObject.Instantiate(_prefabOperator, content);


    }

}
