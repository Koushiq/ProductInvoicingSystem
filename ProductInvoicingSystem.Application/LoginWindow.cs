using ProductInvoicingSystem.Service.Catalog;

namespace ProductInvoicingSystem.App
{
    public partial class LoginWindow : Form
    {
        private readonly IProductService productService;
        public LoginWindow(IProductService productService)
        {
            this.productService = productService;
            InitializeComponent();
        }
    }
}