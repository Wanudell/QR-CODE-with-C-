using QRCoder;

namespace QRCodeGenerate
{
    public partial class frmQR : Form
    {
        public frmQR()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtWhatYouWant.Text, QRCodeGenerator.ECCLevel.H);
            QRCode code = new QRCode(data);
            pbQR.Image = code.GetGraphic(7);
        }
    }
}