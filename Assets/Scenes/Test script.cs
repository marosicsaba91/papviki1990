using UnityEngine;

 class Testscript : MonoBehaviour
{
    void Start()
    {

        // Szia! Viki vagyok

        /*Komment */

        /* T�bb
         * Soros
         * Komment*/

        Debug.Log("Hello Unity!");
        Debug.Log($"Hello {name}!");

        // ----------------------

        // V�ltoz�k
        int myFirstVariable = 76;
        Debug.Log(myFirstVariable); //76
        myFirstVariable = 7;
        Debug.Log(myFirstVariable);

        int myInt = 5; // Integer = Eg�sz sz�m
        float myFloat = 46.67f; // Floating Point = Tizedes t�rt sz�m
        string myText = "iuvhih"; // String = Sz�veg
        bool myBool1 = true; // Logical type = Eld�ntend� t�pus
        bool myBool2 = false;
        myBool2 = true;

    }
}