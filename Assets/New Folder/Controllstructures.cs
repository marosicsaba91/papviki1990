
using UnityEngine;

public class Controllstructures : MonoBehaviour
{
    [SerializeField] int number;
    void Start()
    {
        int number = 12;

        if (number >= 10)
        {
            Debug.Log("T�bbjegy� sz�m");
        }
        else
        {
            Debug.Log("Egyjegy� sz�m");
        }


        if (number > 0)
        {
            Debug.Log("Pozit�v sz�m");
        }
        else
        {
            Debug.Log("Negat�v sz�m");
        }

        // El�gaz�s
        if (number > 0)
        {
            Debug.Log("Pozit�v sz�m");
        }
        else if (number < 0)
        {
            Debug.Log("Negat�v sz�m");
        }
        else
        {
            Debug.Log("A sz�m nulla");
        }

        // -------------------

        if (number % 2 == 0)

            Debug.Log("P�ROS");

        else

            Debug.Log("P�RATLAN");


        // ---------------------

        bool isEven;

        if (number % 2 == 0)
            isEven = true;
        else
            isEven = false;

        string pairity;
        if (number % 2 == 0)
            pairity = "EVEN";
        else
            pairity = "ODD";

        pairity = number % 2 == 0 ? "EVEN" : "ODD";

        // --------------------------

        int i = 1;

        while (i <= 100)
        {
            Debug.Log(i * i);
            i++;
        }

        for (int j = 100; j > 0; j--)
        {
            Debug.Log(j * j);
       

        }

        int k = 1;
        do
        {
            Debug.Log(k * k);
            k++;

        } while (k <= 100);

    }
}