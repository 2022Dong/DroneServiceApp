using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroneServiceApp
{
    public partial class DroneServiceForm : Form
    {
        public DroneServiceForm()
        {
            InitializeComponent();
        }

        // 6.2 Create a global List<T> of type Drone called “FinishedList”. 
        List<Drone> FinishedList = new List<Drone>();

        // 6.3 Create a global Queue<T> of type Drone called “RegularService”.
        Queue<Drone> RegularService = new Queue<Drone>();

        // 6.4 Create a global Queue<T> of type Drone called “ExpressService”.
        Queue<Drone> ExpressService = new Queue<Drone>();

        // 6.5	Create a button method called “AddNewItem” that will add a new service item
        // to a Queue<> based on the priority.
        // Use TextBoxes for the Client Name, Drone Model,Service Problem and Service Cost.
        // Use a numeric up/down control for the Service Tag.
        // The new service item will be added to the appropriate Queue based on the Priority radio button.
        private void AddNewItem_Click(object sender, EventArgs e)
        {
            GetServicePriority();
            // ...
        }
        // 6.6	Before a new service item is added to the Express Queue the service cost must be increased by 15%.
        #region Custom methods
        // 6.7	Create a custom method called “GetServicePriority” which returns the value of the priority radio group.
        // This method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        public int GetServicePriority()
        {
            return 0;
        }
        // 6.8	Create a custom method that will display all the elements in the RegularService queue.
        // The display must use a List View and with appropriate column headers.
        public void displayRegularQueue()
        {

        }
        // 6.9	Create a custom method that will display all the elements in the ExpressService queue.
        // The display must use a List View and with appropriate column headers.
        public void displayExpressQueue()
        {

        }
        // 6.10	Create a custom keypress method to ensure the Service Cost textbox
        // can only accept a double value with one decimal point.
        public double keypressServiceCost()
        {
            return 0.0;
        }
        // 6.11	Create a custom method to increment the service tag control,
        // this method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        public int incrementServiceTag()
        {
            return 0;
        }
        // 6.17	Create a custom method that will clear all the textboxes after each service item has been added.
        public void clearInput()
        {

        }
        #endregion

        #region Mouse click events
        // 6.12	Create a mouse click method for the regular service ListView that will display the Client Name and Service Problem in the related textboxes.

        // 6.13	Create a mouse click method for the express service ListView that will display the Client Name and Service Problem in the related textboxes.

        // 6.14	Create a button click method that will remove a service item from the regular ListView and dequeue the regular service Queue<T> data structure.
        // The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.

        // 6.15	Create a button click method that will remove a service item from the express ListView and dequeue the express service Queue<T> data structure.
        // The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.

        // 6.16	Create a double mouse click method that will delete a service item from the finished listbox and remove the same item from the List<T>.
        //
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
