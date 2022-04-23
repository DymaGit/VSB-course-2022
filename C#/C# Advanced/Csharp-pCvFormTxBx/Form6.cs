using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MyLibrary;
namespace FormTextBox {
    public partial class Form6 : Form {
        //public string lastValidText1 = "";
        //public string lastValidText2 = "";

        Hashtable lastValidText = new Hashtable();
        Calculator c1 = new Calculator();
        public Form6() {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e) {


            if (tb1.Text == "") tb1.Text = "0";
            if (tb2.Text == "") tb2.Text = "0";


            int a = int.Parse(tb1.Text);
            int b = int.Parse(tb2.Text);
            int result = c1.secti(a, b);
            tb3.Text = Convert.ToString(result);

        }
        //public int secti(int a, int b) {

        //    //double a = Convert.ToDouble(tb1.Text);
        //    //double b = Convert.ToDouble(tb2.Text);
        //    //tb3.Text = Convert.ToString(a + b);
        //    return a + b;
        //}

        //private void tb1_TextChanged(object sender, EventArgs e) {
        //    // moje řešení
        //    //if (tb1.Text == "") tb1.Text = "0";



        //    try {
        //        int a = int.Parse(tb1.Text);
        //        lastValidText1 = tb1.Text;
        //    }
        //    catch (Exception) {
        //        tb1.Text = lastValidText1;
        //        tb1.SelectionStart = tb1.TextLength;
        //    }
        //}

        private void tb_TextChanged(object sender, EventArgs e) {
            // moje řešení
            if (tb2.Text == "") tb2.Text = "0";// tb2.SelectionStart = tb2.TextLength;
            if (tb1.Text == "") tb1.Text = "0";// tb1.SelectionStart = tb1.TextLength;
            TextBox tbo = (TextBox)sender;


            if (int.TryParse(tbo.Text, out _)) {   //if else způsob.. prý lepší
                //lastValidText2 = tbo.Text;
                if (lastValidText.ContainsKey(tbo.Name))  //místo tbo.Name může být sender
                    lastValidText[tbo.Name] = tbo.Text;
                else
                    lastValidText.Add(tbo.Name, tbo.Text);
            }
            else {
                if (lastValidText.ContainsKey(tbo.Name))
                    tbo.Text = (string)lastValidText[tbo.Name];
                else
                    tbo.Text = "";

                tbo.SelectionStart = tbo.TextLength;


                //tbo.Text = lastValidText2;
                //tbo.SelectionStart = tb2.TextLength;
            }

            //try {
            //    int b = int.Parse(tb2.Text);
            //    lastValidText2 = tb2.Text;
            //}
            //catch (Exception) {
            //    tb2.Text = lastValidText2;
            //    tb2.SelectionStart = tb2.TextLength;
            //}

        }






    }
}
