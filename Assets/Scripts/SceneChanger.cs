using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    void Start()
    {
      
        
    }

    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
