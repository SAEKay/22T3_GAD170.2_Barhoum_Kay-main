using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Experimental.AI;
using UnityEngine.UI;


namespace KayBarhoum
{
    public class PlantsList : MonoBehaviour
    {
        public Text plantCaller;

        // Plant List in a Array //
        private List<string> _plantArray = new List<string>();

        private List<DataStore> Data = new List<DataStore>();

        // Max Price & Health Range for Plants //

        private int maxPrice = 15;
        private int maxHealth = 10;

        // Min Price & Health Range for Plants //    
        private int minPrice = 0;
        private int minHealth = 0;

        // Random Floats + String
        private float randomPrice;
        private float randomHealth;
        private string randomArray;
        private string store;
        // Return Floats + String

        [HideInInspector]
        public float returnPrice;
        [HideInInspector]
        public float returnHealth;
        [HideInInspector]
        public string returnArray;


        // Plant names for the list
        protected void Awake()
        {
            _plantArray.Add("Sun Flower");
            _plantArray.Add("Rose Bud");
            _plantArray.Add("White Rose");
            _plantArray.Add("Rosehip");
            _plantArray.Add("Bear paw cactus");
            _plantArray.Add("Lotus Leaf");
            _plantArray.Add("Water Lily");
            _plantArray.Add("Daisy");
            _plantArray.Add("Prim Rose");
            _plantArray.Add("Jasmine");
            _plantArray.Add("Sakura");
            _plantArray.Add("Poppy");
            _plantArray.Add("Daffodils");
            _plantArray.Add("Iris");
            _plantArray.Add("Blue Bell");
            _plantArray.Add("tigerLilly");
            _plantArray.Add("Tulp");
            _plantArray.Add("Sweet Violet");
            _plantArray.Add("China Rose");
            _plantArray.Add("Periwinkle");
            _plantArray.Add("Buttercup");
            _plantArray.Add("Marygold");
            _plantArray.Add("Snowdrop");
            _plantArray.Add("Lotus");
            _plantArray.Add("Camellia");
            _plantArray.Add("Cactus Flower");
            _plantArray.Add("Hyacinth");
            _plantArray.Add("Pansy");
            _plantArray.Add("Camomile");
            _plantArray.Add("Carnation");
            _plantArray.Add("Butterfly pea" );
            _plantArray.Add("Angel Pedal");
        }
        ///  This starts the Plant Generator! //
        protected void Update()
        {
            randomPrice = (UnityEngine.Random.Range(minPrice, maxPrice));
            randomHealth = (UnityEngine.Random.Range(minHealth, maxHealth));
            randomArray = _plantArray[UnityEngine.Random.Range(0, _plantArray.Count)]; 

        }
        // This Prints out the Text for the Text Box using the random values and strings.
        public void PlantToText()
        {
            returnArray = randomArray;
            returnPrice = randomPrice;
            returnHealth = randomHealth;
            

            plantCaller.text = " You found a " + returnArray + " worth $" + returnPrice + " Health " + returnHealth + "/10 What will you do? ".ToString();


        }

        public void AddToData()
        {
            //store == _plantArray;
           // Data.add = (_plantArray);
        }

    }
}
