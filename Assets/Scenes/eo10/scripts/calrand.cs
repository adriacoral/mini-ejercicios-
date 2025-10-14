using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float nrand;
    public string operacion;

    void Start()
    {
        float result = 0f;
        switch (operacion)
        {
            case "+":
                result = nrand + nrand;
                Debug.Log(result);
                break;

            case "-":
                result = nrand - nrand;
                Debug.Log(result);
                break;

            case "*":
                result = nrand * nrand;
                Debug.Log(result);
                break;


            case "/":
                result = nrand / nrand;
                Debug.Log(result);
                break;



        }


        nrand = Random.Range(10, -10);

    }
}

