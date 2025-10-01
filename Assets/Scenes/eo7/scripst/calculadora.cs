using UnityEngine;

public class calculadora : MonoBehaviour
{
    public float Nentero1 = 0.1f;
    public string operacion;
    public float Nentero2 = 0.1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float result = 0f;
        switch (operacion)
        {
            case "+":
                result = Nentero1 + Nentero2;
                Debug.Log(result);
                break;

            case "-":
                result = Nentero1 - Nentero2;
                Debug.Log(result);
                break;

            case "*":
                result = Nentero1 * Nentero2;
                Debug.Log(result);
                break;


            case "/":
                result = Nentero1 / Nentero2;
                Debug.Log(result);
                break;

               case "%":   
                result = Nentero1 % Nentero2;
                Debug.Log(result);
                break;


                
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}