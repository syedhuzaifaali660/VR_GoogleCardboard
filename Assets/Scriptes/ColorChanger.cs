using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    public void Blue()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
    public void Green()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
}
