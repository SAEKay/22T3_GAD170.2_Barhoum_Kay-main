using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 namespace KayBarhoum
{
    public class DataStore : MonoBehaviour
    {
        private string Plant;
        private int _price;
        private int _health;
        
        public DataStore(string NewP, int price, int health)
        {
            Plant = NewP;
            _price = price; 
            _health = health;

        }

     
    }

}
