using UnityEngine;

public class TestScript : MonoBehaviour
{
    private float coffeeTemperature = 85.0f;
    private float hotLimitTemperature = 70.0f;
    private float coldLimitTemperature = 40.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
            print("coffee is too hot.");
        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("coffee is too cold.");
        }
    }
}

