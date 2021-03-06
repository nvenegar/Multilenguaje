﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Threading;

namespace Multilenguaje
{
   
    public partial class frm1Main : Form
    {
        // Declara variable ResManager para acceder a Resouce Manager. Administrar recursos que proporcionan un acceso mas comodo a los recursos de la referencia cultural
        ResourceManager ResManager;
        // Declara variable para acceder a a una referencia cultural
        CultureInfo CuInfo;
        public frm1Main()
        {
            InitializeComponent();
        }

        void switch_language()
        {
            if (españolToolStripMenuItem .Checked == true)    //En español
            {
                CuInfo = CultureInfo.CreateSpecificCulture("Es-CO");    //crea culture info para español
                Thread.CurrentThread.CurrentUICulture = CuInfo;
            }
            else                                                //En English
            {
                CuInfo = CultureInfo.CreateSpecificCulture("En-US");     //Crea culture for english
                Thread.CurrentThread.CurrentUICulture = CuInfo;
            }

            this.abrirToolStripMenuItem.Text = ResManager.GetString("abrirToolStripMenuItem", CuInfo);
            this.guardarToolStripMenuItem.Text= ResManager.GetString("guardarToolStripMenuItem", CuInfo);
            this.cerrarToolStripMenuItem.Text = ResManager.GetString("cerrarToolStripMenuItem", CuInfo);
            this.salirToolStripMenuItem.Text = ResManager.GetString("salirToolStripMenuItem", CuInfo);
            this.inglesToolStripMenuItem.Text = ResManager.GetString("inglesToolStripMenuItem", CuInfo);
            this.españolToolStripMenuItem.Text = ResManager.GetString("españolToolStripMenuItem", CuInfo);
            this.archivoToolStripMenuItem.Text = ResManager.GetString("archivoToolStripMenuItem", CuInfo);
            this.idiomaToolStripMenuItem.Text = ResManager.GetString("idiomaToolStripMenuItem", CuInfo);          
        }

        private void frm1Main_Load(object sender, EventArgs e)
        {
            españolToolStripMenuItem .Checked = true;    //Leguaje por defecto español
            inglesToolStripMenuItem .Checked = false;  
            ResManager = new ResourceManager("Multilenguaje.RecursosdeIdioma.Res", typeof(frm1Main).Assembly);
            //Cambia el idioma al que se encuentra por defecto
            switch_language();            
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inglesToolStripMenuItem.Checked = true;

            if (inglesToolStripMenuItem.Checked == true)    //Si en el Menu esta seleccionado Ingles
            {
                españolToolStripMenuItem.Checked = false;
                inglesToolStripMenuItem.Checked = true;        //default language
            }
            else            //Si en el Menu esta seleccionado Español  
            {
                inglesToolStripMenuItem.Checked = false;
                españolToolStripMenuItem.Checked = true;                
            }
            //Cambiar Lenguaje
            switch_language();
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            españolToolStripMenuItem.Checked = true;
            if (españolToolStripMenuItem.Checked == true)    //Se se selecciona en el Menu Español
            {
                españolToolStripMenuItem.Checked = true ;
                inglesToolStripMenuItem.Checked = false;        //Se cambia la seleccion a Español
            }
            else            //current language is not french, switch french
            {
                inglesToolStripMenuItem.Checked = false;
                españolToolStripMenuItem.Checked = true;
            }
            //switch language
            switch_language();
        }
    }  

}

