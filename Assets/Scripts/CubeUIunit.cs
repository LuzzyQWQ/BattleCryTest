using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeUIunit : MonoBehaviour
{
    public Text[] text;
    public GameObject targetCube;
    public GameObject _targetIns;

    public MenuManager MenuManager;
    public Text Name;
    public Button DeleteButton;

    // Update is called once per frame
    private void Awake()
    {
        MenuManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<MenuManager>();
    }
    private void Start()
    {
        CreateCubeInstance();
    }
    public void changePos(Vector3 vec) 
    {
        text[0].text = vec.x.ToString("f1");
        text[1].text = vec.y.ToString("f1");
        text[2].text = vec.z.ToString("f1");
    }
    public void UpdateName(string name)
    {
        Name.text = name;
    }
    public void CreateCubeInstance()
    {
        Vector3 newPos = new Vector3(Random.Range(-3f, 3f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        targetCube = Instantiate(_targetIns);
        targetCube.name = "Cube" + Random.Range(0,100).ToString();
        UpdateName(targetCube.name);
        targetCube.transform.position = newPos;
        changePos(newPos);
        // 添加按钮事件
        DeleteButton.onClick.AddListener(DeleteCube);

    }

    public void DeleteCube()
    {
        if (targetCube != null)
            Destroy(targetCube);
        Destroy(this.gameObject);
    }

}
