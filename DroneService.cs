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
        private NumericUpDown serviceTagInput;
        public DroneServiceForm()
        {
            InitializeComponent();
            
            // Create and configure the NumericUpDown control
            serviceTagInput = new NumericUpDown();
            serviceTagInput.Minimum = 100;
            serviceTagInput.Maximum = 900;
        }
        #region Create data structures

        // 6.2 Create a global List<T> of type Drone called “FinishedList”. 
        List<Drone> FinishedList = new List<Drone>();

        // 6.3 Create a global Queue<T> of type Drone called “RegularService”.
        Queue<Drone> RegularService = new Queue<Drone>();

        // 6.4 Create a global Queue<T> of type Drone called “ExpressService”.
        Queue<Drone> ExpressService = new Queue<Drone>();
        #endregion

        #region Enqueue

        // 6.5	Create a button method called “AddNewItem” that will add a new service item
        // to a Queue<> based on the priority.
        // Use TextBoxes for the Client Name, Drone Model,Service Problem and Service Cost.
        // Use a numeric up/down control for the Service Tag.
        // The new service item will be added to the appropriate Queue based on the Priority radio button.
        private void AddNewItem_Click(object sender, EventArgs e)
        {
            Drone addDrone = new Drone();
            // Get the current service tag value, default by 100.
            int serviceTag = (int)serviceTagInput.Value;
            addDrone.setServiceTag(serviceTag);            
            addDrone.setClientName(txtClientName.Text);
            addDrone.setDroneModel(txtDroneModel.Text);
            addDrone.setServiceProblem(txtServiceProblem.Text);
            // RadioButtons selection
            int priority = GetServicePriority();            
            switch (priority)
            {
                case 1: // Add drone to regular service queue.
                    addDrone.setServiceCost(double.Parse(txtServiceCost.Text)); // ...to be fixed. decimal incorrect~~
                    RegularService.Enqueue(addDrone);
                    displayRegularQueue();                    
                    incrementServiceTag(); // Auto-increment tag after adding a new item.
                    break;

                case 2: // Add drone to express service queue. 
                    // 6.6	Before a new service item is added to the Express Queue the service cost must be increased by 15%.
                    addDrone.setServiceCost(double.Parse(txtServiceCost.Text) * 1.15);// ... emtpy input crashes 
                    ExpressService.Enqueue(addDrone);
                    displayExpressQueue();                    
                    incrementServiceTag(); // Auto-increment tag after adding a new item. 
                    break;

                default:MessageBox.Show("priority unseleted");
                    break;
            }            
            txtServiceTag.Text = addDrone.getServiceTag().ToString(); // to be fixed --- display???
            clearInput();
        }
        #endregion

        #region Dequeue
        // 6.14	Create a button click method that will remove a service item from the regular ListView and dequeue the regular service Queue<T> data structure.
        // The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void btnDequeueReg_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Item fixed?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {          
                try
                {
                    Drone finishedDrone = RegularService.Peek(); // Get the first instance.
                    FinishedList.Add(finishedDrone); // Add the first instance to the list.
                    displayListbox();
                    RegularService.Dequeue(); // Delete from queue.
                    displayRegularQueue();
                }
                catch(InvalidOperationException)
                {
                    MessageBox.Show("Queue empty.");
                }       
            }
        }

        // 6.15	Create a button click method that will remove a service item from the express ListView and dequeue the express service Queue<T> data structure.
        // The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void btnDequeueExp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Item fixed?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Drone finishedDrone = ExpressService.Peek(); // Get the first instance.
                    FinishedList.Add(finishedDrone); // Add the first instance to the list.
                    displayListbox();
                    ExpressService.Dequeue(); // Delete from queue.
                    displayExpressQueue();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Queue empty.");
                }
            }
        }
        #endregion

        #region Custom methods
        // Listbox output.
        public void displayListbox()
        {
            lbFinishedList.Items.Clear();
            for (int i = 0; i < FinishedList.Count; i++)
            {
                lbFinishedList.Items.Add(FinishedList[i].displayNameAndCost());
            }
        }

        // 6.7	Create a custom method called “GetServicePriority” which returns the value of the priority radio group.
        // This method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        public int GetServicePriority()
        {
            int priority = 0;
            if (rdoRegularService.Checked)
            {
                priority = 1;
            }
            if (rdoExpressService.Checked)
            {
                priority = 2;
            }
            return priority;
        }
        // 6.8	Create a custom method that will display all the elements in the RegularService queue.
        // The display must use a List View and with appropriate column headers.
        public void displayRegularQueue()
        {
            lvRegularQueue.Items.Clear();
            foreach (var eachDrone in RegularService)
            {
                ListViewItem item = new ListViewItem(eachDrone.getServiceTag().ToString()); // int or string?
                item.SubItems.Add(eachDrone.getClientName());
                item.SubItems.Add(eachDrone.getDroneModel());
                item.SubItems.Add(eachDrone.getServiceProblem());
                item.SubItems.Add(eachDrone.getServiceCost().ToString());
                lvRegularQueue.Items.Add(item);
            }
        }
        // 6.9	Create a custom method that will display all the elements in the ExpressService queue.
        // The display must use a List View and with appropriate column headers.
        public void displayExpressQueue()
        {
            lvExpressQueue.Items.Clear();
            foreach (var eachDrone in ExpressService)
            {
                ListViewItem item = new ListViewItem(eachDrone.getServiceTag().ToString()); // int or string?
                item.SubItems.Add(eachDrone.getClientName());
                item.SubItems.Add(eachDrone.getDroneModel());
                item.SubItems.Add(eachDrone.getServiceProblem());
                item.SubItems.Add(eachDrone.getServiceCost().ToString());
                lvExpressQueue.Items.Add(item);
            }
        }
        // 6.10	Create a custom keypress method to ensure the Service Cost textbox
        // can only accept a double value with one decimal point.
        private void txtServiceCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
    {
            e.Handled = true;
    }

    // only allow one decimal point
    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
    {
        e.Handled = true;
    }


        }
        // 6.11	Create a custom method to increment the service tag control,
        // this method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        public void incrementServiceTag()
        {            
            serviceTagInput.Value += 10;
        }

        // 6.17	Create a custom method that will clear all the textboxes after each service item has been added.
        public void clearInput()
        {
            // set all radio buttons to un-checked
            foreach (RadioButton rbo in gbServicePriority.Controls.OfType<RadioButton>())
            {
                rbo.Checked = false;
            }
            txtClientName.Clear();
            txtDroneModel.Clear();
            txtServiceProblem.Clear();
            txtServiceCost.Clear();
            txtServiceTag.Clear();
        }
        #endregion

        #region Mouse click events
        // 6.12	Create a mouse click method for the regular service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void lvRegularQueue_MouseClick(object sender, MouseEventArgs e)
        {
            Drone selectedDrone = new Drone();
            int selectedIndex = lvRegularQueue.SelectedIndices[0];
            // Setters
            selectedDrone.setClientName(lvRegularQueue.SelectedItems[0].SubItems[1].Text);
            selectedDrone.setServiceProblem(lvRegularQueue.SelectedItems[0].SubItems[3].Text);
            // Display
            txtClientName.Text = selectedDrone.getClientName();
            txtServiceProblem.Text = selectedDrone.getServiceProblem();
        }

        // 6.13	Create a mouse click method for the express service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void lvExpressQueue_MouseClick(object sender, MouseEventArgs e)
        {
            Drone selectedDrone = new Drone();
            int selectedIndex = lvExpressQueue.SelectedIndices[0];
            // Setters
            selectedDrone.setClientName(lvExpressQueue.SelectedItems[0].SubItems[1].Text);
            selectedDrone.setServiceProblem(lvExpressQueue.SelectedItems[0].SubItems[3].Text);
            // Display
            txtClientName.Text = selectedDrone.getClientName();
            txtServiceProblem.Text = selectedDrone.getServiceProblem();
        }        

        // 6.16	Create a double mouse click method that will delete a service item from the finished listbox and remove the same item from the List<T>.
        private void lbFinishedList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = lbFinishedList.SelectedIndices[0];
            DialogResult result = MessageBox.Show("Do you want to remove the item?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {                
                FinishedList.RemoveAt(selectedIndex);
                displayListbox();
            }
        }
        #endregion        
    }
}
