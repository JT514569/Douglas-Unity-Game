using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public void Main()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("hi");
    }


}