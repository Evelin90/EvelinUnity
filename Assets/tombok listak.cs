using System.Collections.Generic;
using UnityEngine;

class tomboklistak : MonoBehaviour
{
    [SerializeField] int[] intArraySetting;
    [SerializeField] string[] stringArraySetting;
    [SerializeField] GameObject[] gameObjectArraySetting;

    [SerializeField] List<string> stringList;

    //[SerializeField] int[][] arrayOfArraies;  ez nem m�k�dik, mert nem tudja a t�mb�k t�mbj�t �s a m�trixot serializ�lni
    //[SerializeField] int[,] matrix;

   void OnValidate()
   {
            int a = 67;

            int[] intArray = new int[10];   //10 elemsz�m

            string[] stringArray = {"Alma", "K�rte", "Barack"};

            intArray[2] = 15; //elemre hivatkoz�s

            int element = intArray[5]; // t�mb kiolvas�sa

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
            char[] chars = "Ak�rmi".ToCharArray();
            string s2 = new string(chars);

            string s3 = s2.Substring(0, s2.Length-1); // kiv�g egy r�szt
            string s4 = s2.Replace("�", "a"); // kicser�l minden megjel�lt elemet
            string s5 = s2.ToLower(); //kisbet�re cser�l
            string s6 = s2.ToUpper(); // mindent nagybet�re cser�l
            bool contains = s2.Contains("�r"); //benne van-e a t�mbben
            int indexO = s2.IndexOf("�rm"); // megmondja az index�t

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

        List<string> strings = new List<string> {"alma", "k�rte", "ban�n"};

        bool succes = strings.Remove("k�rte"); // list�b�l t�rl�s
        strings.RemoveAt(2); // index alap� t�rl�s
        strings.Sort(); // rendez�s
        strings.Clear();
        strings.Insert(1, "eigha"); // bet�zi a megadott indexbe a megadott sz�veget

   }
    
}
