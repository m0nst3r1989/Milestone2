using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_FInder
{
    public partial class Form1 : Form
    {
        
    public Form1()
    {
        InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e)
        {
        //Adds items to first combo box
        productNamBox.Items.Add("Resistors");
        productNamBox.Items.Add("Capacitors");
        productNamBox.Items.Add("Transistors");

        }

    private void searchBtn_Click(object sender, EventArgs e)
        {
        this.Hide();
        Form2 form2 = new Form2();
        form2.ShowDialog();
        }

    private void exitBtn_Click(object sender, EventArgs e)
        {

        this.Close();

        }
        public void productNumBox_SelectedIndexChanged(object sender, EventArgs e)
        {
      

            
        }
    }
}
