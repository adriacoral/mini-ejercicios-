using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class rond : MonoBehaviour
{
    public int nrand;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nrand = Random.Range(10, -10);
        print (nrand);
    }
}
