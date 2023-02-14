using ProductInvoicingSystem.Service.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductInvoicingSystem.WindowsDesktopApplication
{
    public partial class MainWindow : Form
    {
        private readonly IProductService productService;
        public MainWindow(IProductService productService)
        {
            this.productService = productService;
            InitializeComponent();
        }
    }
}
