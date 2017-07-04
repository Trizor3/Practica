﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    interface IControlFactory
    {
        Control CreateTextBox();
        Control CreateCheckBox();
    }



    public class RedControlFactory : IControlFactory
    {
        public Control CreateTextBox()
        {
            return new TextBox { BackColor = Color.Red };
        }
        public Control CreateCheckBox()
        {
            return new CheckBox { BackColor = Color.Red };
        }
    }
    public class GreenControlFactory : IControlFactory
    {
        public Control CreateTextBox()
        {
            return new TextBox { BackColor = Color.Green };
        }
        public Control CreateCheckBox()
        {
            return new CheckBox { BackColor = Color.Green };
        }
    }    private void Form1_Load(object sender, EventArgs e)
        {
            CreateGui(new RedControlFactory());
        }}
