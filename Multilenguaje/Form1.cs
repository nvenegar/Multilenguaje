using System;
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





namespace Multilenguaje
{
   
    public partial class frm1Main : Form
    {
        // Declara variable ResManager para acceder a Resouce Manager. Para administrar recursos que proporcionan un acceso mas comodo a los recursos de la referencia cultural
        ResourceManager ResManager;
        // Declara variable para acceder a a una referencia cultural ( Configuracion Regional )
        CultureInfo CuInfo;
        public frm1Main()
        {
            InitializeComponent();
        }

        void switch_language()
        {
            if (españolToolStripMenuItem .Checked == true)    //En español
            {
                CuInfo = CultureInfo.CreateSpecificCulture("ES-CO");    //crea culture info para español
            }
            else                                                //En English
            {
                CuInfo = CultureInfo.CreateSpecificCulture("EN-US");     //create culture for english
            }

            this.abrirToolStripMenuItem.Text = ResManager.GetString("abrirToolStripMenuItem", CuInfo);
            this.guardarToolStripMenuItem.Text= ResManager.GetString("guardarToolStripMenuItem", CuInfo);
            this.cerrarToolStripMenuItem.Text = ResManager.GetString("cerrarToolStripMenuItem", CuInfo);
            this.salirToolStripMenuItem.Text = ResManager.GetString("salirToolStripMenuItem", CuInfo);
            this.inglesToolStripMenuItem.Text = ResManager.GetString("inglesToolStripMenuItem", CuInfo);
            this.españolToolStripMenuItem.Text = ResManager.GetString("españolToolStripMenuItem", CuInfo);
        }

        private void frm1Main_Load(object sender, EventArgs e)
        {
            españolToolStripMenuItem .Checked = false;    //default language is english
            inglesToolStripMenuItem .Checked = true;  //Defecto Idioma Ingles
            ResManager = new ResourceManager("Multilenguaje.RecursosdeIdioma.Res", typeof(frm1Main).Assembly);
            //switch to vietnamese
            switch_language();

            this.abrirToolStripMenuItem.Text = ResManager.GetString("abrirToolStripMenuItem", CuInfo);       
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inglesToolStripMenuItem.Checked == true)    //in Ingles, switch to default language
            {
                españolToolStripMenuItem.Checked = false;
                inglesToolStripMenuItem.Checked = true;        //default language
            }
            else            //current language is not french, switch french
            {
                inglesToolStripMenuItem.Checked = true;
                españolToolStripMenuItem.Checked = false;                
            }
            //switch language
            switch_language();
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (españolToolStripMenuItem.Checked == true)    //in Ingles, switch to default language
            {
                españolToolStripMenuItem.Checked = true ;
                inglesToolStripMenuItem.Checked = false;        //default language
            }
            else            //current language is not french, switch french
            {
                inglesToolStripMenuItem.Checked = true;
                españolToolStripMenuItem.Checked = false;
            }
            //switch language
            switch_language();
        }
    }  

}

