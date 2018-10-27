using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class ViewExportForm : Form
    {
        private readonly Export _export;
        private IEnumerable<ExportedPost> _currentResults;


        public ViewExportForm(Export export)
        {
            InitializeComponent();
            _export = export;

            GridControl.Export = _export;
        }
    }
}
