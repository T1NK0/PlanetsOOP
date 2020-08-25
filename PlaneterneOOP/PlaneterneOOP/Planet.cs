using System;
using System.Collections.Generic;
using System.Text;

namespace PlaneterneOOP
{
    class Planet
    {
        #region planetVariables
        //Hides the values away for the users by making it private. This is what we call incapsulation.
        private string name;
        private double mass;
        private int diameter;
        private int density;
        private double gravity;
        private double rotationPeriod;
        private double lengthOfDays;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private int meanTemperature;
        private int numberOfMoons;
        private bool ringSystem;
        #endregion

        #region planetGetSets
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }
        public int Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
        public int Density
        {
            get { return density; }
            set { density = value; }
        }
        public double Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }
        public double RotationPeriod
        {
            get { return rotationPeriod; }
            set { rotationPeriod = value; }
        }
        public double LengthOfDay
        {
            get { return lengthOfDays; }
            set { lengthOfDays = value; }
        }
        public double DistanceFromTheSun
        {
            get { return distanceFromSun; }
            set { distanceFromSun = value; }
        }
        public double OrbitalPeriod
        {
            get { return orbitalPeriod; }
            set { orbitalPeriod = value; }
        }
        public double OrbitalVelocity
        {
            get { return orbitalVelocity; }
            set { orbitalVelocity = value; }
        }
        public int MeanTemperature
        {
            get { return meanTemperature; }
            set { meanTemperature = value; }
        }
        public int NumberOfMoons
        {
            get { return numberOfMoons; }
            set { numberOfMoons = value; }
        }
        public bool RingSystem
        {
            get { return ringSystem; }
            set { ringSystem = value; }
        }
        #endregion


        #region planetObject
        //The constructor is where we make our standard values. For instance these are the requirements to make a planet.
        public Planet(string planetName, double planetMass, int planetDiameter, int planetDensity, double planetGravity, double planetRotationPeriod, double planetLengthOfDays, double planetDistanceFromSun, double planetOrbitalPeriod, double planetOrbitalVelocity, int planetMeanTemperature, int planetNumberOfMoons, bool planetRingSystem)
        {
            name = planetName;
            mass = planetMass;
            diameter = planetDiameter;
            density = planetDensity;
            gravity = planetGravity;
            rotationPeriod = planetRotationPeriod;
            lengthOfDays = planetLengthOfDays;
            distanceFromSun = planetDistanceFromSun;
            orbitalPeriod = planetOrbitalPeriod;
            orbitalVelocity = planetOrbitalVelocity;
            meanTemperature = planetMeanTemperature;
            numberOfMoons = planetNumberOfMoons;
            ringSystem = planetRingSystem;
        }
#endregion
    }
}
