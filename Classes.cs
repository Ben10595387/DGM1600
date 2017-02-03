// classes are used as a way to organize code, the 
//video said that usually each class is done as it's own 
// file, especially if it is done with someone else. 
using UnityEngine;
using System.Collections;

public class classes: MonoBehavior
{
    int score = 0;

    public class cats 
    {
       public int shortHair = 1;
       public int longHair = 2; 
       public int tabby = 1;
       public int angryCat = 1000000; 
    }

    public class cats(int sh, int lo, int tab, int angc)
    {
        shortHair = sh
        longHair = lo 
        tabby = tab
        angryCat = angc 

    }

    public class cats claws 
    {
    public sh claws= 1
    public lo = 2
    public tab = 3
    public angryCat = 20
     }  

}