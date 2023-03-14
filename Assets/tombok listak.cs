using System.Collections.Generic;
using UnityEngine;

class tomboklistak : MonoBehaviour
{
    [SerializeField] int[] intArraySetting;
    [SerializeField] string[] stringArraySetting;
    [SerializeField] GameObject[] gameObjectArraySetting;

    [SerializeField] List<string> stringList;

    //[SerializeField] int[][] arrayOfArraies;  ez nem mûködik, mert nem tudja a tömbök tömbjét és a mátrixot serializálni
    //[SerializeField] int[,] matrix;

   void OnValidate()
   {
            int a = 67;

            int[] intArray = new int[10];   //10 elemszám

            string[] stringArray = {"Alma", "Körte", "Barack"};

            intArray[2] = 15; //elemre hivatkozás

            int element = intArray[5]; // tömb kiolvasása

            //int e2 = intArray[10];  ilyen nincsen

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i + 1;
            }
            for (int i = 0; i < gameObjectArraySetting.Length; i++)
            {
                Debug.Log(gameObjectArraySetting[i]);
            }

            char myFirstChar = '*';
            char[] chars = "Akármi".ToCharArray();
            string s2 = new string(chars);

            string s3 = s2.Substring(0, s2.Length-1); // kivág egy részt
            string s4 = s2.Replace("á", "a"); // kicserél minden megjelölt elemet
            string s5 = s2.ToLower(); //kisbetûre cserél
            string s6 = s2.ToUpper(); // mindent nagybetûre cserél
            bool contains = s2.Contains("ár"); //benne van-e a tömbben
            int indexO = s2.IndexOf("árm"); // megmondja az indexét

        List<int> ints = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            ints.Add(i * i);
        }

        Debug.Log(ints.Count);

        for (int i = 0; i < ints.Count; i++)
        {
            Debug.Log(ints[i]);
        }

        List<string> strings = new List<string> {"alma", "körte", "banán"};

        bool succes = strings.Remove("körte"); // listából törlés
        strings.RemoveAt(2); // index alapú törlés
        strings.Sort(); // rendezés
        strings.Clear();
        strings.Insert(1, "eigha"); // betûzi a megadott indexbe a megadott szöveget

   }
    
}
