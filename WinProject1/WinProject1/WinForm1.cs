﻿// File: WinForm1.cs
using System;
using System.Windows.Forms;

class MyForm : Form
{
    public MyForm()
    {
        // Change the caption of the application.
        Text = "Hello World";
    }

    static void Main()
    {
        MyForm myForm = new MyForm();

        // Display the form.
        Application.Run(myForm);
    }
}