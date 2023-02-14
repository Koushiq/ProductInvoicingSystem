using ProductInvoicingSystem.Service.Catalog;

namespace ProductInvoicingSystem.WindowsDesktopApplication
{
    public partial class LoginWindow : Form
    {
        private readonly IProductService productService;
        private readonly MainWindow mainWindow;
        public LoginWindow(IProductService productService,
                           MainWindow mainWindow)
        {
            this.productService = productService;
            this.mainWindow = mainWindow;
            InitializeComponent();
        }
    }
}