﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneServiceApp
{
    // 6.1	Create a separate class file to hold the data items of the Drone.
    // Use separate getter and setter methods, ensure the attributes are private
    // and the accessor methods are public. 
    internal class Drone
    {
        // Private Attributes.
        private int serviceTag;
        private string clientName;
        private string droneModel;
        private string serviceProblem;
        private double serviceCost;

        #region Setters
        public void setServiceTag(int newServiceTag)  // To be fixed.
        {
            serviceTag = newServiceTag;
        }
        public void setClientName(string newClientName)
        {
            // The data is formatted as Title case.
            clientName = newClientName;  // To be fixed.  ToTitleCase(newClientName.ToLower())
        }
        public void setDroneModel(string newDroneModel)
        {
            droneModel = newDroneModel;
        }
        public void setServiceProblem(string newServiceProblem)
        {
            // the data is formatted as Sentence case.
            serviceProblem = newServiceProblem;  // To be fixed.
        }
        public void setServiceCost(double newServiceCost) // To be fixed.
        {
            serviceCost = newServiceCost;
        }
        #endregion
        #region Getters
        public int getServiceTag()
        {
            return serviceTag;
        }
        public string getClientName()
        {
            return clientName;
        }
        public string getDroneModel()
        {
            return droneModel;
        }
        public string getServiceProblem()
        {
            return serviceProblem;
        }
        public double getServiceCost()
        {
            return serviceCost;
        }
        #endregion

        // Constructor
        Drone()
        {}

        // Add a display method that returns a string for Client Name and Service Cost
        public string displayNameAndCost()
        {
            return clientName + " $" + serviceCost;
        }

    }
}