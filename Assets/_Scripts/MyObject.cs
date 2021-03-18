using UnityEngine;

public class MyObject : MonoBehaviour
{

    public void MyMethod(string parametro)
    {
        Debug.Log(parametro);
    }

    public void Exit()
    {
        Application.Quit();
    }
}